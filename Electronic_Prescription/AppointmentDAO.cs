using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Electronic_Prescription
{
    class AppointmentDAO
    {
        private string connection = "Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataset;
    
        public AppointmentDAO()
        {
            sqlConnection = new SqlConnection(connection);
        }

        public DataSet getAppointments()
        {
            sqlConnection.Open();
            string query = "select * from appointment_3";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataset = new DataSet();
            sqlAdapter.Fill(dataset);

            sqlConnection.Close();
            return dataset;

        }
        public void insert(AppointmentDTO appointmentDto)
        {
            sqlConnection.Open();
            string s = "insert into appointment_3 values('" + appointmentDto.ID + "','" + appointmentDto.Name + "','" + appointmentDto.Date + "','" + appointmentDto.Time + "','" + appointmentDto.Sex+ "','" + appointmentDto.Age + "','" + appointmentDto.Doctor_id_fk + "')";
            sqlCommand = new SqlCommand(s,sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Data Inserted successfully in Appointment table!!!");

        
        }
        public void delete(int id)
        {

            sqlConnection.Open();
            string s = "delete from appointment_3 where appointment_id= " + id;
            sqlCommand = new SqlCommand(s, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data successfully deleted from appointment table");

        } 
        public void update(int id,AppointmentDTO appointmentDto)
        {
            try
            {
                sqlConnection.Open();
                string s = "update appointment_3 set patient_name='" + appointmentDto.Name + "',date='" + appointmentDto.Date + "',time='" + appointmentDto.Time + "',sex='" + appointmentDto.Sex + "',age='" + appointmentDto.Age + "',doctor_id=" + appointmentDto.Doctor_id_fk +" where appointment_id=  "+ id ;
                sqlCommand = new SqlCommand(s,sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Data updated successfully in appointment table");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


        }
        
       

    }
}
