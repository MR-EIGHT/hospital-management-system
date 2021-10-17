using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class LoginForm :  MaterialSkin.Controls.MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Sizable = false;
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection("server=SERVERNAME;database=Hospital;integrated security=true");
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            c1.Connection = con1;
            c1.CommandText = "SELECT * from Auth where Username='" + materialSingleLineTextField1.Text + "' and Password='" + materialSingleLineTextField2.Text + "'";

            SqlDataReader dr = c1.ExecuteReader();
            object[] x = new object[2];
            if (dr.Read())
            {
                dr.GetValues(x);
                if (x[0].ToString() == "Mehrdad")
                {
                    this.Hide();
                   Form2 mainForm = new Form2();
                   mainForm.Closed += (s, args) => this.Close();
                   mainForm.Show();
                }

            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");

            }

            con1.Close();


        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registering new user is not possible Right now! Sorry :( ");
        }
    }
}
