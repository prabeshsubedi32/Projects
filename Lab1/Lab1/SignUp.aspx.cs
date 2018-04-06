using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessTier;

namespace Lab1
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserDataAccess data = new UserDataAccess();
                
                ddlIds.DataSource = data.getUserIds();
                ddlIds.DataValueField = "Id";
                ddlIds.DataTextField = "Id";
                ddlIds.DataBind();
                ddlIds.Items.Insert(0, "Select");
                //ddlIds.Items.Add(new ListItem("Select", "0", true));
                if (Request.QueryString["usertype"].ToString() != "1")
                {
                    btnUpdate.Visible = false;
                    btnDelete.Visible = false;
                }

            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {

            UserDataAccess data = new UserDataAccess();
            User user = new User();

            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.UserType = Convert.ToInt32(rblUsrrType.SelectedValue);
            data.AddUser(user);
            Response.Redirect("CheckLogin.aspx");

        }

        protected void ddlIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlIds.SelectedValue != "Select")
            {
                int selectedId = Convert.ToInt32(ddlIds.SelectedValue);
                UserDataAccess data = new UserDataAccess();
                var user = data.getUsers().ToList().Select(x => new User()
                {
                    Id = x.Id,
                    LastName = x.LastName,
                    FirstName = x.FirstName,
                    UserName = x.UserName,
                    Password = x.Password,
                    UserType = x.UserType

                }).ToList().Where(x => x.Id == selectedId).FirstOrDefault();
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtUserName.Text = user.UserName;
                txtPassword.Text = user.Password;
                rblUsrrType.SelectedValue = user.UserType.ToString();

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UserDataAccess data1 = new UserDataAccess();

            User user = new User();

            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.UserType = Convert.ToInt32(rblUsrrType.SelectedValue);
            user.Id= Convert.ToInt32(ddlIds.SelectedValue);
            data1.UpdateUser(user);
           // data.U(user);


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            UserDataAccess data = new UserDataAccess();
            data.DeleteUser(Convert.ToInt32(ddlIds.SelectedValue));
        }
    }
}