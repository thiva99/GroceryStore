using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USB_Barcode_Scanner;

using System.Data.Sql;
using System.Data.SqlClient;

namespace GroceryStore
{
    public partial class Form1 : Form
    {
        int Ino=0;


        public Form1()
        {
            InitializeComponent();
            BarcodeScanner barco = new BarcodeScanner(barcode);
            barco.BarcodeScanned += Barco_BarcodeScanned;
        }

        private void Barco_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            barcode.Text = e.Barcode;
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            String code = barcode.Text;
            String itemc = textBox3.Text;

            SqlConnection con = new SqlConnection("Data Source=THIVANKA;Initial Catalog=Grocery;Integrated Security=True");

            con.Open();

            SqlCommand cmd=new SqlCommand("select * from store where  productCode='" + itemc + "' or barCode= '" + code + "'  ", con);
            SqlDataReader read;
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                textBox3.Text = read["productCode"].ToString();
                textBox8.Text = read["productName"].ToString();
                textUprice.Text = read["unitPrice"].ToString();


            }

            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem add = new AddItem();
            add.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.F11)
            {
                addItemsToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.D)
            {
                removeItemsToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.U)
            {
                searchItemsToolStripMenuItem.PerformClick();
            }
            else if ( e.KeyCode == Keys.F12)
            {
                findToolStripMenuItem.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
               btnAdd.PerformClick();
            }
        }

        private void removeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem del = new DeleteItem();
            del.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void searchItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateItem search = new UpdateItem();
            search.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindItem find = new FindItem();
            find.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddClick(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                if (MessageBox.Show("Is it all?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.No)
                {
                    int qty = Convert.ToInt32(txtqty.Text);
                    double uprice = Convert.ToDouble(textUprice.Text);

                    double amount;

                    
                    if (textBox2.Text=="")
                    {
                        amount = qty * uprice;

                        String amo = Convert.ToString(amount);
                        Ino = Ino + 1;

                        String[] arr = new string[6];


                        arr[0] = Convert.ToString(Ino);
                        arr[1] = textBox3.Text;
                        arr[2] = textBox8.Text;
                        arr[3] = textUprice.Text;
                        arr[4] = txtqty.Text;
                        arr[5] = amo;

                        ListViewItem list = new ListViewItem(arr);
                        listView1.Items.Add(list);



                        txtTotal.Text = ((Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(amo)).ToString());

                        double final = ((Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtdis.Text)) / 100);

                        txtgTotal.Text = ((Convert.ToDouble(txtTotal.Text) - final).ToString());


                        

                        clearTextBox();
                    }

                    else
                    {
                        
                        double temp;

                        temp = ((uprice * Convert.ToDouble(textBox2.Text)) / 100);

                        amount = (uprice - temp) * qty;


                        String amo = Convert.ToString(amount);
                        Ino = Ino + 1;

                        String[] arr = new string[6];


                        arr[0] = Convert.ToString(Ino);
                        arr[1] = textBox3.Text;
                        arr[2] = textBox8.Text;
                        arr[3] = textUprice.Text;
                        arr[4] = txtqty.Text;
                        arr[5] = amo;

                        ListViewItem list = new ListViewItem(arr);
                        listView1.Items.Add(list);



                        txtTotal.Text = ((Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(amo)).ToString());

                        double final = ((Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtdis.Text)) / 100);

                        txtgTotal.Text = ((Convert.ToDouble(txtTotal.Text) - final).ToString());


                        

                        clearTextBox();
                    }
                }
            }
            else
            {
                int qty = Convert.ToInt32(txtqty.Text);
                double uprice = Convert.ToDouble(textUprice.Text);

                double amount;


                if (textBox2.Text == "")
                {
                    amount = qty * uprice;

                    String amo = Convert.ToString(amount);
                    Ino = Ino + 1;

                    String[] arr = new string[6];


                    arr[0] = Convert.ToString(Ino);
                    arr[1] = textBox3.Text;
                    arr[2] = textBox8.Text;
                    arr[3] = textUprice.Text;
                    arr[4] = txtqty.Text;
                    arr[5] = amo;

                    ListViewItem list = new ListViewItem(arr);
                    listView1.Items.Add(list);



                    txtTotal.Text = ((Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(amo)).ToString());

                    double final = ((Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtdis.Text)) / 100);

                    txtgTotal.Text = ((Convert.ToDouble(txtTotal.Text) - final).ToString());


                    

                    clearTextBox();
                }

                else
                {

                    double temp;

                    temp = ((uprice * Convert.ToDouble(textBox2.Text)) / 100);

                    amount = (uprice - temp) * qty;


                    String amo = Convert.ToString(amount);
                    Ino = Ino + 1;

                    String[] arr = new string[6];


                    arr[0] = Convert.ToString(Ino);
                    arr[1] = textBox3.Text;
                    arr[2] = textBox8.Text;
                    arr[3] = textUprice.Text;
                    arr[4] = txtqty.Text;
                    arr[5] = amo;

                    ListViewItem list = new ListViewItem(arr);
                    listView1.Items.Add(list);



                    txtTotal.Text = ((Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(amo)).ToString());

                    double final = ((Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtdis.Text)) / 100);

                    txtgTotal.Text = ((Convert.ToDouble(txtTotal.Text) - final).ToString());


                    

                    clearTextBox();
                }
            }
        }









        private void textUprice_TextChanged(object sender, EventArgs e)
        {

        }

        public void clearTextBox()
        {
            barcode.Clear();
            textBox3.Clear();
            textBox8.Clear();
            textBox2.Clear();
            txtqty.Clear();
            textUprice.Clear();
        }

        private void paidAmount_TextChanged(object sender, EventArgs e)
        {
            bal.Text = (((Convert.ToDouble(paidAmount.Text)) - (Convert.ToDouble(txtgTotal.Text))).ToString());
        }

        private void bal_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
