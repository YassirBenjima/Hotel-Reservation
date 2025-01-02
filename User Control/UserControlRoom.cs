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

namespace ReservationHotel.User_Control
{
    public partial class UserControlRoom : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yassir\Documents\HotelMangementSystem.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private string No = "", Free = "";
        public UserControlRoom()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            comboBoxTypeRoom.SelectedIndex = -1;
            textBoxPhoneRoom.Clear();
            comboBoxFreeRoom.SelectedIndex = -1;
            textBoxCapacityRoom.Clear();
            textBoxPriceRoom.Clear();
            comboBoxStatusRoom.SelectedIndex = -1;
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }
        public void Clear1()
        {
            comboBoxTypeRoom1.SelectedIndex = -1;
            textBoxPhoneRoom1.Clear();
            comboBoxFreeRoom1.SelectedIndex = -1;
            textBoxCapacityRoom1.Clear();
            textBoxPriceRoom1.Clear();
            comboBoxStatusRoom1.SelectedIndex = -1;
            No = "";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string typeRoom = comboBoxTypeRoom.SelectedItem?.ToString();
                string phoneRoom = textBoxPhoneRoom.Text.Trim();
                string freeRoom = comboBoxFreeRoom.SelectedItem?.ToString();
                string capacityRoom = textBoxCapacityRoom.Text.Trim();
                string priceRoom = textBoxPriceRoom.Text.Trim();
                string statusRoom = comboBoxStatusRoom.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(typeRoom) || string.IsNullOrEmpty(phoneRoom) ||
                    string.IsNullOrEmpty(freeRoom) || string.IsNullOrEmpty(capacityRoom) ||
                    string.IsNullOrEmpty(priceRoom) || string.IsNullOrEmpty(statusRoom))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(capacityRoom, out int capacity) || capacity <= 0)
                {
                    MessageBox.Show("La capacité doit être un nombre entier positif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(priceRoom, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Le prix doit être un nombre décimal positif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string query = "INSERT INTO Rooms (Room_Type, Room_Phone, Room_Free, Room_Capacity, Room_Price, Room_Status) " +
                                   "VALUES (@RoomType, @RoomPhone, @RoomFree, @RoomCapacity, @RoomPrice, @RoomStatus)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomType", typeRoom);
                        command.Parameters.AddWithValue("@RoomPhone", phoneRoom);
                        command.Parameters.AddWithValue("@RoomFree", freeRoom);
                        command.Parameters.AddWithValue("@RoomCapacity", capacity);
                        command.Parameters.AddWithValue("@RoomPrice", price);
                        command.Parameters.AddWithValue("@RoomStatus", statusRoom);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Chambre ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Échec de l'ajout de la chambre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            string query = "SELECT Room_Number, Room_Type, Room_Phone, Room_Free, Room_Capacity, Room_Price, Room_Status FROM Rooms";
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
                            dataGridViewRoom.DataSource = dataTable;
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


        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoomNo.Clear();
        }

        private void textBoxSearchRoomNo_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearchRoomNo.Text.Trim();
            string query;
            if (string.IsNullOrEmpty(searchValue))
            {
                query = "SELECT * FROM Rooms";
            }
            else
            {
                query = "SELECT * FROM Rooms WHERE Room_Number LIKE @SearchValue";
            }

            using (SqlConnection connection = new SqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(searchValue))
                        {
                            selectCommand.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                        }

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                        {
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);
                            dataGridViewRoom.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                No = row.Cells[0].Value.ToString();
                comboBoxTypeRoom1.SelectedItem = row.Cells[1].Value.ToString();
                textBoxPhoneRoom1.Text = row.Cells[2].Value.ToString();
                comboBoxFreeRoom1.SelectedItem = row.Cells[3].Value.ToString();
                textBoxCapacityRoom1.Text = row.Cells[4].Value.ToString();
                textBoxPriceRoom1.Text = row.Cells[5].Value.ToString();
                comboBoxStatusRoom1.SelectedItem = row.Cells[6].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(No))
            {
                MessageBox.Show("Veuillez sélectionner une chambre à mettre à jour.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string typeRoom = comboBoxTypeRoom1.SelectedItem?.ToString();
            string phoneRoom = textBoxPhoneRoom1.Text.Trim();
            string freeRoom = comboBoxFreeRoom1.SelectedItem?.ToString();
            string capacityRoom = textBoxCapacityRoom1.Text.Trim();
            string priceRoom = textBoxPriceRoom1.Text.Trim();
            string statusRoom = comboBoxStatusRoom1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(typeRoom) || string.IsNullOrEmpty(phoneRoom) ||
                string.IsNullOrEmpty(freeRoom) || string.IsNullOrEmpty(capacityRoom) ||
                string.IsNullOrEmpty(priceRoom) || string.IsNullOrEmpty(statusRoom))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(capacityRoom, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("La capacité doit être un nombre entier positif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceRoom, out decimal price) || price <= 0)
            {
                MessageBox.Show("Le prix doit être un nombre décimal positif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string query = "UPDATE Rooms SET Room_Type = @RoomType, Room_Phone = @RoomPhone, Room_Free = @RoomFree, " +
                                   "Room_Capacity = @RoomCapacity, Room_Price = @RoomPrice, Room_Status = @RoomStatus WHERE Room_Number = @No";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomType", typeRoom);
                        command.Parameters.AddWithValue("@RoomPhone", phoneRoom);
                        command.Parameters.AddWithValue("@RoomFree", freeRoom);
                        command.Parameters.AddWithValue("@RoomCapacity", capacity);
                        command.Parameters.AddWithValue("@RoomPrice", price);
                        command.Parameters.AddWithValue("@RoomStatus", statusRoom);
                        command.Parameters.AddWithValue("@No", No);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Chambre mise à jour avec succès.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tabControlRoom.SelectedTab = tabPageSearchRoom;
                            Clear1();
                        }
                        else
                        {
                            MessageBox.Show("Échec de la mise à jour de la chambre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(No))
            {
                MessageBox.Show("Veuillez sélectionner une chambre à supprimer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette chambre ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        string query = "DELETE FROM Rooms WHERE Room_Number = @No";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@No", No);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Chambre supprimée avec succès.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tabControlRoom.SelectedTab = tabPageSearchRoom;
                                Clear1();
                            }
                            else
                            {
                                MessageBox.Show("Échec de la suppression de la chambre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPageUpdateDeleteRoom_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
    }
}
