using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Electronic_Prescription.Properties;

namespace Electronic_Prescription
{
    
    public partial class Form1 : Form
    {
        DoctorDAO doctorDao = new DoctorDAO();
        AppointmentDAO appointmentDao = new AppointmentDAO();
        visitDAO visitDao = new visitDAO();
        pharmacyDAO pharmacy_dao = new pharmacyDAO();
        SqlDataReader read;

        List<Panel> listpanel = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
           // LoadDoctors();
           // LoadAppointments();
            LoadVisit();
            LoadPharmacy();
            ccc();
            //ddd();
            database_to_combobox_pharmacy();
            database_to_combobox_visit();
            database_to_combobox_prescription();
            database_to_combobox_visit_panel_patient_name();
            database_to_combobox_prescription_doctor_id();
        }

        private void LoadDoctors()
        {

            dataGridView1.DataSource = doctorDao.getDoctors().Tables[0];
       

        } 
        private void LoadAppointments()
        {
            dataGridView2.DataSource = appointmentDao.getAppointments().Tables[0];


        }
        private void LoadVisit()
        {

            dataGridView3.DataSource = visitDao.getVisit().Tables[0];
        
        }
        private void LoadPharmacy()
        { 
           dataGridView4.DataSource= pharmacy_dao.getPharmacy().Tables[0];
        
        }
        private void LoadPrescription()
        { 
        // dataGridView5_prescription.DataSource=
        
        }
        private void button1_doctor_Click(object sender, EventArgs e)
        {
            panel1.Visible=true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listpanel.Add(panel1);
            listpanel.Add(panel2);
            listpanel.Add(panel3);
            listpanel.Add(panel4);
            listpanel.Add(panel5);

            LoadDoctors();
            LoadAppointments();
            LoadVisit();
            LoadPharmacy();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_insert_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1_doctor_id.Text);
            string name=Convert.ToString(textBox2_doctor_name.Text);
            string designation = Convert.ToString(textBox3_designation.Text);
            string concentration = Convert.ToString(textBox4_concentration.Text);
            string phone = Convert.ToString(textBox5_doctor_phone.Text);

            doctorDao.insert(new DoctorDTO(id,name,designation,concentration,phone));

