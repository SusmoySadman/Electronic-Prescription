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
    class pharmacyDAO
    {
        private string connection = "Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;

        public pharmacyDAO()
        {
            sqlConnection = new SqlConnection(connection);
        }
        public DataSet getPharmacy()
        {
            sqlConnection.Open();
            string s = "select * from pharmacy_2";
            sqlCommand = new SqlCommand(s,sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);
            sqlConnection.Close();

            return dataSet;
        
        }
        public void insert(pharmacyDTO pharmacy_dto)
        {
            sqlConnection.Open();
            string s = "insert into pharmacy_2 values(" + pharmacy_dto.ID + ",'" + pharmacy_dto.OWN_NAME + "','" + pharmacy_dto.PHR_NAME + "','" + pharmacy_dto.PHONE + "','" + pharmacy_dto.ADDRESS + "'," + pharmacy_dto.ID_FK + ")";
            sqlCommand = new SqlCommand(s,sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data inserted successfully in pharmacy table");
        
        }
        public void delete(int id)
        {
            sqlConnection.Open();
            string s = "delete from pharmacy_2 where pharmacy_id= "+id;
            sqlCommand = new SqlCommand(s,sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("data deleted from pharmacy table");


        } 
        public void update(int id,pharmacyDTO pharmacy_dto)
        {
            try
            {
                sqlConnection.Open();
                string s = "update pharmacy_2 set owner_name='" + pharmacy_dto.OWN_NAME + "',pharmacy_name='" + pharmacy_dto.PHR_NAME + "',contact_number='" + pharmacy_dto.PHONE + "',pharmacy_address='" + pharmacy_dto.ADDRESS + "',doctor_id='" + pharmacy_dto.ID_FK + "' where pharmacy_id=  " + id;
                sqlCommand = new SqlCommand(s, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("data updated successfully from pharmacy table!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
