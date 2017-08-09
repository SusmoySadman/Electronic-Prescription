using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Electronic_Prescription
{
    class visitDAO
    {
        private string connection = "Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataset;

        public visitDAO()
        {
            sqlConnection = new SqlConnection(connection);
        }

        public DataSet getVisit()
        {
            sqlConnection.Open();
            string query = "select * from visit_3";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataset = new DataSet();
            sqlAdapter.Fill(dataset);

            sqlConnection.Close();
            return dataset;

        }
     /*   public void insert(visitDTO visitDto)
        {
            sqlConnection.Open();
            //string s = "insert into visit values('" + visitDto.ID + "','" + visitDto.NAME + "','" + visitDto.HISTORY + "','" + visitDto.MEDICINE + "','" + visitDto.TEST_NAME + "','" + visitDto.TEST_REPORT + "','" + visitDto.DOCTOR_ID + "','"+visitDto.APP_ID_FK+"')";
            //string s = "insert into visit_2 values('" + visitDto.ID + "','" + visitDto.NAME + "','" + visitDto.HISTORY + "','" + visitDto.MEDICINE + "','" + visitDto.TEST_NAME + "','" + visitDto.TEST_REPORT + "','" + visitDto.APP_ID_FK + "')";
            string s = "insert into visit_3 values('" + visitDto.ID + "','" + visitDto.NAME + "','" + visitDto.HISTORY + "','" + visitDto.TEST_NAME + "','" + visitDto.TEST_REPORT + "','" + visitDto.APP_ID_FK + "')";
            sqlCommand = new SqlCommand(s, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Data Inserted successfully in visit table!!!");

        }
      */
        public void insert(visitDTO vdto)
        {
            sqlConnection.Open();
            string d = "insert into visit_3 values('" + vdto.ID + "','" + vdto.NAME + "','" + vdto.HISTORY + "','" + vdto.TEST_NAME + "','" + vdto.TEST_REPORT + "','" + vdto.APP_ID_FK + "')";
            sqlCommand = new SqlCommand(d, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Inserted successfully in Visit Table");
        
        
        }
        public void delete(int id)
        {

            sqlConnection.Open();
            string m = "delete from visit_3 where visit_id= " + id;
            sqlCommand = new SqlCommand(m, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data successfully deleted from visit table");

        }
        public void update(int id, visitDTO visitDto)
        {
            try
            {

                sqlConnection.Open();
              //  string s = "update  visit set patient_name='" + visitDto.NAME + "',patient_history='" + visitDto.HISTORY + "',medicine='" + visitDto.MEDICINE + "',test_name='" + visitDto.TEST_NAME + "',test_report='" + visitDto.TEST_REPORT + "',doctor_id=" + visitDto.DOCTOR_ID + ",appointment_id="+visitDto.APP_ID_FK +"  where visit_id= " + id;
              //  string s = "update  visit_2 set patient_name='" + visitDto.NAME + "',patient_history='" + visitDto.HISTORY + "',medicine='" + visitDto.MEDICINE + "',test_name='" + visitDto.TEST_NAME + "',test_report='" + visitDto.TEST_REPORT + "',appointment_id=" + visitDto.APP_ID_FK + "  where visit_id= " + id;
                string s = "update  visit_3 set patient_name='"+visitDto.NAME + "',patient_history='" + visitDto.HISTORY + "',test_name='" + visitDto.TEST_NAME + "',test_report='" + visitDto.TEST_REPORT + "',appointment_id=" + visitDto.APP_ID_FK + "  where visit_id= " + id;
                sqlCommand = new SqlCommand(s, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Data successfully updated from visit table");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }


    }
}
