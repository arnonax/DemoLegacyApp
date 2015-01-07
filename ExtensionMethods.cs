using System.Linq;
using System.Windows.Forms;

namespace LegacyApplication
{
	static class ExtensionMethods
	{
		public static DataGridViewRow Last(this DataGridViewRowCollection rows)
		{
			return rows.Cast<DataGridViewRow>().Last();
		}

		public static DataGridViewCell First(this DataGridViewCellCollection cells)
		{
			return cells.Cast<DataGridViewCell>().First();
		}
	}
}
