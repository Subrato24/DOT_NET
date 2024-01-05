using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconecterCustomer
{
    public partial class CustomerDataGridView : Form
    {
        public CustomerDataGridView()
        {
            InitializeComponent();
        }

        private void CustomerDataGridView_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("Data Source=localhost;Database=subrato;User Id=root;Password=root"))
            {
                MySqlDataAdapter DA = new MySqlDataAdapter("select * from customer", conn);
                DataSet DS = new DataSet();
                DA.Fill(DS, "customer");
                dataGridView1.DataSource = DS.Tables[0];

                MySqlDataAdapter DA1 = new MySqlDataAdapter("select * from employee", conn);
                DA1.Fill(DS, "employee");
                dataGridView2.DataSource = DS.Tables[1];

                MySqlDataAdapter DA2 = new MySqlDataAdapter("select * from product", conn);
                DA2.Fill(DS, "product");
                dataGridView3.DataSource = DS.Tables[2];
                conn.Close();
            }
        }
    }
}
