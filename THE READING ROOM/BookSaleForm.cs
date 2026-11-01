namespace THE_READING_ROOM;

public partial class BookSaleForm : Form
{
    public string Customer => txtCustomer.Text.Trim();
    public int Quantity => (int)numQuantity.Value;

    public BookSaleForm(Book book)
    {
        InitializeComponent();
        lblBookTitle.Text = book.Title;
        lblAvailable.Text = $"Available: {book.Quantity}";
        lblUnitPrice.Text = $"Unit price: {book.Price:N2} ETB";
        numQuantity.Maximum = book.Quantity;
        btnComplete.Click += (_, _) =>
        {
            if (string.IsNullOrWhiteSpace(txtCustomer.Text))
            {
                MessageBox.Show(this, "Enter the customer name.", "Required information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        };
        btnCancel.Click += (_, _) => { DialogResult = DialogResult.Cancel; Close(); };
    }
}
