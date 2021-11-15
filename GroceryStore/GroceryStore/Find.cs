using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;


namespace GroceryStore
{
    public partial class FindItem : Form
    {
        public FindItem()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void item_TextChanged(object sender, EventArgs e)
        {

        }

        private void FindItem_Load(object sender, EventArgs e)
        {

        }

        public void displaydata(String a)
        {
            SqlConnection con = new SqlConnection("Data Source=THIVANKA;Initial Catalog=Grocery;Integrated Security=True");

            con.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select * from store where productName= '" + a + "' or productCode='" + a + "'  ", con);
            DataTable dt = new DataTable();

            adpt.Fill(dt);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;


            con.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            String name=item.Text;
            displaydata(name);


        }
        
    }
}
