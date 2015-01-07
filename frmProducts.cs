using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegacyApplication
{
	public partial class frmProducts : Form
	{
		public frmProducts()
		{
			InitializeComponent();
		}

		private void frmProducts_Load(object sender, EventArgs e)
		{
			productsTableAdapter.Fill(storeDataSet.Products);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				var frmProduct = new frmProduct();
				var dialogResult = frmProduct.ShowDialog();
				if (dialogResult != DialogResult.OK)
					return;

				productsTableAdapter.Insert(frmProduct.Barcode, frmProduct.Description, frmProduct.Price);
				productsTableAdapter.Fill(storeDataSet.Products);

				dgvProducts.CurrentCell = dgvProducts.Rows.Last().Cells.First();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}
	}
}
