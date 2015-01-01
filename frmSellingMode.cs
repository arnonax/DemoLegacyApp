using System;
using System.Linq;
using System.Windows.Forms;

namespace LegacyApplication
{
	public partial class frmSellingMode : Form
	{
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
			var dataset = new StoreDataSet();
			var product = dataset.Products.FirstOrDefault(p => p.Barcode == txtBarcode.Text);
			if (product == null)
				MessageBox.Show("No product found for the specified barcode", "Selling", MessageBoxButtons.OK,
					MessageBoxIcon.Asterisk);


		}
	}
}
