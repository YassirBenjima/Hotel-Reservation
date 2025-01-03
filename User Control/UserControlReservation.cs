using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
namespace ReservationHotel.User_Control
{
    public partial class UserControlReservation : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yassir\Documents\HotelMangementSystem.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private string RID = "", No = "";
        private bool isClearing = false;
        public UserControlReservation()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            isClearing = true;
            comboBoxTypeRoomReservation.SelectedIndex = -1;
            comboBoxRoomNumberReservation.SelectedIndex = -1;
            textBoxClientIdReservation.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tabPageAddReservation;
            isClearing = false;
        }
        public void Clear1()
        {
            comboBoxTypeRoomReservation1.SelectedIndex = -1;
            comboBoxRoomNumberReservation1.SelectedIndex = -1;
            textBoxClientIdReservation1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = "";
        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            LoadRoomTypes();
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void LoadRoomTypes()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = @"
            SELECT DISTINCT Room_Type
            FROM Rooms
            WHERE Room_Status = 'Actif'
            AND Room_Free = 'Oui'
            AND Room_Number NOT IN (
                SELECT Reservation_Room_Number
                FROM Reservations
                WHERE Reservation_In <= GETDATE() AND Reservation_Out >= GETDATE()
            );";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                comboBoxTypeRoomReservation.Items.Clear();
                while (reader.Read())
                {
                    comboBoxTypeRoomReservation.Items.Add(reader["Room_Type"].ToString());
                }
                reader.Close();

                if (comboBoxTypeRoomReservation.Items.Count > 0)
                    comboBoxTypeRoomReservation.SelectedIndex = 0;
            }
        }



        private void comboBoxTypeRoomReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isClearing) return;

            if (comboBoxTypeRoomReservation.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un type de chambre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRoomType = comboBoxTypeRoomReservation.SelectedItem.ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string query = @"
                SELECT Room_Number
                FROM Rooms
                WHERE Room_Type = @RoomType
                  AND Room_Status = 'Actif'
                  AND Room_Free = 'Oui'
                  AND Room_Number NOT IN (
                      SELECT Reservation_Room_Number
                      FROM Reservations
                      WHERE Reservation_In <= GETDATE() AND Reservation_Out >= GETDATE()
                  );";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RoomType", selectedRoomType);
                    SqlDataReader reader = command.ExecuteReader();

                    comboBoxRoomNumberReservation.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxRoomNumberReservation.Items.Add(reader["Room_Number"].ToString());
                    }
                    reader.Close();

                    if (comboBoxRoomNumberReservation.Items.Count > 0)
                        comboBoxRoomNumberReservation.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour des numéros de chambre : " + ex.Message);
            }
        }



        private bool ClientExists(int clientId)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Clients WHERE id_client = @ClientId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientId", clientId);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeRoomReservation.SelectedIndex == -1 ||
                comboBoxRoomNumberReservation.SelectedIndex == -1 ||
                string.IsNullOrEmpty(textBoxClientIdReservation.Text) ||
                dateTimePickerIn.Value >= dateTimePickerOut.Value)
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement avant d'ajouter une réservation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string roomType = comboBoxTypeRoomReservation.SelectedItem.ToString();
            int roomNumber;
            int clientId;

            if (!int.TryParse(comboBoxRoomNumberReservation.SelectedItem.ToString(), out roomNumber))
            {
                MessageBox.Show("Numéro de chambre invalide. Veuillez sélectionner une valeur correcte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxClientIdReservation.Text, out clientId))
            {
                MessageBox.Show("ID client invalide. Veuillez entrer un entier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime checkIn = dateTimePickerIn.Value;
            DateTime checkOut = dateTimePickerOut.Value;

            if (!ClientExists(clientId))
            {
                MessageBox.Show("L'ID du client n'existe pas. Veuillez en créer un nouveau ou vérifier les informations.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    string insertQuery = @"
        INSERT INTO Reservations (Reservation_Room_Type, Reservation_Room_Number, Reservation_Client_ID, Reservation_In, Reservation_Out)
        OUTPUT INSERTED.Reservation_ID
        VALUES (@RoomType, @RoomNumber, @ClientId, @CheckIn, @CheckOut);";

                    int reservationId;
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@RoomType", roomType);
                        insertCommand.Parameters.AddWithValue("@RoomNumber", roomNumber);
                        insertCommand.Parameters.AddWithValue("@ClientId", clientId);
                        insertCommand.Parameters.AddWithValue("@CheckIn", checkIn);
                        insertCommand.Parameters.AddWithValue("@CheckOut", checkOut);

                        reservationId = (int)insertCommand.ExecuteScalar();
                    }

                    if (reservationId > 0)
                    {
                        string updateQuery = @"
                UPDATE Rooms
                SET Room_Free = 'Non'
                WHERE Room_Number = @RoomNumber;";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@RoomNumber", roomNumber);
                            updateCommand.ExecuteNonQuery();
                        }

                        string clientEmail = "";
                        string getEmailQuery = "SELECT Email FROM Clients WHERE id_client = @ClientId;";
                        using (SqlCommand getEmailCommand = new SqlCommand(getEmailQuery, connection))
                        {
                            getEmailCommand.Parameters.AddWithValue("@ClientId", clientId);
                            clientEmail = getEmailCommand.ExecuteScalar()?.ToString();
                        }

                        if (string.IsNullOrEmpty(clientEmail))
                        {
                            MessageBox.Show("Impossible de récupérer l'e-mail du client.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string pdfPath = $"Reservation_{reservationId}.pdf";
                        GeneratePDF(pdfPath, reservationId);

                        if (System.IO.File.Exists(pdfPath))
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                            {
                                FileName = pdfPath,
                                UseShellExecute = true 
                            });
                        }

                        string emailBody = "Votre réservation a été confirmée. Veuillez trouver ci-joint le bon de réservation.";
                        SendEmailWithPDF(clientEmail, "Confirmation de réservation", emailBody, pdfPath, clientId);
                        MessageBox.Show("Réservation ajoutée avec succès et e-mail envoyé avec le PDF !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Impossible d'ajouter la réservation. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la réservation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void tabPageSearchReservation_Enter(object sender, EventArgs e)
        {
            string query = @"
                                SELECT 
                                    R.Reservation_ID,
                                    R.Reservation_Room_Type,
                                    R.Reservation_Room_Number,
                                    R.Reservation_Client_ID,
                                    CONCAT(C.FirstName, ' ', C.LastName) AS Client_Name,
                                    R.Reservation_In,
                                    R.Reservation_Out
                                FROM 
                                    Reservations R
                                LEFT JOIN 
                                    Clients C
                                ON 
                                    R.Reservation_Client_ID = C.id_client";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                        {
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);
                            dataGridViewReservation.DataSource = dataTable;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erreur SQL lors de la récupération des données : " + ex.Message, "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxSearchClientId_TextChanged(object sender, EventArgs e)
        {
            string clientId = textBoxSearchClientId.Text.Trim();
            string query;

            if (string.IsNullOrEmpty(clientId))
            {
                query = "SELECT * FROM Reservations";
            }
            else
            {
                query = "SELECT * FROM Clients WHERE Reservation_Client_ID LIKE @ClientId";
            }

            using (SqlConnection connection = new SqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(clientId))
                        {
                            selectCommand.Parameters.AddWithValue("@ClientId", "%" + clientId + "%");
                        }

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                        {
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);
                            dataGridViewReservation.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadRoomTypesForUpdate()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string query = @"
                        SELECT DISTINCT Room_Type
                        FROM Rooms
                        WHERE Room_Status = 'Actif'
                        AND Room_Free = 'Oui'
                        AND (Room_Number NOT IN (
                            SELECT Reservation_Room_Number
                            FROM Reservations
                            WHERE 
                            (@CheckIn BETWEEN Reservation_In AND Reservation_Out
                            OR @CheckOut BETWEEN Reservation_In AND Reservation_Out
                            OR Reservation_In BETWEEN @CheckIn AND @CheckOut)
                        ) OR Room_Type = @SelectedRoomType);";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CheckIn", dateTimePickerIn1.Value);
                    command.Parameters.AddWithValue("@CheckOut", dateTimePickerOut1.Value);
                    command.Parameters.AddWithValue("@SelectedRoomType", comboBoxTypeRoomReservation1.SelectedItem?.ToString() ?? "");

                    SqlDataReader reader = command.ExecuteReader();

                    comboBoxTypeRoomReservation1.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxTypeRoomReservation1.Items.Add(reader["Room_Type"].ToString());
                    }
                    reader.Close();

                    if (comboBoxTypeRoomReservation1.Items.Count > 0 && string.IsNullOrEmpty(RID))
                        comboBoxTypeRoomReservation1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des types de chambre (Update) : " + ex.Message);
            }
        }


        private void LoadRoomNumbersForUpdate(string selectedRoomType)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string query = @"
            SELECT Room_Number
            FROM Rooms
            WHERE Room_Type = @RoomType
              AND Room_Status = 'Actif'
              AND Room_Free = 'Oui'
              AND (Room_Number NOT IN (
                  SELECT Reservation_Room_Number
                  FROM Reservations
                  WHERE 
                  (@CheckIn BETWEEN Reservation_In AND Reservation_Out
                  OR @CheckOut BETWEEN Reservation_In AND Reservation_Out
                  OR Reservation_In BETWEEN @CheckIn AND @CheckOut)
              ) OR Room_Number = @SelectedRoomNumber);";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RoomType", selectedRoomType);
                    command.Parameters.AddWithValue("@CheckIn", dateTimePickerIn1.Value);
                    command.Parameters.AddWithValue("@CheckOut", dateTimePickerOut1.Value);
                    command.Parameters.AddWithValue("@SelectedRoomNumber", comboBoxRoomNumberReservation1.SelectedItem?.ToString() ?? "");

                    SqlDataReader reader = command.ExecuteReader();

                    comboBoxRoomNumberReservation1.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxRoomNumberReservation1.Items.Add(reader["Room_Number"].ToString());
                    }
                    reader.Close();

                    if (comboBoxRoomNumberReservation1.Items.Count > 0 && string.IsNullOrEmpty(RID))
                        comboBoxRoomNumberReservation1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour des numéros de chambre (Update) : " + ex.Message);
            }
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RID) || comboBoxTypeRoomReservation1.SelectedIndex == -1 ||
                comboBoxRoomNumberReservation1.SelectedIndex == -1 || string.IsNullOrEmpty(textBoxClientIdReservation1.Text) ||
                dateTimePickerIn1.Value >= dateTimePickerOut1.Value)
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement avant de mettre à jour une réservation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string roomType = comboBoxTypeRoomReservation1.SelectedItem.ToString();
            int roomNumber = int.Parse(comboBoxRoomNumberReservation1.SelectedItem.ToString());
            int clientId;

            if (!int.TryParse(textBoxClientIdReservation1.Text, out clientId))
            {
                MessageBox.Show("ID client invalide. Veuillez entrer un entier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime checkIn = dateTimePickerIn1.Value;
            DateTime checkOut = dateTimePickerOut1.Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    string getOldRoomQuery = "SELECT Reservation_Room_Number FROM Reservations WHERE Reservation_ID = @ReservationID;";
                    int oldRoomNumber = 0;

                    using (SqlCommand getOldRoomCommand = new SqlCommand(getOldRoomQuery, connection))
                    {
                        getOldRoomCommand.Parameters.AddWithValue("@ReservationID", RID);
                        object result = getOldRoomCommand.ExecuteScalar();
                        if (result != null)
                        {
                            oldRoomNumber = Convert.ToInt32(result);
                        }
                    }

                    string updateQuery = @"
                UPDATE Reservations
                SET Reservation_Room_Type = @RoomType,
                    Reservation_Room_Number = @RoomNumber,
                    Reservation_Client_ID = @ClientId,
                    Reservation_In = @CheckIn,
                    Reservation_Out = @CheckOut
                WHERE Reservation_ID = @ReservationID;";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@RoomType", roomType);
                        updateCommand.Parameters.AddWithValue("@RoomNumber", roomNumber);
                        updateCommand.Parameters.AddWithValue("@ClientId", clientId);
                        updateCommand.Parameters.AddWithValue("@CheckIn", checkIn);
                        updateCommand.Parameters.AddWithValue("@CheckOut", checkOut);
                        updateCommand.Parameters.AddWithValue("@ReservationID", RID);

                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            if (oldRoomNumber != roomNumber)
                            {
                                string freeOldRoomQuery = "UPDATE Rooms SET Room_Free = 'Oui' WHERE Room_Number = @OldRoomNumber;";
                                using (SqlCommand freeOldRoomCommand = new SqlCommand(freeOldRoomQuery, connection))
                                {
                                    freeOldRoomCommand.Parameters.AddWithValue("@OldRoomNumber", oldRoomNumber);
                                    freeOldRoomCommand.ExecuteNonQuery();
                                }

                                string occupyNewRoomQuery = "UPDATE Rooms SET Room_Free = 'Non' WHERE Room_Number = @NewRoomNumber;";
                                using (SqlCommand occupyNewRoomCommand = new SqlCommand(occupyNewRoomQuery, connection))
                                {
                                    occupyNewRoomCommand.Parameters.AddWithValue("@NewRoomNumber", roomNumber);
                                    occupyNewRoomCommand.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Réservation mise à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear1();
                        }
                        else
                        {
                            MessageBox.Show("Impossible de mettre à jour la réservation. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour de la réservation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RID))
            {
                MessageBox.Show("Veuillez sélectionner une réservation à annuler.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    string getRoomNumberQuery = "SELECT Reservation_Room_Number FROM Reservations WHERE Reservation_ID = @ReservationID;";
                    int roomNumber = 0;

                    using (SqlCommand getRoomNumberCommand = new SqlCommand(getRoomNumberQuery, connection))
                    {
                        getRoomNumberCommand.Parameters.AddWithValue("@ReservationID", RID);
                        object result = getRoomNumberCommand.ExecuteScalar();
                        if (result != null)
                        {
                            roomNumber = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("La réservation sélectionnée n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string deleteQuery = "DELETE FROM Reservations WHERE Reservation_ID = @ReservationID;";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@ReservationID", RID);
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string updateRoomStatusQuery = "UPDATE Rooms SET Room_Free = 'Oui' WHERE Room_Number = @RoomNumber;";
                            using (SqlCommand updateRoomStatusCommand = new SqlCommand(updateRoomStatusQuery, connection))
                            {
                                updateRoomStatusCommand.Parameters.AddWithValue("@RoomNumber", roomNumber);
                                updateRoomStatusCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Réservation annulée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear1();
                            tabControlReservation.SelectedTab = tabPageSearchReservation;
                        }
                        else
                        {
                            MessageBox.Show("Impossible d'annuler la réservation. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'annulation de la réservation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            textBoxSearchClientId.Clear();
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                RID = row.Cells[0].Value.ToString();

                string selectedRoomType = row.Cells[1].Value.ToString();
                string selectedRoomNumber = row.Cells[2].Value.ToString();

                LoadRoomTypesForUpdate();
                comboBoxTypeRoomReservation1.SelectedItem = selectedRoomType;

                LoadRoomNumbersForUpdate(selectedRoomType);
                comboBoxRoomNumberReservation1.SelectedItem = selectedRoomNumber;

                textBoxClientIdReservation1.Text = row.Cells[3].Value.ToString();
                dateTimePickerIn1.Value = Convert.ToDateTime(row.Cells[5].Value);
                dateTimePickerOut1.Value = Convert.ToDateTime(row.Cells[6].Value);
            }
        }


        private void tabPageUpdateDeleteReservation_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void comboBoxTypeRoomReservation1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isClearing || comboBoxTypeRoomReservation1.SelectedItem == null) return;

            string selectedRoomType = comboBoxTypeRoomReservation1.SelectedItem.ToString();
            LoadRoomNumbersForUpdate(selectedRoomType);
        }

        private void dateTimePickerIn1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeRoomReservation1.SelectedItem != null)
            {
                LoadRoomNumbersForUpdate(comboBoxTypeRoomReservation1.SelectedItem.ToString());
            }
        }

        private void dateTimePickerOut1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeRoomReservation1.SelectedItem != null)
            {
                LoadRoomNumbersForUpdate(comboBoxTypeRoomReservation1.SelectedItem.ToString());
            }
        }

        private void tabPageUpdateDeleteReservation_Enter(object sender, EventArgs e)
        {
            LoadRoomTypesForUpdate();
        }


        // EXPORT
        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (.csv)|.csv|All files (.)|.";
                saveFileDialog.Title = "Exporter les données";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToCSV(saveFileDialog.FileName);
                }
            }
        }
        private void ExportToCSV(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    for (int i = 0; i < dataGridViewReservation.Columns.Count; i++)
                    {
                        sw.Write(dataGridViewReservation.Columns[i].HeaderText);
                        if (i < dataGridViewReservation.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    foreach (DataGridViewRow row in dataGridViewReservation.Rows)
                    {
                        for (int i = 0; i < dataGridViewReservation.Columns.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value?.ToString());
                            if (i < dataGridViewReservation.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }
                MessageBox.Show("Données exportées avec succès en CSV !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation : " + ex.Message);
            }
        }

        // IMPORT
        private void buttonImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (.csv)|.csv|All files (.)|.";
                openFileDialog.Title = "Importer les données";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImportFromCSV(openFileDialog.FileName);
                }
            }
        }
        private void ImportFromCSV(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    sr.ReadLine(); 

                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        while ((line = sr.ReadLine()) != null)
                        {
                            var data = line.Split(',');

                            DateTime checkIn;
                            DateTime checkOut;

                            if (!DateTime.TryParse(data[5], out checkIn) || !DateTime.TryParse(data[6], out checkOut))
                            {
                                MessageBox.Show($"Erreur lors de la conversion des dates : {data[5]} ou {data[6]} n'est pas valide.");
                                continue;
                            }

                            string query = @"
                        INSERT INTO Reservations (Reservation_Room_Type, Reservation_Room_Number, Reservation_Client_ID, Reservation_In, Reservation_Out)
                        VALUES (@RoomType, @RoomNumber, @ClientId, @CheckIn, @CheckOut);";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@RoomType", data[1]);
                                command.Parameters.AddWithValue("@RoomNumber", int.Parse(data[2]));
                                command.Parameters.AddWithValue("@ClientId", int.Parse(data[3]));
                                command.Parameters.AddWithValue("@CheckIn", checkIn);
                                command.Parameters.AddWithValue("@CheckOut", checkOut);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Données importées avec succès depuis le CSV !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'importation : " + ex.Message);
            }
        }

        // Generate PDF
        private void GeneratePDF(string filePath, int reservationId)
        {
            try
            {
                string firstName = "";
                string lastName = "";

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    string query = @"
            SELECT R.*, C.FirstName, C.LastName, Ro.Room_Price
            FROM Reservations R
            JOIN Clients C ON R.Reservation_Client_ID = C.id_client
            JOIN Rooms Ro ON R.Reservation_Room_Number = Ro.Room_Number
            WHERE R.Reservation_ID = @ReservationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", reservationId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                firstName = reader["FirstName"].ToString();
                                lastName = reader["LastName"].ToString();
                                decimal roomPrice = reader["Room_Price"] != DBNull.Value
                                    ? Convert.ToDecimal(reader["Room_Price"])
                                    : 0;

                                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                                using (var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 50, 50))
                                using (var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs))
                                {
                                    doc.Open();

                                    string logoPath = @"C:\Users\Yassir\Downloads\app_logo.png";
                                    if (System.IO.File.Exists(logoPath))
                                    {
                                        var logo = iTextSharp.text.Image.GetInstance(logoPath);
                                        logo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                                        logo.ScaleAbsolute(400, 200);
                                        doc.Add(logo);
                                    }

                                    var titleFont = iTextSharp.text.FontFactory.GetFont("Arial", 24, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE);
                                    var title = new iTextSharp.text.Paragraph("EMSI Hotel - Bon de Réservation", titleFont)
                                    {
                                        Alignment = iTextSharp.text.Element.ALIGN_CENTER,
                                        SpacingAfter = 20
                                    };
                                    doc.Add(title);

                                    var detailsFont = iTextSharp.text.FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL);
                                    var details = new iTextSharp.text.Paragraph
                                    {
                                        SpacingBefore = 10,
                                        SpacingAfter = 10
                                    };

                                    details.Add(new iTextSharp.text.Paragraph($"Client : {firstName} {lastName}", detailsFont));
                                    details.Add(new iTextSharp.text.Paragraph($"ID Réservation : {reader["Reservation_ID"]}", detailsFont));
                                    details.Add(new iTextSharp.text.Paragraph($"Type de Chambre : {reader["Reservation_Room_Type"]}", detailsFont));
                                    details.Add(new iTextSharp.text.Paragraph($"Numéro de Chambre : {reader["Reservation_Room_Number"]}", detailsFont));
                                    details.Add(new iTextSharp.text.Paragraph($"Prix de la Chambre : {roomPrice:C}", detailsFont));
                                    details.Add(new iTextSharp.text.Paragraph($"Date d'entrée : {reader["Reservation_In"]}", detailsFont));
                                    details.Add(new iTextSharp.text.Paragraph($"Date de sortie : {reader["Reservation_Out"]}", detailsFont));
                                    doc.Add(details);

                                    var footerFont = iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.GRAY);
                                    var footer = new iTextSharp.text.Paragraph("Merci de faire confiance à EMSI Hotel. À bientôt !", footerFont)
                                    {
                                        Alignment = iTextSharp.text.Element.ALIGN_CENTER,
                                        SpacingBefore = 50
                                    };
                                    doc.Add(footer);

                                    doc.Close();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la génération du PDF : {ex.Message}");
            }
        }


        //SEND Mail
        private void SendEmailWithPDF(string toEmail, string subject, string body, string pdfFilePath, int clientId)
        {
            try
            {
                string firstName = "";
                string lastName = "";
                string roomType = "";
                string roomNumber = "";
                DateTime checkIn = DateTime.MinValue;
                DateTime checkOut = DateTime.MinValue;
                decimal roomPrice = 0;

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    string query = @"
            SELECT C.FirstName, C.LastName, R.Reservation_Room_Type, R.Reservation_Room_Number, 
                   R.Reservation_In, R.Reservation_Out, Ro.Room_Price
            FROM Clients C
            JOIN Reservations R ON C.id_client = R.Reservation_Client_ID
            JOIN Rooms Ro ON R.Reservation_Room_Number = Ro.Room_Number
            WHERE C.id_client = @ClientId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientId", clientId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                firstName = reader["FirstName"].ToString();
                                lastName = reader["LastName"].ToString();
                                roomType = reader["Reservation_Room_Type"].ToString();
                                roomNumber = reader["Reservation_Room_Number"].ToString();
                                checkIn = Convert.ToDateTime(reader["Reservation_In"]);
                                checkOut = Convert.ToDateTime(reader["Reservation_Out"]);
                                roomPrice = reader["Room_Price"] != DBNull.Value ? Convert.ToDecimal(reader["Room_Price"]) : 0;
                            }
                        }
                    }
                }

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("from@example.com");
                    mail.To.Add(toEmail);
                    mail.Subject = subject;

                    string emailBody = $@"
                            <html>
                            <head>
                                <style>
                                    body {{
                                        font-family: Arial, sans-serif;
                                        margin: 0;
                                        padding: 0;
                                        background-color: #f9f9f9;
                                        color: #333;
                                    }}
                                    .header {{
                                        text-align: center;
                                        padding: 20px;
                                        background-color: #198754;
                                        color: #fff;
                                        font-size: 24px;
                                        font-weight: bold;
                                    }}
                                    .content {{
                                        padding: 20px;
                                        background-color: #fff;
                                        margin: 20px;
                                        border-radius: 8px;
                                        box-shadow: 0 2px 4px rgba(0,0,0,0.1);
                                    }}
                                    .footer {{
                                        text-align: center;
                                        padding: 10px;
                                        font-size: 12px;
                                        color: #777;
                                    }}
                                    .footer a {{
                                        color: #003366;
                                        text-decoration: none;
                                    }}
                                </style>
                            </head>
                            <body>
                                <div class='header'>
                                    EMSI Hotel - Bon de Réservation
                                </div>
                                <div class='content'>
                                    <p>Bonjour <strong>{firstName} {lastName}</strong>,</p>
                                    <p>Merci d'avoir choisi <strong>EMSI Hotel</strong> pour votre réservation.</p>
                                    <p>Voici les détails de votre réservation :</p>
                                    <ul>
                                        <li><strong>Type de Chambre :</strong> {roomType}</li>
                                        <li><strong>Numéro de Chambre :</strong> {roomNumber}</li>
                                        <li><strong>Prix de la Chambre :</strong> {roomPrice:C}</li>
                                        <li><strong>Date d'entrée :</strong> {checkIn:dd/MM/yyyy}</li>
                                        <li><strong>Date de sortie :</strong> {checkOut:dd/MM/yyyy}</li>
                                    </ul>
                                    <p>Vous trouverez en pièce jointe votre bon de réservation.</p>
                                    <p>Nous sommes ravis de vous accueillir dans notre établissement.</p>
                                </div>
                                <div class='footer'>
                                    <p>Merci de faire confiance à EMSI Hotel. Pour toute question, contactez-nous à <a href='mailto:support@emsihotel.com'>support@emsihotel.com</a>.</p>
                                </div>
                            </body>
                            </html>";

                    mail.IsBodyHtml = true;
                    mail.Body = emailBody;

                    if (!string.IsNullOrEmpty(pdfFilePath))
                    {
                        mail.Attachments.Add(new Attachment(pdfFilePath));
                    }

                    using (SmtpClient smtp = new SmtpClient("sandbox.smtp.mailtrap.io", 2525))
                    {
                        smtp.Credentials = new NetworkCredential("6c8352358343fc", "8bd6571eb4cd04");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'envoi de l'e-mail : {ex.Message}");
            }
        }
    }
}
