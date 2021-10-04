using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceHandling
{
    public partial class logInForm : Form
    {
        public logInForm()
        {
            InitializeComponent();
            errorLabel.Hide();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            //connecting to the Database
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=interview-testing-server.database.windows.net;Initial Catalog=Interview;User ID=TestLogin;Password=5D9ej2G64s3sd^";
            cnn = new SqlConnection(connetionString);

            
            try
            {
                //open the connection
                cnn.Open();
                

                SqlCommand command;
                SqlDataReader dataReader;

                //variables for collecting the user data
                String sql, userName, password, displayName = "";

                //variable for the user active status
                Byte active= 0;

                //reading the username and password input by user
                userName = userNameTextBox.Text;
                password = passwordTextBox.Text;

                //SQL Statement for selecting data
                sql = "SELECT * FROM Users WHERE UserName ='" + userName + "' AND Password = '" + password + "'";

                command = new SqlCommand(sql, cnn);
                //reading the data
                dataReader = command.ExecuteReader();
                if(dataReader.HasRows)
                {
                    //activities to be executed if the data reader returned data
                    while (dataReader.Read())
                    {
                        displayName = dataReader["DisplayName"].ToString();
                        active = Convert.ToByte(dataReader["Active"]);
                    }
                    if (active == 0)
                    {
                        //error to be displayed if user is not active
                        errorLabel.Text = "User is Inactive. Please contact the system administrator.";
                        errorLabel.Show();
                    }
                    else
                    {
                        //if user is active a new form will open with the loss data
                        this.Hide();
                        lossTypeForm lossForm = new lossTypeForm();
                        lossForm.Show();
                    }

                }
                else
                {
                    //if the data reader returned null; user is not found and so error message will be displayed
                    errorLabel.Text = "User name or Password Incorrect. Please try again.";
                    errorLabel.Show();
                }


                dataReader.Close();
                command.Dispose();

                cnn.Close();
            }
            catch (Exception ex)
            {
                //error message displayed if the database connection was not made
                MessageBox.Show("System is unavailable at this time. Please try again later. ");
            }
        }
    }
}
