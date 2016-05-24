using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PwnNetShell
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.OutputDataReceived += P_OutputDataReceived;
            p.ErrorDataReceived += P_ErrorDataReceived;
        }

        private void P_ErrorDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void P_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void btnUpload_OnClick(object sender, EventArgs e)
        {
            if (fuVuln.HasFile)
            {
                fuVuln.SaveAs(Request.MapPath("~/") + System.IO.Path.GetFileName(fuVuln.PostedFile.FileName));
                lblMessage.Text = "File has been saved to: " + Request.MapPath("~/") + System.IO.Path.GetFileName(fuVuln.PostedFile.FileName);
            }


        }
    }
}