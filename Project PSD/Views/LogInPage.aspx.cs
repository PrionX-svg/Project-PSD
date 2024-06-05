using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.Views
{
    public partial class LogInPage : System.Web.UI.Page
    {
        RAisoEntities1 db = new RAisoEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String password = passwordBox.Text;
            bool rememberMe = rememberCheckBox.Checked;

            var user = (from x in db.MsUsers 
                        where x.UserName == name && x.UserPassword == password 
                        select x).FirstOrDefault();

            //Check if the user is empty
            if(user == null)
            {
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
                ErrorLabel.Text = "User not exist";
            }
            //When the user is exist, then
            else
            {
                Session["user"] = user;

                if (rememberMe == true)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);

                }
                if(user.UserRole == "Admin")
                {
                    Response.Redirect("~/Views/Admin/HomePage.aspx");
                }
                else
                {
                    Response.Redirect("~/Views/Customer/customerHomePage.aspx");
                }
               

            }
        }

        protected void toRegisterPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }
    }
}