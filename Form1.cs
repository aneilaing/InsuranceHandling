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
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=interview-testing-server.database.windows.net;Initial Catalog=Interview;User ID=TestLogin;Password=5D9ej2G64s3sd^";
            cnn = new SqlConnection(connetionString);

            
            try
            {
                cnn.Open();
                

                SqlCommand command;
                SqlDataReader dataReader;
                String sql, userName, password, displayName = "";
                Byte active= 0;

                userName = userNameTextBox.Text;
                password = passwordTextBox.Text;

                sql = "SELECT * FROM Users WHERE UserName ='" + userName + "' AND Password = '" + password + "'";

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                if(dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        displayName = dataReader["DisplayName"].ToString();
                        active = Convert.ToByte(dataReader["Active"]);
                    }
                    if (active == 0)
                    {
                        errorLabel.Text = "User is Inactive. Please contact the system administrator.";
                        errorLabel.Show();
                    }
                    else
                    {
                        this.Hide();
                        lossTypeForm lossForm = new lossTypeForm();
                        lossForm.Show();
                    }

                }
                else
                {
                    errorLabel.Text = "User name or Password Incorrect. Please try again.";
                    errorLabel.Show();
                }


                dataReader.Close();
                command.Dispose();

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("System is unavailable at this time. Please try again later. ");
            }
        }
    }
}
