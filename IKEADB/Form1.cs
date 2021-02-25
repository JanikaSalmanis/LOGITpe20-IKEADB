using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IKEADB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["IKEADB.Properties.Settings.IKEASConnectionString"].ConnectionString;
        }
        private void PopulateRoomsTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Room", connection))
            {
                DataTable roomTable = new DataTable();
                adapter.Fill(roomTable);
                listRoom.DisplayMember = "RoomName";
                listRoom.ValueMember = "Id";
                listRoom.DataSource = roomTable;
            }
        }
        private void PopulateSeriesName()
        {
            string query = "SELECT Series.SeriesName FROM Series INNER JOIN Room ON Room.Id = Series.RoomId WHERE Room.Id = @RoomId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query,connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("RoomId", listRoom.SelectedValue);
                DataTable seriesNameTable = new DataTable();
                adapter.Fill(seriesNameTable);

                listSeriesName.DisplayMember = "SeriesName";
                listSeriesName.ValueMember = "Id";
                listSeriesName.DataSource = seriesNameTable;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateRoomsTable();
        }

        private void listRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateSeriesName();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
