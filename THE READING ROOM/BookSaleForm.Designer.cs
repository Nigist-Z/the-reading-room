namespace THE_READING_ROOM;

partial class BookSaleForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblBookTitle = new Label(); lblAvailable = new Label(); lblUnitPrice = new Label();
        lblCustomer = new Label(); txtCustomer = new TextBox(); lblQuantity = new Label();
        numQuantity = new NumericUpDown(); btnComplete = new Button(); btnCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit(); SuspendLayout();
        lblBookTitle.AutoSize = true; lblBookTitle.Font = new Font("Georgia", 14F, FontStyle.Bold); lblBookTitle.Location = new Point(20, 20); lblBookTitle.Name = "lblBookTitle"; lblBookTitle.Size = new Size(140, 23); lblBookTitle.Text = "Book title";
        lblAvailable.AutoSize = true; lblAvailable.Location = new Point(22, 58); lblAvailable.Name = "lblAvailable"; lblAvailable.Size = new Size(85, 15); lblAvailable.Text = "Available: 0";
        lblUnitPrice.AutoSize = true; lblUnitPrice.Location = new Point(22, 82); lblUnitPrice.Name = "lblUnitPrice"; lblUnitPrice.Size = new Size(100, 15); lblUnitPrice.Text = "Unit price: 0 ETB";
        lblCustomer.AutoSize = true; lblCustomer.Location = new Point(22, 122); lblCustomer.Name = "lblCustomer"; lblCustomer.Size = new Size(55, 15); lblCustomer.Text = "Customer";
        txtCustomer.Location = new Point(22, 143); txtCustomer.Name = "txtCustomer"; txtCustomer.Size = new Size(336, 23);
        lblQuantity.AutoSize = true; lblQuantity.Location = new Point(22, 180); lblQuantity.Name = "lblQuantity"; lblQuantity.Size = new Size(53, 15); lblQuantity.Text = "Quantity";
        numQuantity.Location = new Point(22, 201); numQuantity.Minimum = 1; numQuantity.Maximum = 1; numQuantity.Name = "numQuantity"; numQuantity.Size = new Size(120, 23); numQuantity.Value = 1;
        btnComplete.Location = new Point(178, 252); btnComplete.Name = "btnComplete"; btnComplete.Size = new Size(90, 32); btnComplete.Text = "Complete sale";
        btnCancel.Location = new Point(276, 252); btnCancel.Name = "btnCancel"; btnCancel.Size = new Size(82, 32); btnCancel.Text = "Cancel";
        AcceptButton = btnComplete; CancelButton = btnCancel; AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(380, 310); Controls.AddRange(new Control[] { lblBookTitle, lblAvailable, lblUnitPrice, lblCustomer, txtCustomer, lblQuantity, numQuantity, btnComplete, btnCancel });
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; Name = "BookSaleForm"; StartPosition = FormStartPosition.CenterParent; Text = "Sell book";
        ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit(); ResumeLayout(false); PerformLayout();
    }

    private Label lblBookTitle, lblAvailable, lblUnitPrice, lblCustomer, lblQuantity;
    private TextBox txtCustomer;
    private NumericUpDown numQuantity;
    private Button btnComplete, btnCancel;
}
