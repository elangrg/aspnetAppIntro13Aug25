using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetAppIntro13Aug25
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                cmbNames.Items.Add("Ganesh");
                cmbNames.Items.Add("Mahesh");
                cmbNames.Items.Add("Dinesh");
            }


        }
        protected void btnClick(object sender, EventArgs e)
        {
            lblMsg.Text = $"{txtWebSvrCtr.Text} {txtHtmlSvrControl.Value}";





        }

    }
}