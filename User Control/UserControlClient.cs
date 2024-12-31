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
using System.Windows.Forms.VisualStyles;

namespace ReservationHotel.User_Control
{
    public partial class UserControlClient : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yassir\Documents\HotelMangementSystem.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private string ID = "";
        public UserControlClient()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            textBoxEmail.Clear();
            textBoxPasswordClient.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhone.Clear();
            textBoxAdresse.Clear();
            tabControlClient.SelectedTab = tabPageAddClient;
        }

        public void Clear1()
        {
            textBoxEmail1.Clear();
            textBoxPasswordClient1.Clear();
            textBoxFirstName1.Clear();
            textBoxLastName1.Clear();
            textBoxPhone1.Clear();
            textBoxAdresse1.Clear();
            ID = "";
        }
        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPasswordClient.Text.Trim();
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string address = textBoxAdresse.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please fill in all required fields (Email, Password, First Name, Last Name).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string query = "INSERT INTO Clients (Email, Password, FirstName, LastName, Phone, Address) VALUES (@Email, @Password, @FirstName, @LastName, @Phone, @Address)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(phone) ? (object)DBNull.Value : phone);
                        command.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Client added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Clients";
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
                            dataGridViewClient.DataSource = dataTable;
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

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            textBoxSearchEmail.Clear();
        }

        private void textBoxSearchEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxSearchEmail.Text.Trim();
            string query;
            if (string.IsNullOrEmpty(email))
            {
                query = "SELECT * FROM Clients";
            }
            else
            {
                query = "SELECT * FROM Clients WHERE Email LIKE @Email";
            }

            using (SqlConnection connection = new SqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(email))
                        {
                            selectCommand.Parameters.AddWithValue("@email", "%" + email + "%");
                        }

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                        {
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);
                            dataGridViewClient.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Veuillez sélectionner un client à mettre à jour.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = textBoxEmail1.Text.Trim();
            string password = textBoxPasswordClient1.Text.Trim();
            string firstName = textBoxFirstName1.Text.Trim();
            string lastName = textBoxLastName1.Text.Trim();
            string phone = textBoxPhone1.Text.Trim();
            string address = textBoxAdresse1.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string query = "UPDATE Clients SET Email = @Email, Password = @Password, FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Address = @Address WHERE id_client = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Address", address);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Client mis à jour avec succès.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tabControlClient.SelectedTab = tabPageSearchClient;
                            Clear1();
                        }
                        else
                        {
                            MessageBox.Show("Échec de la mise à jour du client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        string query = "DELETE FROM Clients WHERE id_client = @ID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", ID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Client supprimé avec succès.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tabControlClient.SelectedTab = tabPageSearchClient;
                                Clear1();
                            }
                            else
                            {
                                MessageBox.Show("Échec de la suppression du client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];

                ID = row.Cells[0].Value?.ToString() ?? string.Empty;
                textBoxEmail1.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                textBoxPasswordClient1.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                textBoxFirstName1.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                textBoxLastName1.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                textBoxPhone1.Text = row.Cells[5].Value?.ToString() ?? string.Empty;
                textBoxAdresse1.Text = row.Cells[6].Value?.ToString() ?? string.Empty;
            }
        }

    }
}
