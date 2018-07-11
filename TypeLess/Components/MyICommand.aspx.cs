using CodeHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TypeLess.Components
{
    public partial class MyICommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            #region pattern
            string pattern = @"#region ICommand {1}
        private ICommand _{2}; 
        public ICommand {1}
        {
            get
            {
                if (_{2} == null)
                {
                    _{2} = new DelegateCommand({1}Execute); // RelayCommand
                }
                return _{2};
            }
        }
        private void {1}Execute()
        {
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
            try {
                /*
                    *****
                */
            } catch (Exception ex) {
                MessageBox.Show(""Exception found on {1}Execute :"" + ex.Message);
            }
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Arrow;
        }
#endregion";
            #endregion
            
            String s =  tbName.Text;
            s = s.Replace(" ", "");
            s = s.Replace(":", "");

            pattern = pattern.Replace("{1}", Utils.UppercaseFirst(s));
            pattern = pattern.Replace("{2}", Utils.LowercaseFirst(s));

            lblOutput.Text = pattern;
        }
    }
}
