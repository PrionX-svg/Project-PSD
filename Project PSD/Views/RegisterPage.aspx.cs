using Project_PSD.Controller;
using Project_PSD.Handlers;
using Project_PSD.Models;
using Project_PSD.Repository;
using System;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;

namespace Project_PSD.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        RAisoEntities1 db = new RAisoEntities1();
        UserController userControl = new UserController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var user = UserRepository.GetUsers().Select(x => x.UserName).ToList();
                registerForm.DataBind();
            }
        }

        protected void loginLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LogInPage.aspx");
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
                var userContext = new UserController.UserContext();
                bool isNameUnique;

                var userModel = new UserController.UserModel
                {                   
                    Name = nameBox.Text,
                    DOB = Calendar1.SelectedDate,
                    Gender = RadioButtonList1.Text,
                    Address = addressBox.Text,
                    Password = passBox.Text,
                    Phone = phoneBox.Text,
                    Role = RoleList.Text
                };

                isNameUnique = !userContext.Users.Any(u => u.Name == userModel.Name);

                if (isNameUnique)
                {
                    UserRepository.InsertUsers(  
                        StationeryHandler.GenerateID(),
                        userModel.Name,
                        userModel.Gender,
                        userModel.DOB,
                        userModel.Phone,
                        userModel.Address,
                        userModel.Password,
                        userModel.Role
                    );

                    // Inform the user of successful registration
                    Response.Write("<script>alert('User successfully added.');</script>");

                    // Redirect to login page after successful registration
                    Response.Redirect("~/Views/LogInPage.aspx");
                }
                else
                {
                    // Inform the user that the name must be unique
                    Response.Write("<script>alert('Name must be unique among the user's name.');</script>");
                }
 
        }

        private string GetValidatedInput(string fieldName, UserController.UserContext context, out bool isUnique)
        {
            return UserController.GetValidatedInput(fieldName, context, out isUnique);
        }

        private string GetValidatedInput(string fieldName)
        {
            return UserController.GetValidatedInput(fieldName);
        }

        private DateTime GetValidatedDate(string fieldName)
        {
            return UserController.GetValidatedDate(fieldName);
        }

        private string GetValidatedPassword(string fieldName)
        {
            return UserController.GetValidatedPassword(fieldName);
        }
    }
}
