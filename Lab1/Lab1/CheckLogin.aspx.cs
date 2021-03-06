﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccessTier;

namespace Lab1
{
    public partial class CheckLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserDataAccess data = new UserDataAccess();
            User user = new User();
            if (data.getUsers().ToList().Where(x => (x.UserName == txtUsername.Text 
            && x.Password == txtPassword.Text)).Any())
            {
                Session["UserName"] = txtUsername.Text;
                /*Session["UserName"] = data.getUsers().ToList()
                   .Where(x => x.UserName == txtUsername.Text).ToList()
                   .Select(xx => xx.UserName)
                   .FirstOrDefault().ToString();*/
                if (Request.QueryString["returnurl"] != null)
                {
                    Response.Redirect(Request.QueryString["returnurl"].ToString());
                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
            }
            else
            {
                errorMessage.Text = "Wrong UserName or Password";
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            UserDataAccess data = new UserDataAccess();
            User user = new User();
            if (data.getUsers().ToList().Where(x => (x.UserName == txtUsername.Text && x.Password == txtPassword.Text)).Any())
            {
                string usertype = data.getUsers().ToList()
                    .Where(x => x.UserName == txtUsername.Text).ToList()
                    .Select(xx => xx.UserType)
                    .FirstOrDefault().ToString();

                Session["UserName"] = txtUsername.Text;
                /*Session["UserName"]= data.getUsers().ToList()
                    .Where(x => x.UserName == txtUsername.Text).ToList()
                    .Select(xx => xx.UserName)
                    .FirstOrDefault().ToString();*/


                Response.Redirect("SignUp.aspx?usertype=" + usertype);
            }
            else
            {
                Response.Redirect("SignUp.aspx?usertype=-1");
            }                  
        }
    }
}