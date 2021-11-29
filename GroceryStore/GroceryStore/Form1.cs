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
        String[] arr = new string[6];
        String ItemNo;
        String ProductCode;
       
        int price;

        

        


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

            SqlCommand cmd=new SqlCommand("select * from store where    barCode= '" + code + "'  ", con);
            SqlDataReader read;
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                barcode.Text=read["barCode"].ToString();
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
            String code = barcode.Text;

             

            String itemc = textBox3.Text;

            SqlConnection con = new SqlConnection("Data Source=THIVANKA;Initial Catalog=Grocery;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from store where  productCode='" + itemc + "'    ", con);
            SqlDataReader read;
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                barcode.Text = read["barCode"].ToString();
                textBox3.Text = read["productCode"].ToString();
                textBox8.Text = read["productName"].ToString();
                textUprice.Text = read["unitPrice"].ToString();


            }

            con.Close();

            
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
            else if( e.KeyCode == Keys.End)
            {
                button5.PerformClick();
            }

        }

        private void removeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem del = new DeleteItem();
            del.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
             printPreviewDialog1.ShowDialog();



            //int name = listView1.Items.Count; ;
            //MessageBox.Show(Convert.ToString(name));
        }

        private void searchItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateItem search = new UpdateItem();
            search.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if(textBox5.Text==""){
                MessageBox.Show("Enter a Item no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(textBox5.Text) == 0)
            {
                MessageBox.Show("Enter a Item no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox9.Text == "")
            {
                MessageBox.Show("Enter a Item product code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBox9.Text != ProductCode)
            {
                MessageBox.Show("Enter a Correct Item product code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else

            {
             
                
                int itemNo = Convert.ToInt32(ItemNo);
                itemNo--;

                listView1.Items.RemoveAt(itemNo);

                txtTotal.Text = Convert.ToString(Convert.ToInt32(txtTotal.Text) - price);
                txtgTotal.Text = Convert.ToString(Convert.ToInt32(txtgTotal.Text) - price);


                textBox5.Clear();
                textBox9.Clear();
 
    


            }


        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindItem find = new FindItem();
            if (find.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = find.ival;
            }
             

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      public void buttonAddClick(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                if (MessageBox.Show("Is it all?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    if (textBox3.Text.Length == 0)
                    {
                        MessageBox.Show("Enter a Item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {

                        if (textBox3.Text.Length == 0)
                        {
                            MessageBox.Show("Enter a Item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                }
            }
            else
            {

                if (txtqty.Text.Length == 0)
                {
                    MessageBox.Show("Enter a Quntity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

                        if (Convert.ToDouble(txtdis.Text) != 0)
                        {
                            double final = ((Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtdis.Text)) / 100);

                            txtgTotal.Text = ((Convert.ToDouble(txtTotal.Text) - final).ToString());
                        }
                        else
                        {
                            txtgTotal.Text = (Convert.ToDouble(txtTotal.Text)).ToString();
                        }




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
            if (paidAmount.Text.Length !=0)
            {
                bal.Text = (((Convert.ToDouble(paidAmount.Text)) - (Convert.ToDouble(txtgTotal.Text))).ToString());
            }
            else
            {
                bal.Text = "0";
            }
        }

        private void bal_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];
            //fill the text boxes
             
            ItemNo = item.SubItems[0].Text;
            ProductCode = item.SubItems[1].Text;
            price = Convert.ToInt32(item.SubItems[5].Text);
           


            textBox5.Text = ItemNo;


        }

        private void txtdis_TextChanged(object sender, EventArgs e)
        {
            if (txtdis.Text.Length!=0)
            {
                double disAmount= Convert.ToDouble(txtdis.Text);
                double dis = (Convert.ToDouble(txtTotal.Text)*disAmount)/100;
                double fPrice = Convert.ToDouble(txtTotal.Text) - dis;
                txtgTotal.Text = Convert.ToString(fPrice);

            }

            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String date = DateTime.Now.ToString();
            
            e.Graphics.DrawString("Welcome",new Font("Arial",18,FontStyle.Bold),Brushes.Black , new Point(360,60));

            e.Graphics.DrawString(date, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100,150));
            
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 180));

            e.Graphics.DrawString("Item No"+"\t" + "\t" + "\t" + "Name"  + "\t" + "\t" + "\t" + "Qty" + "\t" + "Price" + "\t" + "Amount", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(120, 200));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 220));

            int a = 240;
            for(int x = 0; x < listView1.Items.Count; x++)
            {
               
                e.Graphics.DrawString(listView1.Items[x].SubItems[0].Text , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(140, a));
                e.Graphics.DrawString(listView1.Items[x].SubItems[2].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(240, a));
                e.Graphics.DrawString(listView1.Items[x].SubItems[4].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(528, a));
                e.Graphics.DrawString(listView1.Items[x].SubItems[3].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(588, a));
                e.Graphics.DrawString(listView1.Items[x].SubItems[5].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(664, a));


                a = a+25;
                
            }
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, a));
            int b = a + 20;
            e.Graphics.DrawString("Groos Total" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + txtTotal.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(120, b));
            int c = b + 20;
            e.Graphics.DrawString("Discount (%)" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + txtdis.Text+"%", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(120, c));
            int d = c + 20;
            e.Graphics.DrawString("Net Total" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + txtgTotal.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(120, d));


            int ez = d + 40;
            e.Graphics.DrawString("Cash" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + paidAmount.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(120, ez));
            int f = ez + 20;
            e.Graphics.DrawString("Balance" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + bal.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(120, f));
            int v =  f + 20;

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, v));

            int g = v + 25;
            e.Graphics.DrawString("Thank You", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(360, g));

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
