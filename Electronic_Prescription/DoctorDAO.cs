using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Electronic_Prescription
{
    class DoctorDAO
    {
        private string connection = "Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataset;


        public DoctorDAO()
        {
            sqlConnection = new SqlConnection(connection);
        
        }
        public DataSet getDoctors()
        {
            sqlConnection.Open();
            string query = "select * from doctor";
           
            sqlCommand = new SqlCommand (query,sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataset = new DataSet();
            sqlAdapter.Fill(dataset);

            sqlConnection.Close();
            return dataset;

        }
        public void insert(DoctorDTO doctorDto)
        {
            sqlConnection.Open();
            string s = "insert into doctor values('"+doctorDto.ID+"','"+doctorDto.Name+"','"+doctorDto.Designation+"','"+doctorDto.Concentration+"','"+doctorDto.Phone+"')";
            sqlCommand = new SqlCommand(s, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data inserted successfully in the Doctor table");
        
        }
        public void delete(int id)
        {
            try
            {
                sqlConnection.Open();
                string s = "delete from doctor where doctor_id= " + id;
                sqlCommand = new SqlCommand(s, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Data successfully deleted from doctor table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        
        } 
        
        public void update_doctor(int id,DoctorDTO doctorDto)
        {
            try
            {
                sqlConnection.Open();
                string s = "update doctor set doctor_name='" + doctorDto.Name + "',designation='" + doctorDto.Designation + "',concentration='" + doctorDto.Concentration + "',doctor_phone='" + doctorDto.Phone + "' where doctor_id= " + id;
                sqlCommand = new SqlCommand(s, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Data updated successfully in doctor table!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            
            }
            
        }




       
    }
}