            LoadDoctors();

        }

        private void button2_update_Click(object sender, EventArgs e)
        {
            int d_id = Convert.ToInt32(textBox1_doctor_id.Text);
            string name=Convert.ToString(textBox2_doctor_name.Text);
            string designation=Convert.ToString(textBox3_designation.Text);
            string concentration=Convert.ToString(textBox4_concentration.Text);
            string phone = Convert.ToString(textBox5_doctor_phone.Text);

            doctorDao.update_doctor(d_id,new DoctorDTO(name,designation,concentration,phone));

            LoadDoctors();

        }

        private void button3_delete_Click(object sender, EventArgs e)
        {
            
            int y=Convert.ToInt32(textBox1_doctor_id.Text);
            doctorDao.delete(y);
            LoadDoctors();
        }

        private void button4_refresh_Click(object sender, EventArgs e)
        {
            textBox1_doctor_id.Text = "";
            textBox2_doctor_name.Text="";
            textBox3_designation.Text="";
            textBox4_concentration.Text="";
            textBox5_doctor_phone.Text= "";
        }

        private void button5_main_page_Click(object sender, EventArgs e)
        {
            Form1 fn = new Form1();
            fn.Visible = true;
            this.Hide();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];

            textBox1_doctor_id.Text = selectedrow.Cells[0].Value.ToString();
            textBox2_doctor_name.Text = selectedrow.Cells[1].Value.ToString();
            textBox3_designation.Text = selectedrow.Cells[2].Value.ToString();
            textBox4_concentration.Text = selectedrow.Cells[3].Value.ToString();
            textBox5_doctor_phone.Text = selectedrow.Cells[4].Value.ToString();
        }

        private void button1_appointment_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexe = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView2.Rows[indexe];

            textBox1_appointment_id.Text = selectedrow.Cells[0].Value.ToString();
            textBox2_patient_name.Text = selectedrow.Cells[1].Value.ToString();
            textBox3_visit_date.Text = selectedrow.Cells[2].Value.ToString();
            textBox4_visit_time.Text = selectedrow.Cells[3].Value.ToString();
            textBox5_sex.Text = selectedrow.Cells[4].Value.ToString();
            textBox6_age.Text = selectedrow.Cells[5].Value.ToString();
            comboBox1_doctor_id.Text = selectedrow.Cells[6].Value.ToString();
        }

        private void button1_insert_appointment_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1_appointment_id.Text);
            string name = Convert.ToString(textBox2_patient_name.Text);
            string date = Convert.ToString(textBox3_visit_date.Text);
            string time = Convert.ToString(textBox4_visit_time.Text);
            string sex = Convert.ToString(textBox5_sex.Text);
            string age = Convert.ToString(textBox6_age.Text);
            
            int doctor_id_fk = Convert.ToInt32(comboBox1_doctor_id.Text);


            appointmentDao.insert(new AppointmentDTO(id,name,date,time,sex,age,doctor_id_fk));
           
            LoadAppointments();
        }

        private void button2_update_appointment_Click(object sender, EventArgs e)
        {
            int app_id = Convert.ToInt32(textBox1_appointment_id.Text);
            string name=Convert.ToString(textBox2_patient_name.Text);
            string date=Convert.ToString(textBox3_visit_date.Text);
            string time=Convert.ToString(textBox4_visit_time.Text);
            string sex=Convert.ToString(textBox5_sex.Text);
            string age=Convert.ToString(textBox6_age.Text);

            int doc_id = Convert.ToInt32(comboBox1_doctor_id.Text);

            appointmentDao.update(app_id,new AppointmentDTO(name,date,time,sex,age,doc_id));

            LoadAppointments();

        }

        private void button3_delete_appointment_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(textBox1_appointment_id.Text);
            appointmentDao.delete(y);
            LoadAppointments();
        }  

        private void button4_refresh_appointment_Click(object sender, EventArgs e)
        {
            textBox1_appointment_id.Text = "";
            textBox2_patient_name.Text = "";
            textBox3_visit_date.Text = "";
            textBox4_visit_time.Text = "";
            textBox5_sex.Text = "";
            textBox6_age.Text = "";
            comboBox1_doctor_id.Text = "";
        }

        private void button5_back_to_Click(object sender, EventArgs e)
        {
            Form1 fn = new Form1();
            fn.Visible = true;
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
     
        public void ccc()
        {
            comboBox1_doctor_id.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
            con.Open();
            
            string q = "select doctor_id from doctor";
           
            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand(q,con);
            sqlCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1_doctor_id.Items.Add(dr["doctor_id"].ToString());


            }

            con.Close();


        }
     /*   public void ddd()
        {
            comboBox1_id.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
            con.Open();

            string q = "select doctor_id from doctor";

            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand(q, con);
            sqlCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1_id.Items.Add(dr["doctor_id"].ToString());


            }

            con.Close();


        }*/

        public void database_to_combobox_visit_panel_patient_name()
        {
           // LoadAppointments();
            comboBox1_visitpanel_patient_name.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
            con.Open();

            string q = "select patient_name from appointment_3";

            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand(q, con);
            sqlCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1_visitpanel_patient_name.Items.Add(dr["patient_name"].ToString());


            }

            con.Close();


        }

        private void button1_visit_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_insert_visit_Click(object sender, EventArgs e)
        {
            int visit_id = Convert.ToInt32(textBox1_id.Text);
            string patient_name = Convert.ToString(comboBox1_visitpanel_patient_name.Text);
            string patient_history = Convert.ToString(textBox3_history.Text);
            //string medicine = Convert.ToString(textBox4_medicine.Text);
            string test_name = Convert.ToString(textBox5_test_name.Text);
            string test_report = Convert.ToString(textBox6_test_report.Text);
          //  int doctor_id_fk = Convert.ToInt32(comboBox1_id.Text);
            int appointment_id = Convert.ToInt32(comboBox1_visitid_visitpanel.Text);

           // visitDao.insert(new visitDTO(visit_id,patient_name,patient_history,medicine,test_name,test_report,doctor_id_fk,appointment_id));
            //visitDao.insert(new visitDTO(visit_id, patient_name, patient_history, medicine, test_name, test_report,appointment_id));
            visitDao.insert(new visitDTO(visit_id, patient_name, patient_history, test_name, test_report, appointment_id));

            LoadVisit();


        }

        private void button2_update_visit_Click(object sender, EventArgs e)
        {
            int visit_id = Convert.ToInt32(textBox1_id.Text);
            string patient_name = Convert.ToString(comboBox1_visitpanel_patient_name.Text);
             string patient_history = Convert.ToString(textBox3_history.Text);
            // string medicine = Convert.ToString(textBox4_medicine.Text);
             string test_name = Convert.ToString(textBox5_test_name.Text);
             string test_report = Convert.ToString(textBox6_test_report.Text);
            //int doctor_id = Convert.ToInt32(comboBox1_id.Text);
             int appointment_id = Convert.ToInt32(comboBox1_visitid_visitpanel.Text);

           //  visitDao.update(visit_id,new visitDTO(patient_name,medicine,patient_history,test_name,test_report,doctor_id,appointment_id));

            // visitDao.update(visit_id, new visitDTO(patient_name, medicine, patient_history, test_name, test_report,appointment_id));
             visitDao.update(visit_id, new visitDTO(patient_name,patient_history, test_name, test_report, appointment_id));

            LoadVisit();

        }

        private void button3_delete_visit_Click(object sender, EventArgs e)
        {
             int y;
              y = Convert.ToInt32(textBox1_id.Text);
              visitDao.delete(y);

               LoadVisit();
        }

        private void button4_refresh_visit_Click(object sender, EventArgs e)
        {
            textBox1_id.Text = "";
            comboBox1_visitpanel_patient_name.Text = "";
            textBox3_history.Text = "";
            //textBox4_medicine.Text = "";
            textBox5_test_name.Text = "";
            textBox6_test_report.Text = "";
          //  comboBox1_id.Text = "";
            comboBox1_visitid_visitpanel.Text="";

        }

        private void button5_main_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true;
            this.Hide();
        }
        public void database_to_combobox_visit()
        {
            comboBox1_visitid_visitpanel.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
            con.Open();

            string q = "select appointment_id from appointment_3";

            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand(q, con);
            sqlCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1_visitid_visitpanel.Items.Add(dr["appointment_id"].ToString());


            }

            con.Close();


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexe = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView3.Rows[indexe];

            textBox1_id.Text = selectedrow.Cells[0].Value.ToString();
            comboBox1_visitpanel_patient_name.Text = selectedrow.Cells[1].Value.ToString();
            textBox3_history.Text = selectedrow.Cells[2].Value.ToString();
         //   textBox4_medicine.Text = selectedrow.Cells[3].Value.ToString();
            textBox5_test_name.Text = selectedrow.Cells[3].Value.ToString();
            textBox6_test_report.Text = selectedrow.Cells[4].Value.ToString();
            //comboBox1_id.Text = selectedrow.Cells[5].Value.ToString();
           comboBox1_visitid_visitpanel.Text = selectedrow.Cells[5].Value.ToString();
 
        }

        private void button1_pharmacy_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;

        } 

        private void button1_insert_pharmacy_Click(object sender, EventArgs e)
        {
            int pharmacy_id = Convert.ToInt32(textBox1.Text);
            string owner_name = Convert.ToString(textBox2.Text);
            string pharmacy_name = Convert.ToString(textBox3.Text);
            string contact_number = Convert.ToString(textBox4.Text);
            string pharmacy_address = Convert.ToString(textBox5.Text);
            int doctor_id = Convert.ToInt32(comboBox1_pharmacy.Text);

            pharmacy_dao.insert(new pharmacyDTO(pharmacy_id,owner_name,pharmacy_name,contact_number,pharmacy_address,doctor_id));

            LoadPharmacy();

        }

        private void button2_pharmacy_update_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(textBox1.Text);

            string own_name = Convert.ToString(textBox2.Text);
            string pha_name = Convert.ToString(textBox3.Text);
            string phone = Convert.ToString(textBox4.Text);
            string address = Convert.ToString(textBox5.Text);
            int doct_id = Convert.ToInt32(comboBox1_pharmacy.Text);


            pharmacy_dao.update(y,new pharmacyDTO(own_name,pha_name,phone,address,doct_id));
            LoadPharmacy();
        }

        private void button3_pharmacy_delete_Click(object sender, EventArgs e)
        {
            int doc_id = Convert.ToInt32(textBox1.Text);
            pharmacy_dao.delete(doc_id);
            LoadPharmacy();
        }

        private void button4_refresh_pharmacy_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1_pharmacy.Text = "";
        }

        private void button1_back_to_pharmacy_Click(object sender, EventArgs e)
        {
            Form1 fn = new Form1();
            fn.Visible = true;
            this.Hide();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexe = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView4.Rows[indexe];

            textBox1.Text = selectedrow.Cells[0].Value.ToString();
            textBox2.Text = selectedrow.Cells[1].Value.ToString();
            textBox3.Text = selectedrow.Cells[2].Value.ToString();
            textBox4.Text = selectedrow.Cells[3].Value.ToString();
            textBox5.Text = selectedrow.Cells[4].Value.ToString();
            comboBox1_pharmacy.Text = selectedrow.Cells[5].Value.ToString();
            

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void database_to_combobox_pharmacy()
        {
            comboBox1_pharmacy.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
            con.Open();

            string q = "select doctor_id from doctor";

            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand(q, con);
            sqlCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1_pharmacy.Items.Add(dr["doctor_id"].ToString());


            }

            con.Close();


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_prescription_Click(object sender, EventArgs e)
        {

            //   panel1.Visible = false;
              // panel2.Visible = false;
               //panel3.Visible = false;
               //panel4.Visible = false;
               panel5.Visible = true;
            
            
        }

        private void dataGridView5_prescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void database_to_combobox_prescription()
        {
            comboBox1_prescription.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
            con.Open();

           // string q = "select patient_name from visit";
            string q = "select patient_name from visit_3";

            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand(q, con);
            sqlCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1_prescription.Items.Add(dr["patient_name"].ToString());


            }

            con.Close();


        }

        public void database_to_combobox_prescription_doctor_id()
        {
            comboBox1_pharmacy.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
            con.Open();

            string q = "select doctor_id from appointment_3";

            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand(q, con);
            sqlCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1_doctor_id_prescription.Items.Add(dr["doctor_id"].ToString());


            }

            con.Close();


        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_clear_prescription_Click(object sender, EventArgs e)
        {
            comboBox1_prescription.Text = "";
        }

        private void button1_detail_prescription_Click(object sender, EventArgs e)
        {
            if (comboBox1_prescription.Text == "")
            {
                MessageBox.Show("Please select the patient name to get prescription");
            }
            else
            {
                prescription1();
                medicines();
                date_time();
                doctor_name();
                doctor_phone();
                doctor_designation();
                doctor_speciality();
            }
        }
        public void prescription1()
        {
            try 
            {   string name=Convert.ToString(comboBox1_prescription.Text);
                SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
                con.Open();
                SqlCommand comm;
             

                string s = "select visit_3.patient_name,visit_3.patient_history,visit_3.test_name,visit_3.test_report,appointment_3.sex,appointment_3.age,appointment_3.time,appointment_3.doctor_id from visit_3 join appointment_3 on visit_3.appointment_id=appointment_3.appointment_id  where visit_3.patient_name='" + name + "'";
                
                
                comm = new SqlCommand(s,con);
                read = comm.ExecuteReader();

                 while(read.Read())
                 {
                     patient_name_pres.Text=read.GetString(0);
                     pat_history.Text= read.GetString(1);
                     test_name.Text = read.GetString(2);
                     report.Text= read.GetString(3);
                     sex.Text = read.GetString(4);
                     age.Text = read.GetString(5);


                 }

            }
          
            catch(Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        public void medicines()
        {
            try
            {
                string name = Convert.ToString(comboBox1_prescription.Text);
                SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
                con.Open();
                SqlCommand comm;

   
                  string s = "select Medicine.medicine_name , Medicine.quantity, Medicine.times_per_day from visit_3 join  Medicine ON Medicine.visit_id=visit_3.visit_id where visit_3.patient_name='" + name + "'";

                comm = new SqlCommand(s, con);
                read = comm.ExecuteReader();
                string medicine_list = "";
                int i = 1;

                while (read.Read())
                {
                    medicine_list=medicine_list+i+"."+read.GetString(0)+ "  quantity:"+read.GetString(1)+".  times per day : "+read.GetString(2)+"\n";
                    i++;
                }
                pres_medicine.Text = medicine_list;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        public void date_time()
        {
            try
            {
                string name = Convert.ToString(comboBox1_prescription.Text);
                SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
                con.Open();
                SqlCommand comm;


               // string s = "select visit_3.patient_name,visit_3.patient_history,visit_3.test_name,visit_3.test_report,appointment_3.sex,appointment_3.age,appointment_3.time,appointment_3.doctor_id from visit_3 join appointment_3 on visit_3.appointment_id=appointment_3.appointment_id  where visit_3.patient_name='" + name + "'";
                string s = "select appointment_3.time,appointment_3.date from appointment_3 where appointment_3.patient_name='"+name+"'";

                comm = new SqlCommand(s, con);
                read = comm.ExecuteReader();

                while (read.Read())
                {
                   
                    time.Text = read.GetString(0);
                    date.Text = read.GetString(1);


                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
         public void doctor_name()
         {
             try
             {
               
                 SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
                 con.Open();
                 SqlCommand comm;

                 int y = Convert.ToInt32(comboBox1_doctor_id_prescription.Text);
                string s="select doctor_name from doctor join appointment_3 on doctor.doctor_id=appointment_3.doctor_id where appointment_3.doctor_id="+y+"";        
        
                 comm = new SqlCommand(s, con);
                 read = comm.ExecuteReader();

                 while (read.Read())
                 {      
                     name.Text = read.GetString(0);
                 }
             }

             catch (Exception ex)
             {

                 MessageBox.Show(ex.ToString());
             }

         }
         public void doctor_phone()
         {
             try
             {

                 SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
                 con.Open();
                 SqlCommand comm;
                 int y = Convert.ToInt32(comboBox1_doctor_id_prescription.Text);
             
                 string s = "select doctor_phone from doctor where doctor_id="+y+"";

                 comm = new SqlCommand(s, con);
                 read = comm.ExecuteReader();

                 while (read.Read())
                 {
                     phone.Text = read.GetString(0);
                 }
             }

             catch (Exception ex)
             {

                 MessageBox.Show(ex.ToString());
             }

         }
         public void doctor_designation()
         {
             try
             {

                 SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
                 con.Open();
                 SqlCommand comm;
                 int y = Convert.ToInt32(comboBox1_doctor_id_prescription.Text);

                 string s = "select designation from doctor where doctor_id=" + y + "";

                 comm = new SqlCommand(s, con);
                 read = comm.ExecuteReader();

                 while (read.Read())
                 {
                     designation.Text = read.GetString(0);
                 }
             }

             catch (Exception ex)
             {

                 MessageBox.Show(ex.ToString());
             }

         }

         public void doctor_speciality()
         {
             try
             {

                 SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
                 con.Open();
                 SqlCommand comm;
                 int y = Convert.ToInt32(comboBox1_doctor_id_prescription.Text);

                 string s = "select concentration from doctor where doctor_id=" + y + "";

                 comm = new SqlCommand(s, con);
                 read = comm.ExecuteReader();

                 while (read.Read())
                 {
                     speciality.Text = read.GetString(0);
                 }
             }

             catch (Exception ex)
             {

                 MessageBox.Show(ex.ToString());
             }

         }  

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_add_medicine_Click(object sender, EventArgs e)
        {
            Medicine_form mf = new Medicine_form();
            mf.Visible = true;
            this.Hide();
        }

        private void comboBox1_visitid_visitpanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void patient_name_pres_Click(object sender, EventArgs e)
        {

        }

        private void pat_history_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void report_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Image image = Resources.logo2;
            e.Graphics.DrawImage(image, 350, 20, image.Width, image.Height);
            e.Graphics.DrawString(name.Text.Trim(), new Font("Comic Sans MS", 12, FontStyle.Bold | FontStyle.Italic), Brushes.OliveDrab, new Point(25, 20));
            e.Graphics.DrawString(designation.Text.Trim(), new Font("Comic Sans MS", 8, FontStyle.Bold | FontStyle.Italic), Brushes.OliveDrab, new Point(25, 40));
            e.Graphics.DrawString(speciality.Text.Trim(), new Font("Comic Sans MS", 8, FontStyle.Bold | FontStyle.Italic), Brushes.OliveDrab, new Point(25, 60));
            e.Graphics.DrawString(phone.Text.Trim(), new Font("Comic Sans MS", 8, FontStyle.Bold | FontStyle.Italic), Brushes.OliveDrab, new Point(25, 80));


            e.Graphics.DrawString("শুক্রবার সাপ্তাহিক বন্ধ থাকবে", new Font("Siyam Rupali", 8, FontStyle.Bold | FontStyle.Italic), Brushes.Red, new Point(680, 95));
            e.Graphics.DrawString("অনুগ্রহ করে পরবর্তী সাক্ষাতে ব্যবস্থাপত্র সঙ্গে আনবেন", new Font("Siyam Rupali", 8, FontStyle.Bold | FontStyle.Italic), Brushes.Red, new Point(560, 110));
            e.Graphics.DrawString("Date:  " + DateTime.Now, new Font("Arial", 10, FontStyle.Bold | FontStyle.Italic), Brushes.Blue, new Point(25, 110));
            e.Graphics.DrawLine(new Pen(Color.Orange, 1), new Point(0, 130), new Point(850, 130));
            e.Graphics.DrawLine(new Pen(Color.Orange, 1), new Point(0, 1000), new Point(850, 1000));
            e.Graphics.DrawLine(new Pen(Color.Orange, 1), new Point(0, 240), new Point(850, 240));
            e.Graphics.DrawLine(new Pen(Color.Red, 1), new Point(250, 240), new Point(250, 1000));
            e.Graphics.DrawString("Patient Name:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 140));
            e.Graphics.DrawString(patient_name_pres.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(120, 140));
            e.Graphics.DrawString("Age:  ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 165));
            e.Graphics.DrawString(age.Text + " yr ", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(70, 165));
            e.Graphics.DrawString("Sex:  ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(380, 165));
            e.Graphics.DrawString(sex.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(430, 165));



            e.Graphics.DrawString("Rx:  ", new Font("Arial", 13, FontStyle.Bold | FontStyle.Italic), Brushes.Black, new Point(255, 250));
            e.Graphics.DrawString(pres_medicine.Text, new Font("Arial", 13, FontStyle.Bold | FontStyle.Italic), Brushes.Black, new Point(300,300));
            e.Graphics.DrawString("Chief Complains", new Font("Arial", 13, FontStyle.Bold | FontStyle.Italic), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString(pat_history.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25,300));
            e.Graphics.DrawString("Test Name", new Font("Arial", 13, FontStyle.Bold | FontStyle.Italic), Brushes.Black, new Point(25, 500));
            e.Graphics.DrawString(test_name.Text.Trim(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 520));
            e.Graphics.DrawString("Test Report", new Font("Arial", 13, FontStyle.Bold | FontStyle.Italic), Brushes.Black, new Point(25, 760));
            e.Graphics.DrawString(report.Text.Trim(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 780));




        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void test_name_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }



       
    }
}
