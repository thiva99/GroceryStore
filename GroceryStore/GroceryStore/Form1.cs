using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
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
    }
}
