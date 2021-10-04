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
    public partial class lossTypeForm : Form
    {
   
        public lossTypeForm()
        {
            InitializeComponent();
            resultsLabel.Hide();

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=interview-testing-server.database.windows.net;Initial Catalog=Interview;User ID=TestLogin;Password=5D9ej2G64s3sd^";
            cnn = new SqlConnection(connetionString);

            List<LossTypesClass> lossList = new List<LossTypesClass>();

            try
            {
                cnn.Open();
               

                SqlCommand command;
                SqlDataReader dataReader;
                String sql = "";
             
                sql = "SELECT LossTypeID, LossTypeCode, LossTypeDescription from LossTypes";

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                   
                    Byte lID = Convert.ToByte(dataReader["LossTypeID"]);
                    String lCode = dataReader["LossTypeCode"].ToString();
                    String lDesc = dataReader["LossTypeDescription"].ToString();

                    LossTypesClass tempLoss = new LossTypesClass(lID, lCode, lDesc);
                    
                    lossList.Add(tempLoss);
                   
                }
          

                foreach (var lossT in lossList)
                {
                    
                    lossCodeCombo.Items.Add(lossT.LossCode.ToString());
                    lossDescCombo.Items.Add(lossT.LossDescription.ToString());
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

        private void lossCodeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lossDescCombo.SelectedIndex = lossCodeCombo.SelectedIndex;
            resultsLabel.Text = "You selected Code " + lossCodeCombo.Text + ". The Desciption is " + lossDescCombo.Text + ".";
            resultsLabel.Show();
        }

        private void lossDescCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lossCodeCombo.SelectedIndex = lossDescCombo.SelectedIndex;
            resultsLabel.Text = "You selected Description " + lossDescCombo.Text + ". The Code is " + lossCodeCombo.Text + ".";
            resultsLabel.Show();
        }

        private void logOffButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            logInForm loginForm = new logInForm();
            loginForm.Show();
      
        }
    }
    public class LossTypesClass
    {
        byte lossID;
        String lossCode, lossDescription = "";

        public LossTypesClass(byte lossTypeID, String lossTypeCode, String lossTypeDescription)
        {
            lossID = lossTypeID;
            lossCode = lossTypeCode;
            lossDescription = lossTypeDescription;
        }

        public byte LossID
        {
            get { return lossID; }
            set { lossID = value; }
        }
        public String LossCode
        {
            get { return lossCode; }
            set { lossCode = value; }
        }
        public String LossDescription
        {
            get { return lossDescription; }
            set { lossDescription = value; }
        }
    }
}
