namespace THE_READING_ROOM;

partial class BookEditorForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblIsbn = new Label(); txtIsbn = new TextBox();
        lblTitle = new Label(); txtTitle = new TextBox();
        lblAuthor = new Label(); txtAuthor = new TextBox();
        lblCategory = new Label(); cmbCategory = new ComboBox();
        lblPrice = new Label(); numPrice = new NumericUpDown();
        lblQuantity = new Label(); numQuantity = new NumericUpDown();
        lblDescription = new Label(); txtDescription = new TextBox();
        btnSave = new Button(); btnCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
        SuspendLayout();
        lblIsbn.AutoSize = true; lblIsbn.Location = new Point(20, 20); lblIsbn.Name = "lblIsbn"; lblIsbn.Text = "ISBN";
        txtIsbn.Location = new Point(132, 16); txtIsbn.Name = "txtIsbn"; txtIsbn.Size = new Size(285, 23);
        lblTitle.AutoSize = true; lblTitle.Location = new Point(20, 64); lblTitle.Name = "lblTitle"; lblTitle.Text = "Title";
        txtTitle.Location = new Point(132, 60); txtTitle.Name = "txtTitle"; txtTitle.Size = new Size(285, 23);
        lblAuthor.AutoSize = true; lblAuthor.Location = new Point(20, 108); lblAuthor.Name = "lblAuthor"; lblAuthor.Text = "Author";
        txtAuthor.Location = new Point(132, 104); txtAuthor.Name = "txtAuthor"; txtAuthor.Size = new Size(285, 23);
        lblCategory.AutoSize = true; lblCategory.Location = new Point(20, 152); lblCategory.Name = "lblCategory"; lblCategory.Text = "Category";
        cmbCategory.Location = new Point(132, 148); cmbCategory.Name = "cmbCategory"; cmbCategory.Size = new Size(285, 23);
        lblPrice.AutoSize = true; lblPrice.Location = new Point(20, 196); lblPrice.Name = "lblPrice"; lblPrice.Text = "Price (ETB)";
        numPrice.Location = new Point(132, 192); numPrice.Name = "numPrice"; numPrice.Size = new Size(285, 23);
        lblQuantity.AutoSize = true; lblQuantity.Location = new Point(20, 240); lblQuantity.Name = "lblQuantity"; lblQuantity.Text = "Quantity";
        numQuantity.Location = new Point(132, 236); numQuantity.Name = "numQuantity"; numQuantity.Size = new Size(285, 23);
        lblDescription.AutoSize = true; lblDescription.Location = new Point(20, 284); lblDescription.Name = "lblDescription"; lblDescription.Text = "Description";
        txtDescription.Location = new Point(132, 280); txtDescription.Name = "txtDescription"; txtDescription.Size = new Size(285, 70);
        cmbCategory.Name = "cmbCategory"; cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        numPrice.Name = "numPrice"; numPrice.DecimalPlaces = 2; numPrice.Maximum = 100000000;
        numQuantity.Name = "numQuantity"; numQuantity.Maximum = 1000000;
        txtDescription.Multiline = true;
        btnSave.Location = new Point(237, 335); btnSave.Name = "btnSave"; btnSave.Size = new Size(85, 32); btnSave.Text = "Save"; btnSave.DialogResult = DialogResult.None;
        btnCancel.Location = new Point(332, 335); btnCancel.Name = "btnCancel"; btnCancel.Size = new Size(85, 32); btnCancel.Text = "Cancel"; btnCancel.DialogResult = DialogResult.None;
        AcceptButton = btnSave; CancelButton = btnCancel;
        AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 390); Controls.AddRange(new Control[] { lblIsbn, txtIsbn, lblTitle, txtTitle, lblAuthor, txtAuthor, lblCategory, cmbCategory, lblPrice, numPrice, lblQuantity, numQuantity, lblDescription, txtDescription, btnSave, btnCancel });
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; Name = "BookEditorForm"; StartPosition = FormStartPosition.CenterParent; Text = "Book details";
        ((System.ComponentModel.ISupportInitialize)numPrice).EndInit(); ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit(); ResumeLayout(false); PerformLayout();
    }

    private Label lblIsbn, lblTitle, lblAuthor, lblCategory, lblPrice, lblQuantity, lblDescription;
    private TextBox txtIsbn, txtTitle, txtAuthor, txtDescription;
    private ComboBox cmbCategory;
    private NumericUpDown numPrice, numQuantity;
    private Button btnSave, btnCancel;
}
