using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        db.Open();

        string checkuser = "SELECT COUNT(*) FROM Users WHERE UserName=@name";
        SqlCommand com = new SqlCommand(checkuser, db);
        com.Parameters.AddWithValue("@name", TextBoxUserName.Text);
        int numusers = Convert.ToInt32(com.ExecuteScalar().ToString());
        if (numusers == 1)
        {
            string checkpass = "SELECT Password FROM Users WHERE UserName=@name";
            com = new SqlCommand(checkpass, db);
            com.Parameters.AddWithValue("@name", TextBoxUserName.Text);
            string result = com.ExecuteScalar().ToString();
            Response.Write(result);
            if (Hashing.ValidatePassword(TextBoxPassword.Text, result))
            {
                Session["UserName"] = TextBoxUserName.Text;
                Response.Write("Password is correct.");
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("Password is not correct.");               
            }
        }
        else
        {
            Response.Write("User not found.");
        }
        

        db.Close();
    }
}