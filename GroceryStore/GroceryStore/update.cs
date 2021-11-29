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

using USB_Barcode_Scanner;


namespace GroceryStore
{
    public partial class UpdateItem : Form
    {
         
                 
        String name  ;
        String icode ;
        String barcod ;

        public UpdateItem()
        {
            InitializeComponent();
            BarcodeScanner barco = new BarcodeScanner(barcode);
            barco.BarcodeScanned += Barco_BarcodeScanned;


        }

        private void Barco_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            barcode.Text = e.Barcode;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {

        }

        public void displaydata(String a,String b,String c)
        {
            SqlConnection con = new SqlConnection("Data Source=THIVANKA;Initial Catalog=Grocery;Integrated Security=True");
            
            con.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select * from store where productName= '"+a+"' or productCode='" + b + "' or barCode= '"+c+"'  ", con);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Action")
            {

                if (MessageBox.Show("Are you sure want to update?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    
                    String id = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["pCode"].Value);
                   
                    String name = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["pName"].Value);
                    int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["uPrice"].Value);



                    if (id == "" || name == "")
                    {

                        MessageBox.Show("Enter valid details.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        displaydata(name, icode, barcod);
                    }
                    else
                    {

                        SqlConnection conn = new SqlConnection("Data Source=THIVANKA;Initial Catalog=Grocery;Integrated Security=True");
                        conn.Open();

                        String query = " update store set unitPrice ='" + price + "' , productName='" + name + "'  where  productCode='" + id + "'";
                        SqlCommand cmdd = new SqlCommand(query, conn);
                        int a = cmdd.ExecuteNonQuery();


                        if (a > 0)
                        {
                            MessageBox.Show("'" + id + "' is updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("'" + id + "' is not updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                    }

                }
                else
                {
                    displaydata(name, icode, barcod);
                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connn = new SqlConnection("Data Source=THIVANKA;Initial Catalog=Grocery;Integrated Security=True");

            connn.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select * from store", connn);
            DataTable dt = new DataTable();

            adpt.Fill(dt);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;


            connn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
