namespace ElectronicPartsPicker
{
    partial class FrmOrderForm
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
            btnAddProduct = new Button();
            btnDeleteProduct = new Button();
            comboBoxProduct = new ComboBox();
            txtOrderTotal = new TextBox();
            txtTax = new TextBox();
            txtSubtotal = new TextBox();
            lblSubtotal = new Label();
            lblTax = new Label();
            lblOrderTotal = new Label();
            lblProduct = new Label();
            SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(652, 274);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(198, 124);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(652, 516);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(198, 113);
            btnDeleteProduct.TabIndex = 1;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(192, 216);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(242, 40);
            comboBoxProduct.TabIndex = 2;
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Enabled = false;
            txtOrderTotal.Location = new Point(214, 631);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(200, 39);
            txtOrderTotal.TabIndex = 3;
            // 
            // txtTax
            // 
            txtTax.Enabled = false;
            txtTax.Location = new Point(214, 562);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(200, 39);
            txtTax.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(214, 495);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(200, 39);
            txtSubtotal.TabIndex = 5;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(43, 495);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(108, 32);
            lblSubtotal.TabIndex = 6;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(43, 562);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(59, 32);
            lblTax.TabIndex = 7;
            lblTax.Text = "Tax: ";
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Location = new Point(43, 639);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(138, 32);
            lblOrderTotal.TabIndex = 8;
            lblOrderTotal.Text = "Order Total:";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(53, 219);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(101, 32);
            lblProduct.TabIndex = 9;
            lblProduct.Text = "Product:";
            // 
            // FrmOrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 854);
            Controls.Add(lblProduct);
            Controls.Add(lblOrderTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(txtSubtotal);
            Controls.Add(txtTax);
            Controls.Add(txtOrderTotal);
            Controls.Add(comboBoxProduct);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnAddProduct);
            Name = "FrmOrderForm";
            Text = "Order Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProduct;
        private Button btnDeleteProduct;
        private ComboBox comboBoxProduct;
        private TextBox txtOrderTotal;
        private TextBox txtTax;
        private TextBox txtSubtotal;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblOrderTotal;
        private Label lblProduct;
    }
}