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
    public partial class UserControlDashoard : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yassir\Documents\HotelMangementSystem.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public UserControlDashoard()
        {
            InitializeComponent();
        }

        private int GetCount(SqlConnection connection, string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return (int)command.ExecuteScalar();
            }
        }

        private void UserControlDashoard_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    labelUserCount.Text = GetCount(connection, "Users").ToString();        
                    labelClientCount.Text = GetCount(connection, "Clients").ToString();
                    labelRoomCount.Text = GetCount(connection, "Rooms").ToString();
                    labelReservationCount.Text = GetCount(connection, "Reservations").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
