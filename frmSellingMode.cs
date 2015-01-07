using System;
using System.Linq;
using System.Windows.Forms;

namespace LegacyApplication
{
	public partial class frmSellingMode : Form
	{
		private readonly StoreDataSet _dataset = new StoreDataSet();
		private decimal _total;

		public frmSellingMode()
		{
			InitializeComponent();
		}

		private void txtBarcode_TextChanged(object sender, EventArgs e)
		{
			btnAdd.Enabled = !string.IsNullOrEmpty(txtBarcode.Text);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var product = _dataset.Products.FirstOrDefault(p => p.Barcode == txtBarcode.Text);
			if (product == null)
			{
				MessageBox.Show("No product found for the specified barcode", "Selling", MessageBoxButtons.OK,
					MessageBoxIcon.Asterisk);
				return;
			}

			dgvInvoice.Rows.Add(product.Barcode, product.Description, product.Price);
			txtBarcode.SelectAll();

			_total += product.Price;
			txtTotal.Text = _total.ToString("C");
		}

		private void frmSellingMode_Load(object sender, EventArgs e)
		{
			productsTableAdapter.Fill(_dataset.Products);
			txtTotal.Text = 0m.ToString("C");
		}

		private void btnClearAll_Click(object sender, EventArgs e)
		{
			dgvInvoice.Rows.Clear();
			_total = 0;
			txtTotal.Text = 0m.ToString("C");
		}
	}
}
