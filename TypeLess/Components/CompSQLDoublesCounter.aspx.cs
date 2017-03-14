using System;

namespace TypeLess.Components
{
    public partial class CompSQLDoublesCounter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            #region pattern
            string pattern = @" select count(source.{2}), source.{2}  from 
	                            (select distinct {2} from {1}) as source
                            group by source.{2} 
                            order by 1 desc; ";
            #endregion

            pattern = pattern.Replace("{1}", tbName.Text);
            pattern = pattern.Replace("{2}", tbField.Text);

            lblOutput.Text = pattern;
        }
    }
}