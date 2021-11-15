namespace GroceryStore
{
    partial class FindItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCode,
            this.itemName,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(86, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // item
            // 
            this.item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.item.BackColor = System.Drawing.SystemColors.Window;
            this.item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.Location = new System.Drawing.Point(86, 120);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(367, 29);
            this.item.TabIndex = 3;
            this.item.TextChanged += new System.EventHandler(this.item_TextChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(482, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 36);
            this.button3.TabIndex = 36;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // itemCode
            // 
            this.itemCode.DataPropertyName = "productCode";
            this.itemCode.HeaderText = "ITEM CODE";
            this.itemCode.Name = "itemCode";
            this.itemCode.ReadOnly = true;
            this.itemCode.Width = 150;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "productName";
            this.itemName.FillWeight = 150F;
            this.itemName.HeaderText = "ITEM NAME";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 220;
            // 
            // price
            // 
            this.price.DataPropertyName = "unitPrice";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle3;
            this.price.HeaderText = "PRICE";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // FindItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 761);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.item);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(700, 800);
            this.MinimumSize = new System.Drawing.Size(700, 800);
            this.Name = "FindItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.Load += new System.EventHandler(this.FindItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}