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
    public partial class DeleteItem : Form
    {

        String name;
        String icode;
        String barcod;

        public DeleteItem()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        public void displaydata(String a, String b, String c)
        {
            SqlConnection con = new SqlConnection("Data Source=THIVANKA;Initial Catalog=Grocery;Integrated Security=True");
            
            con.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select * from store where productName= '" + a + "' or productCode='" + b + "' or barCode='" + c + "' ", con);
            DataTable dt = new DataTable();

            adpt.Fill(dt);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            barcod = barcode.Text;
            icode = textBox3.Text;
            name = textBox8.Text;

            displaydata(name, icode, barcod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
        }

        public void clean()
        {
            barcode.Clear();
            textBox3.Clear();
            textBox8.Clear();
        }
    }
}
