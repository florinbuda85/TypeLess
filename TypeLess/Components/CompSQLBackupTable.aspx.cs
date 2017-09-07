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

            var remoteTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern European Summer Time");
            var remoteTime = TimeZoneInfo.ConvertTime(DateTime.Now, remoteTimeZone);

            pattern = pattern.Replace("{1}", Utils.UppercaseFirst(tbName.Text));
            pattern = pattern.Replace("{2}", remoteTime.ToString("yyyyMMddHHmmss"));

            lblOutput.Text = pattern;
        }
    }
}