using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using BCrypt.Net;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack)
        {
            SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            db.Open();

            string checkuser = "SELECT COUNT(*) FROM Users WHERE UserName='" + TextBoxUserName.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, db);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 1)
            {
                Response.Write("User already exists.");
            }

            db.Close();
        }
    }

    protected void DropDownListCountry_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            var hashedPass = Hashing.HashPassword(TextBoxPassword.Text);

            SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            db.Open();

            string insertQuery = "INSERT INTO Users (Id, UserName, Email, Password, Country) VALUES (@id, @name, @email, @password, @country)";

            // get user ID
            string checkuser = "SELECT COUNT(*) FROM Users";
            SqlCommand com = new SqlCommand(checkuser, db);
            int newid = Convert.ToInt32(com.ExecuteScalar().ToString()) + 1;

            com = new SqlCommand(insertQuery, db);
            com.Parameters.AddWithValue("@id", newid);
            com.Parameters.AddWithValue("@name", TextBoxUserName.Text);
            com.Parameters.AddWithValue("@email", TextBoxEmail.Text);
            com.Parameters.AddWithValue("@password", hashedPass);
            com.Parameters.AddWithValue("@country", DropDownListCountry.SelectedItem.ToString());

            com.ExecuteNonQuery();
            Response.Write("Registration is successful.");
            Session["UserName"] = TextBoxUserName.Text;
            Response.Redirect("Manager.aspx");

            db.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error: " + ex.ToString());
        }
        
        

    }
}