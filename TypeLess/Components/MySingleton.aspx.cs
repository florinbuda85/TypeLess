using CodeHelpers;
using System;
using TypeLess;

namespace TypeLess
{
    public partial class MySingleton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button1_Click1(object sender, EventArgs e)
        {
            #region pattern
            string pattern = @"
    public class {0}
    {

        private {0}() { }

        private static {0} _instance = null;

        public static {0} getInstance()
        {
            if (_instance == null)
            {
                _instance = new {0}();
            }
            return _instance;
        }

        /****/

    }";
            #endregion
     
            Label2.Text = pattern.Replace("{0}", Utils.UppercaseFirst(TextBox1.Text));
        }
    }


}