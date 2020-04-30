using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OWASP.WebGoat.NET
{
    public partial class CommandInjection : System.Web.UI.Page
    {
        protected void btnFind_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            new ProcessStartInfo(name);

        }
    }
}