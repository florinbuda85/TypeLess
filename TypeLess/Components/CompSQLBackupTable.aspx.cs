using CodeHelpers;
using System;

namespace TypeLess.Components
{
    public partial class CmpSQLBackupTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            #region pattern
            string pattern = @" select * into zbackup_{1}_{2} from {1}; ";
            #endregion
            
            pattern = pattern.Replace("{1}", Utils.UppercaseFirst(tbName.Text));
            pattern = pattern.Replace("{2}", DateTime.Now.ToString("yyyyMMddHHmmss"));

            lblOutput.Text = pattern;
        }
    }
}