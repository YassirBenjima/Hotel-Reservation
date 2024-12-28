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
    public partial class UserControlSetting : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yassir\Documents\HotelMangementSystem.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private string ID = "";
        public UserControlSetting()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            comboBoxRole.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
            tabControlUser.SelectedTab = tabPageAddUser;
        }
        public void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxPassword1.Clear();
            comboBoxRole1.SelectedIndex = -1;
            comboBoxStatus1.SelectedIndex = -1;
            ID = "";
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Users";
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
                            dataGridViewUser.DataSource = dataTable;
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

        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {
            string username = textBoxSearchUsername.Text.Trim();
            string query;
            if (string.IsNullOrEmpty(username))
            {
                query = "SELECT * FROM Users";
            }
            else
            {
                query = "SELECT * FROM Users WHERE Username LIKE @Username";
            }

            using (SqlConnection connection = new SqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(username))
                        {
                            selectCommand.Parameters.AddWithValue("@Username", "%" + username + "%");
                        }

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
                        {
                            DataTable dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);
                            dataGridViewUser.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }

        private void tabPageUpdateAndDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string role = comboBoxRole.SelectedItem?.ToString();
            string status = comboBoxStatus.SelectedItem?.ToString();
            DateTime dateRegister = DateTime.Now;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, Password, Role, Status, date_register) VALUES (@Username, @Password, @Role, @Status, @DateRegister)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@DateRegister", dateRegister);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Utilisateur ajouté avec succès.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Échec de l'ajout de l'utilisateur.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxUsername1.Text = row.Cells[1].Value.ToString();
                textBoxPassword1.Text = row.Cells[2].Value.ToString();
                comboBoxRole1.SelectedItem = row.Cells[3].Value.ToString();
                comboBoxStatus1.SelectedItem = row.Cells[4].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à mettre à jour.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = textBoxUsername1.Text.Trim();
            string password = textBoxPassword1.Text.Trim();
            string role = comboBoxRole1.SelectedItem?.ToString();
            string status = comboBoxStatus1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string query = "UPDATE Users SET Username = @Username, Password = @Password, Role = @Role, Status = @Status WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@Status", status);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Utilisateur mis à jour avec succès.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tabControlUser.SelectedTab = tabPageSearchUser;
                            Clear1();
                        }
                        else
                        {
                            MessageBox.Show("Échec de la mise à jour de l'utilisateur.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        string query = "DELETE FROM Users WHERE ID = @ID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", ID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Utilisateur supprimé avec succès.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tabControlUser.SelectedTab = tabPageSearchUser;
                                Clear1();
                            }
                            else
                            {
                                MessageBox.Show("Échec de la suppression de l'utilisateur.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
