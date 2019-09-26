using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemUI
{
    public partial class CoffeeShopUI : Form
    {
        public CoffeeShopUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string conn = @"Server=PC-301-29\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";

            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select * from Item";
            SqlCommand sqlCommand=new SqlCommand(command, sqlConn);
            sqlConn.Open();
            //sqlCommand.ExecuteNonQuery();
            SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(sqlCommand);
            DataTable dataTable=new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            sqlConn.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string conn = @"Server=PC-301-29\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";

            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select * from Item";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            //sqlCommand.ExecuteNonQuery();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            sqlConn.Close();
        }
    }
}
