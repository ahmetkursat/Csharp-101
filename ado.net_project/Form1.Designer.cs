namespace ado.net_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GroupBox gbxUpdate;
            tbxUnitPriceUpdate = new TextBox();
            tbxStockAmountUpdate = new TextBox();
            lblNameUpdate = new Label();
            lblUnitPriceUpdate = new Label();
            tbxNameUpdate = new TextBox();
            LblStockAmountUpdate = new Label();
            dgwProducts = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxName = new TextBox();
            tbxUnitPrice = new TextBox();
            tbxStockAmount = new TextBox();
            AddProduct = new GroupBox();
            button1 = new Button();
            Update = new Button();
            gbxUpdate = new GroupBox();
            gbxUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            AddProduct.SuspendLayout();
            SuspendLayout();
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(tbxUnitPriceUpdate);
            gbxUpdate.Controls.Add(tbxStockAmountUpdate);
            gbxUpdate.Controls.Add(lblNameUpdate);
            gbxUpdate.Controls.Add(lblUnitPriceUpdate);
            gbxUpdate.Controls.Add(tbxNameUpdate);
            gbxUpdate.Controls.Add(LblStockAmountUpdate);
            gbxUpdate.Location = new Point(438, 291);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(287, 144);
            gbxUpdate.TabIndex = 9;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "UpdateProduct";
            // 
            // tbxUnitPriceUpdate
            // 
            tbxUnitPriceUpdate.Location = new Point(113, 57);
            tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            tbxUnitPriceUpdate.Size = new Size(100, 23);
            tbxUnitPriceUpdate.TabIndex = 5;
            // 
            // tbxStockAmountUpdate
            // 
            tbxStockAmountUpdate.Location = new Point(113, 94);
            tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            tbxStockAmountUpdate.Size = new Size(100, 23);
            tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            lblNameUpdate.AutoSize = true;
            lblNameUpdate.Location = new Point(24, 24);
            lblNameUpdate.Name = "lblNameUpdate";
            lblNameUpdate.Size = new Size(39, 15);
            lblNameUpdate.TabIndex = 1;
            lblNameUpdate.Text = "Name";
            // 
            // lblUnitPriceUpdate
            // 
            lblUnitPriceUpdate.AutoSize = true;
            lblUnitPriceUpdate.Location = new Point(24, 60);
            lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            lblUnitPriceUpdate.Size = new Size(58, 15);
            lblUnitPriceUpdate.TabIndex = 2;
            lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // tbxNameUpdate
            // 
            tbxNameUpdate.Location = new Point(113, 21);
            tbxNameUpdate.Name = "tbxNameUpdate";
            tbxNameUpdate.Size = new Size(100, 23);
            tbxNameUpdate.TabIndex = 4;
            // 
            // LblStockAmountUpdate
            // 
            LblStockAmountUpdate.AutoSize = true;
            LblStockAmountUpdate.Location = new Point(24, 97);
            LblStockAmountUpdate.Name = "LblStockAmountUpdate";
            LblStockAmountUpdate.Size = new Size(83, 15);
            LblStockAmountUpdate.TabIndex = 3;
            LblStockAmountUpdate.Text = "Stock Amount";
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(39, 40);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(704, 245);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick_1;
            dgwProducts.CellContentClick += dgwProducts_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 60);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Unit Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 97);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 3;
            label3.Text = "Stock Amount";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(113, 21);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(100, 23);
            tbxName.TabIndex = 4;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(113, 57);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(100, 23);
            tbxUnitPrice.TabIndex = 5;
            // 
            // tbxStockAmount
            // 
            tbxStockAmount.Location = new Point(113, 94);
            tbxStockAmount.Name = "tbxStockAmount";
            tbxStockAmount.Size = new Size(100, 23);
            tbxStockAmount.TabIndex = 6;
            // 
            // AddProduct
            // 
            AddProduct.Controls.Add(tbxUnitPrice);
            AddProduct.Controls.Add(tbxStockAmount);
            AddProduct.Controls.Add(label1);
            AddProduct.Controls.Add(label2);
            AddProduct.Controls.Add(tbxName);
            AddProduct.Controls.Add(label3);
            AddProduct.Location = new Point(39, 291);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(287, 144);
            AddProduct.TabIndex = 7;
            AddProduct.TabStop = false;
            AddProduct.Text = "AddProduct";
            // 
            // button1
            // 
            button1.Location = new Point(177, 441);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Update
            // 
            Update.Location = new Point(576, 441);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 10;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(Update);
            Controls.Add(gbxUpdate);
            Controls.Add(button1);
            Controls.Add(AddProduct);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            AddProduct.ResumeLayout(false);
            AddProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxName;
        private TextBox tbxUnitPrice;
        private TextBox tbxStockAmount;
        private GroupBox AddProduct;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox tbxUnitPriceUpdate;
        private TextBox tbxStockAmountUpdate;
        private Label lblNameUpdate;
        private Label lblUnitPriceUpdate;
        private TextBox tbxNameUpdate;
        private Label LblStockAmountUpdate;
        private Button Update;
    }
}