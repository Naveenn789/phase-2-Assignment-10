using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAssignment10
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            LblMsg.Visible = false;
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            LblMsg.Visible = true;
            LblMsg.Text = "Product Registration Success!!!";
            LblMsg.Text += "<br/>Product Name: " + TxtPName.Text;
            LblMsg.Text += "<br/>Product Catogory: " + listProductCategory.Text;
            LblMsg.Text += "<br/>Product Description :" + TxtDesc.Text;
            LblMsg.Text += "<br/>Product Release Date: " + Calreleasedate.SelectedDate.ToShortDateString();
        }
    }
}