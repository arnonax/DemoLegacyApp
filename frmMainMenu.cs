using System.Windows.Forms;

namespace LegacyApplication
{
	public partial class frmMainMenu : Form
	{
		private readonly frmSellingMode _frmSellingMode;

		public frmMainMenu()
		{
			InitializeComponent();
			_frmSellingMode = new frmSellingMode();
		}

		private void btnProducts_Click(object sender, System.EventArgs e)
		{
			new frmProducts().ShowDialog();
		}

		private void frmMainMenu_Load(object sender, System.EventArgs e)
		{

		}

		private void btnSellingMode_Click(object sender, System.EventArgs e)
		{
			_frmSellingMode.ShowDialog();
		}

		private void btnPromotions_Click(object sender, System.EventArgs e)
		{
			new frmPromotions().ShowDialog();
		}
	}
}
