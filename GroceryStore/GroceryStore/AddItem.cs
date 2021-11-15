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
    public partial class AddItem : Form
    {

        int ID=01;
        String barCode;
        String productCode;
        String productName;
        double unitPrice;


        public AddItem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
            barCode = textBox1.Text;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           productCode= textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            productName = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            unitPrice = double.Parse(textBox4.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            String connec = "Data Source=THIVANKA;Initial Catalog=Grocery;Integrated Security=True";
            SqlConnection con = new SqlConnection(connec);

            con.Open();

            String SQLquery = "INSERT INTO store VALUES(" + ID + ",'" + barCode+ "','" + productCode + "','" + productName + "'," + unitPrice + ")";

            SqlCommand com = new SqlCommand(SQLquery, con);

            com.ExecuteNonQuery();



            MessageBox.Show("item added success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);






        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
             
        }
    }
}
