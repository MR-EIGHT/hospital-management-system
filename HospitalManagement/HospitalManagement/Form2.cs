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
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Xml;

namespace HospitalManagement
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        public Form2()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            materialLabel9.Text = "Patient Id:";
            materialLabel11.Text = "Room Id:";
            materialLabel12.Text = "Doctor Code:";
            materialLabel13.Text = "Patient Name:";
            materialLabel14.Text = "Address:";
            materialLabel15.Text = "Tell:";
            materialLabel16.Text = "Gender:";
            materialLabel17.Text = "Date Admitted:";
            materialLabel18.Text = "Date Discharged:";





            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
            con1.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Patient", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();




        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[0])
            {
                materialLabel9.Text = "Patient Id:";
                materialLabel11.Text = "Room Id:";
                materialLabel12.Text = "Doctor Code:";
                materialLabel13.Text = "Patient Name:";
                materialLabel14.Text = "Address:";
                materialLabel15.Text = "Tell:";
                materialLabel16.Text = "Gender:";
                materialLabel17.Text = "Date Admitted:";
                materialLabel18.Text = "Date Discharged:";





                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
                con1.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select * from Patient", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;

                con1.Close();
            }


            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[1])
            {


                materialLabel9.Text = "Doctor Code:";
                materialLabel11.Text = "Profession:";
                materialLabel12.Text = "SID:";
                materialLabel13.Text = "" ;
                materialLabel14.Text = "" ;
                materialLabel15.Text = "" ;
                materialLabel16.Text = "" ;
                materialLabel17.Text = "" ;
                materialLabel18.Text = "";


                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
                con1.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select * from Doctor", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[2])
            {

                materialLabel9.Text = "Diag No:";
                materialLabel11.Text = "Diag Details:";
                materialLabel12.Text = "Patient ID:";
                materialLabel13.Text = "Medication:";
                materialLabel14.Text = "Other:";
                materialLabel15.Text = "";
                materialLabel16.Text = "";
                materialLabel17.Text = "";
                materialLabel18.Text = "";

                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
                con1.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select * from Diagnosis", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[3])
            {

                materialLabel9.Text = "Bill No:";
                materialLabel11.Text = "Patient ID:";
                materialLabel12.Text = "Patient Name:";
                materialLabel13.Text = "Doctor Name:";
                materialLabel14.Text = "Date:";
                materialLabel15.Text = "Amount:";
                materialLabel16.Text = "";
                materialLabel17.Text = "";
                materialLabel18.Text = "";


                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
                con1.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select * from Bill", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView4.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[4])
            {

                materialLabel9.Text = "SID:";
                materialLabel11.Text = "Name:";
                materialLabel12.Text = "Address:";
                materialLabel13.Text = "Tell:";
                materialLabel14.Text = "Gender:";
                materialLabel15.Text = "Title:";
                materialLabel16.Text = "Department:";
                materialLabel17.Text = "";
                materialLabel18.Text = "";

                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
                con1.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select * from Staff", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[5])
            {


                materialLabel9.Text = "Nurse Code:";
                materialLabel11.Text = "Name:";
                materialLabel12.Text = "Room ID:";
                materialLabel13.Text = "SID:";
                materialLabel14.Text = "";
                materialLabel15.Text = "";
                materialLabel16.Text = "";
                materialLabel17.Text = "";
                materialLabel18.Text = "";

                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
                con1.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select * from Nurse", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView6.DataSource = dt.DefaultView;

                con1.Close();
            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[7])
            {
                materialLabel9.Text = "Room ID:";
                materialLabel11.Text = "Room Type:";
                materialLabel12.Text = "";
                materialLabel13.Text = "";
                materialLabel14.Text = "";
                materialLabel15.Text = "";
                materialLabel16.Text = "";
                materialLabel17.Text = "";
                materialLabel18.Text = "";

                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
                con1.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select * from Room", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView7.DataSource = dt.DefaultView;

                con1.Close();
            }



            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[8] || materialTabControl1.SelectedTab == materialTabControl1.TabPages[6])
            {
                panel3.Hide();
                panel4.Hide();

            }
            else
            {

                panel3.Show();
                panel4.Show();
            }





        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materialSingleLineTextField1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            materialSingleLineTextField2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            materialSingleLineTextField3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            materialSingleLineTextField4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            materialSingleLineTextField5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            materialSingleLineTextField6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            materialSingleLineTextField7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            materialSingleLineTextField8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            materialSingleLineTextField9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materialSingleLineTextField1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            materialSingleLineTextField2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            materialSingleLineTextField3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();



            materialSingleLineTextField4.Text = "";
            materialSingleLineTextField5.Text = "";
            materialSingleLineTextField6.Text = "";
            materialSingleLineTextField7.Text = "";
            materialSingleLineTextField8.Text = "";
            materialSingleLineTextField9.Text = "";

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materialSingleLineTextField1.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            materialSingleLineTextField2.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            materialSingleLineTextField3.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            materialSingleLineTextField4.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            materialSingleLineTextField5.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();

            materialSingleLineTextField6.Text = "";
            materialSingleLineTextField7.Text = "";
            materialSingleLineTextField8.Text = "";
            materialSingleLineTextField9.Text = "";

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materialSingleLineTextField1.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            materialSingleLineTextField2.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            materialSingleLineTextField3.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            materialSingleLineTextField4.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            materialSingleLineTextField5.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            materialSingleLineTextField6.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();


            materialSingleLineTextField7.Text = "";
            materialSingleLineTextField8.Text = "";
            materialSingleLineTextField9.Text = "";

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materialSingleLineTextField1.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            materialSingleLineTextField2.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            materialSingleLineTextField3.Text = dataGridView5.CurrentRow.Cells[2].Value.ToString();
            materialSingleLineTextField4.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();
            materialSingleLineTextField5.Text = dataGridView5.CurrentRow.Cells[4].Value.ToString();
            materialSingleLineTextField6.Text = dataGridView5.CurrentRow.Cells[5].Value.ToString();
            materialSingleLineTextField7.Text = dataGridView5.CurrentRow.Cells[6].Value.ToString();



            materialSingleLineTextField8.Text = "";
            materialSingleLineTextField9.Text = "";
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materialSingleLineTextField1.Text = dataGridView6.CurrentRow.Cells[0].Value.ToString();
            materialSingleLineTextField2.Text = dataGridView6.CurrentRow.Cells[1].Value.ToString();
            materialSingleLineTextField3.Text = dataGridView6.CurrentRow.Cells[2].Value.ToString();
            materialSingleLineTextField4.Text = dataGridView6.CurrentRow.Cells[3].Value.ToString();

            materialSingleLineTextField5.Text = "";
            materialSingleLineTextField6.Text = "";
            materialSingleLineTextField7.Text = "";
            materialSingleLineTextField8.Text = "";
            materialSingleLineTextField9.Text = "";

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materialSingleLineTextField1.Text = dataGridView7.CurrentRow.Cells[0].Value.ToString();
            materialSingleLineTextField2.Text = dataGridView7.CurrentRow.Cells[1].Value.ToString();



            materialSingleLineTextField3.Text = "";
            materialSingleLineTextField4.Text = "";
            materialSingleLineTextField5.Text = "";
            materialSingleLineTextField6.Text = "";
            materialSingleLineTextField7.Text = "";
            materialSingleLineTextField8.Text = "";
            materialSingleLineTextField9.Text = "";

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("server=SERVERNAME;database=Hospital;integrated security=true");
            con1.Open();
            SqlCommand c1 = new SqlCommand();


            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[0])
            {
                c1.CommandText = "Insert into Patient Values(" + "'" + materialSingleLineTextField1.Text + "'" + "," + "'" + materialSingleLineTextField2.Text + "'" + "," + "'" + materialSingleLineTextField3.Text + "'" + "," + "'" + materialSingleLineTextField4.Text + "'" + "," + "'" + materialSingleLineTextField5.Text + "'" + "," + "'" + materialSingleLineTextField6.Text + "'" + "," + "'" + materialSingleLineTextField7.Text + "'" + "," + "'" + materialSingleLineTextField8.Text + "'" + "," + "'" + materialSingleLineTextField9.Text + "'" + ")";

            }


            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[1])
            {
                c1.CommandText = "Insert into Doctor Values(" + "'" + materialSingleLineTextField1.Text + "'" + "," + "'" + materialSingleLineTextField2.Text + "'" + "," + "'" + materialSingleLineTextField3.Text + "'" + ")";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[2])
            {
                c1.CommandText = "Insert into Diagnosis Values(" + "'" + materialSingleLineTextField1.Text + "'" + "," + "'" + materialSingleLineTextField2.Text + "'" + "," + "'" + materialSingleLineTextField3.Text + "'" + "," + "'" + materialSingleLineTextField4.Text + "'" + "," + "'" + materialSingleLineTextField5.Text + "'" + ")";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[3])
            {
                c1.CommandText = "Insert into Bill Values(" + "'" + materialSingleLineTextField1.Text + "'" + "," + "'" + materialSingleLineTextField2.Text + "'" + "," + "'" + materialSingleLineTextField3.Text + "'" + "," + "'" + materialSingleLineTextField4.Text + "'" + "," + "'" + materialSingleLineTextField5.Text + "'" + "," + "'" + materialSingleLineTextField6.Text + "'" + ")";


            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[4])
            {
                c1.CommandText = "Insert into Staff Values(" + "'" + materialSingleLineTextField1.Text + "'" + "," + "'" + materialSingleLineTextField2.Text + "'" + "," + "'" + materialSingleLineTextField3.Text + "'" + "," + "'" + materialSingleLineTextField4.Text + "'" + "," + "'" + materialSingleLineTextField5.Text + "'" + "," + "'" + materialSingleLineTextField6.Text + "'" + "," + "'" + materialSingleLineTextField7.Text + "'" + ")";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[5])
            {
                c1.CommandText = "Insert into Nurse Values(" + "'" + materialSingleLineTextField1.Text + "'" + "," + "'" + materialSingleLineTextField2.Text + "'" + "," + "'" + materialSingleLineTextField3.Text + "'" + "," + "'" + materialSingleLineTextField4.Text + "'" + ")";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[7])
            {
                c1.CommandText = "Insert into Room Values(" + "'" + materialSingleLineTextField1.Text + "'" + "," + "'" + materialSingleLineTextField2.Text + "'" + ")";

            }



            c1.Connection = con1;
            try
            {
                c1.ExecuteNonQuery();

        }
            catch
            {
                MessageBox.Show("insert the data in right form!");
            }

    con1.Close();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("server=SERVERNAME;database=Hospital;integrated security=true");
            con1.Open();
            SqlCommand c1 = new SqlCommand();

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[0])
            {
                c1.CommandText = "update Patient set room_id= N'" + materialSingleLineTextField2.Text + "', dr_code='" + materialSingleLineTextField3.Text + "', Name= N'" + materialSingleLineTextField4.Text + "', Address= N'" + materialSingleLineTextField5.Text + "', tell= N'" + materialSingleLineTextField6.Text + "', gender= N'" + materialSingleLineTextField7.Text + "', date_admitted= N'" + materialSingleLineTextField8.Text + "', date_discharged= N'" + materialSingleLineTextField9.Text + "'where pat_id= '" + materialSingleLineTextField1.Text + "'";

            }


            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[1])
            {
                c1.CommandText = "update Doctor set expert= N'" + materialSingleLineTextField2.Text + "'where dr_code= '" + materialSingleLineTextField1.Text + "'";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[2])
            {
                c1.CommandText = "update Diagnosis set diag_details= N'" + materialSingleLineTextField2.Text + "', pat_id='" + materialSingleLineTextField3.Text + "', medication= N'" + materialSingleLineTextField4.Text + "', other= N'" + materialSingleLineTextField5.Text + "'where diag_no= '" + materialSingleLineTextField1.Text + "'";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[3])
            {
                c1.CommandText = "update Bill set pat_id= N'" + materialSingleLineTextField2.Text + "', Patient_Name='" + materialSingleLineTextField3.Text + "', dr_name= N'" + materialSingleLineTextField4.Text + "', date= N'" + materialSingleLineTextField5.Text + "', amount= N'" + materialSingleLineTextField6.Text + "'where bill_no= '" + materialSingleLineTextField1.Text + "'";


            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[4])
            {
                c1.CommandText = "update Staff set Name= N'" + materialSingleLineTextField2.Text + "', Address='" + materialSingleLineTextField3.Text + "', tell= N'" + materialSingleLineTextField4.Text + "', gender= N'" + materialSingleLineTextField5.Text + "', title= N'" + materialSingleLineTextField6.Text + "', dept= N'" + materialSingleLineTextField7.Text + "'where SID= '" + materialSingleLineTextField1.Text + "'";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[5])
            {
                c1.CommandText = "update Nurse set Name= N'" + materialSingleLineTextField2.Text + "', room_id='" + materialSingleLineTextField3.Text + "', SID= N'" + materialSingleLineTextField4.Text + "'where nurse_code= '" + materialSingleLineTextField1.Text + "'";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[7])
            {
                c1.CommandText = "update Room set room_type= N'" + materialSingleLineTextField2.Text + "'where room_id= '" + materialSingleLineTextField1.Text + "'";

            }


            c1.Connection = con1;
            try
            {
                c1.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("insert the data in right form!");
            }

            con1.Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("server=SERVERNAME;database=Hospital;integrated security=true");
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[0])
            {
                c1.CommandText = "delete from Patient where pat_id='" + materialSingleLineTextField1.Text + "'";

            }


            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[1])
            {
                c1.CommandText = "delete from Doctor where dr_code='" + materialSingleLineTextField1.Text + "'";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[2])
            {
                c1.CommandText = "delete from Diagnosis where diag_no='" + materialSingleLineTextField1.Text + "'";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[3])
            {
                c1.CommandText = "delete from Bill where bill_no='" + materialSingleLineTextField1.Text + "'";


            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[4])
            {
                c1.CommandText = "delete from Staff where SID='" + materialSingleLineTextField1.Text + "'";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[5])
            {
                c1.CommandText = "delete from Nurse where nurse_code='" + materialSingleLineTextField1.Text + "'";

            }

            if (materialTabControl1.SelectedTab == materialTabControl1.TabPages[7])
            {
                c1.CommandText = "delete from Room where room_id='" + materialSingleLineTextField1.Text + "'";

            }

            c1.Connection = con1;
            try
            {
                c1.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("insert the data in right form!");
            }

            con1.Close();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= 9)
            {

                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
                con1.Open();
                SqlCommand c1 = new SqlCommand("", con1);

                if (comboBox1.SelectedIndex == 0)
                {
                    c1.CommandText = "exec Receptionists";
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    c1.CommandText = "exec HeadNurses";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    c1.CommandText = "exec AllNurses";
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    c1.CommandText = "exec Ophthalmologists";
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    c1.CommandText = "exec Obstetrician";
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    c1.CommandText = "exec Cardiologists";
                }
                if (comboBox1.SelectedIndex == 6)
                {
                    c1.CommandText = "exec Endocrinologists";
                }
                if (comboBox1.SelectedIndex == 7)
                {
                    c1.CommandText = "exec Gastroenterologists";
                }
                if (comboBox1.SelectedIndex == 8)
                {
                    c1.CommandText = "exec Janitors";
                }
                if (comboBox1.SelectedIndex == 9)
                {
                    c1.CommandText = "exec Security";
                }


                DataTable dt = new DataTable();
                dt.Load(c1.ExecuteReader());

                dataGridView8.DataSource = dt.DefaultView;

                con1.Close();

            }
            else if (comboBox1.SelectedIndex > 9)
            {
                SqlConnection con2 = new SqlConnection();
                con2.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
                con2.Open();
                SqlDataAdapter daa = new SqlDataAdapter("select * from Patient where pat_id not in (select pat_id from Diagnosis)", con2);

                if (comboBox1.SelectedIndex == 10)
                {
                    daa = new SqlDataAdapter("select * from Patient where pat_id not in (select pat_id from Diagnosis)", con2);

                }
                if (comboBox1.SelectedIndex == 11)
                {
                    daa = new SqlDataAdapter("select * from Patient where date_discharged is NULL or date_discharged=''", con2);
                }
                if (comboBox1.SelectedIndex == 12)
                {
                    daa = new SqlDataAdapter("select room_type,COUNT(*) from Room group by(room_type)", con2);
                }
                if (comboBox1.SelectedIndex == 13)
                {
                    daa = new SqlDataAdapter("select * from patient where pat_id in(select pat_id from Diagnosis group by(pat_id) having count(*) > 1)", con2);
                }

                DataTable dtt = new DataTable();
                daa.Fill(dtt);
                dataGridView8.DataSource = dtt.DefaultView;

                con2.Close();
            }

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
            con1.Open();

            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "BACKUP DATABASE Hospital TO DISK = 'C:\\'";
            c1.Connection = con1;





            c1.ExecuteNonQuery();


            con1.Close();


        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
            con1.Open();

            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "RESTORE DATABASE Hospital From DISK = 'C:\\Backup.bak'";
            c1.Connection = con1;





            c1.ExecuteNonQuery();


            con1.Close();



        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
            con1.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Patient where Name='" + textBox1.Text + "'", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
            con1.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Doctor where Expert='" + textBox2.Text + "'", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt.DefaultView;

            con1.Close();

        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
            con1.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Diagnosis where pat_id='" + textBox3.Text + "'", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
            con1.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Bill where Patient_Name='" + textBox4.Text + "'", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void materialRaisedButton11_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
            con1.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Staff where Name='" + textBox5.Text + "'", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView5.DataSource = dt.DefaultView;

            con1.Close();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
            con1.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Nurse where Name='" + textBox6.Text + "'", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView6.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void materialRaisedButton13_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
            con1.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Room where room_type='" + textBox7.Text + "'", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView7.DataSource = dt.DefaultView;

            con1.Close();
        }

        private void materialRaisedButton14_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";

            con1.Open();

            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "SELECT * FROM Patient FOR XML PATH('Patient'), ROOT('Patients')";
            c1.Connection = con1;

            XmlReader r = c1.ExecuteXmlReader();
            XmlDocument document = new XmlDocument();
            document.Load(r);

            document.Save("Patient report.xml");
            con1.Close();


        }

        private void materialRaisedButton15_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";

            con1.Open();

            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "SELECT * FROM Staff FOR XML PATH('Person'), ROOT('Staff')";
            c1.Connection = con1;

            XmlReader r = c1.ExecuteXmlReader();
            XmlDocument document = new XmlDocument();
            document.Load(r);

            document.Save("Staff report.xml");
            con1.Close();
        }

        private void materialRaisedButton16_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";

            con1.Open();

            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "SELECT * FROM Bill FOR XML PATH('Bill'), ROOT('Bills')";
            c1.Connection = con1;

            XmlReader r = c1.ExecuteXmlReader();
            XmlDocument document = new XmlDocument();
            document.Load(r);

            document.Save("Bill report.xml");
            con1.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=SERVERNAME;database=Hospital;integrated security=true";
            con1.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Patient where Name like '" + textBox1.Text + "%'", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

            con1.Close();
        }
    }
}

