using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            EmployeeHelper eHelper = new EmployeeHelper();
            lblUserId.Text = eHelper.GetEmpName();

            //if (!IsPostBack)
            //{
            //    // txtUser.Text = "Bharath";
            //    List<string> data = new List<string>();
            //    data.Add("Test");
            //    data.Add("Test1");
            //    dd.DataSource = data;
            //    dd.DataTextField = data[0];
            //    //dd.DataValueField = data.Id;

            //}
            //else
            //{
            //    GetUserName();
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Posting the user name and password to teh database
            username = txtUser.Text;
            string password = txtPW.Text;
            ViewState["UN"] = "151234"; //coming from the DB
            Session["UN"] = "151234";
        }

        private void GetUserName()
        {

            if (ViewState["UN"] != null)
            {
                lblUserId.Text = ViewState["UN"].ToString();
            }
        }

        protected void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        protected void dd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeHelper objEmp = new EmployeeHelper();
            string emapName = txtEmpName.Text;
            string empNumber = txtEmpNumer.Text;
            objEmp.UpdateEmpName(empNumber, emapName);
        }
    }
}
