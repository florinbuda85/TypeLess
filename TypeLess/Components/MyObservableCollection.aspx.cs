using CodeHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TypeLess.Components
{
    public partial class MyObservableCollection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            #region pattern
            string pattern = @"#region ObservableCollection {1}
        private ObservableCollection<{0}> _{2}; 
        public ObservableCollection<{0}> {1}
        {
            get
            {
                return _{2};
            }
            set
            {
                _{2} = value;
                RaisePropertyChanged(""{1}"");
            }
        }
#endregion";
            #endregion

            pattern = pattern.Replace("{0}", tbType.Text);
            pattern = pattern.Replace("{1}", Utils.UppercaseFirst(tbName.Text));
            pattern = pattern.Replace("{2}", Utils.LowercaseFirst(tbName.Text));

            lblOutput.Text = pattern;
        }
    }

}
