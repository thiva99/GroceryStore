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
        String itemc,na,pr;
        String v;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            itemc = row.Cells[0].Value.ToString();
            na = row.Cells[1].Value.ToString();
            pr = row.Cells[2].Value.ToString();

            textBox9.Text = itemc.ToString();
            textBox5.Text = na.ToString();
            textBox1.Text = pr.ToString();

        }

        private void FindItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 
                button1.PerformClick();
            }
        }
        public String ival
        {
            get{ return v; }
            set{ v = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ival = itemc;
            
            
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
