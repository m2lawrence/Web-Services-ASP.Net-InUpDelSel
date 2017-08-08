using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace MikesWebServiceConsume
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            MikesServiceRef.TestService objTest = new MikesServiceRef.TestService();
            int ret = objTest.InsertDetail(txtName.Text, txtCity.Text);
            if (ret > 0)
            {
                lblMessage.Text = "Record Inserted Successfully";
                txtID.Text = "";
                txtName.Text = "";
                txtCity.Text = "";
            }
            else
            {
                lblMessage.Text = "Error while inserting record";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            MikesServiceRef.TestService objTest = new MikesServiceRef.TestService();
            int ret = objTest.UpdateDetail(Convert.ToInt32(txtID.Text), txtName.Text, txtCity.Text);
            if (ret > 0)
            {
                lblMessage.Text = "Record update Successfully";
                txtID.Text = "";
                txtName.Text = "";
                txtCity.Text = "";
            }
            else
            {
                lblMessage.Text = "Error while updating record";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            MikesServiceRef.TestService objTest = new MikesServiceRef.TestService();
            int ret = objTest.DeleteRecord(Convert.ToInt32(txtID.Text));
            if (ret > 0)
            {
                lblMessage.Text = "Record delete Successfully";
                txtID.Text = "";
                txtName.Text = "";
                txtCity.Text = "";
            }
            else
            {
                lblMessage.Text = "Error while deleting record";
            }
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            MikesServiceRef.TestService objTest = new MikesServiceRef.TestService();
            DataSet ret = objTest.GetDetialByID(Convert.ToInt32(txtID.Text));
            if (ret.Tables.Count > 0)
            {
                if (ret.Tables[0].Rows.Count > 0)
                {
                    //add the rows to the tables using the column names below.

                    txtName.Text = ret.Tables[0].Rows[0]["PersonName"].ToString();
                    txtCity.Text = ret.Tables[0].Rows[0]["PersonCity"].ToString();
                }
                else
                {
                    lblMessage.Text = "Record not found";
                }
            }
        }
    }
}