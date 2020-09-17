using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyWebApp
{
    public partial class ContactUs : System.Web.UI.Page
    {
        string username = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // txtUser.Text = "Bharath";
            }
            else
            {
                GetUserName();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Posting the user name and password to teh database
            username = txtUser.Text;
            string password = txtPW.Text;
            ViewState["UN"] = "151234"; //coming from the DB
            Session["UN"]="151234";
        }

        private void GetUserName()
        {
            if (ViewState["UN"] != null)
            {
                lblUserId.Text= ViewState["UN"].ToString();
            }
        }
    }
}
