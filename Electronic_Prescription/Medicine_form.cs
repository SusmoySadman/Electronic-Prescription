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
using System.Data;

namespace Electronic_Prescription
{
    public partial class Medicine_form : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
        SqlCommand sqlCommand;
        DataSet dataset;
        SqlDataAdapter sqlAdapter;
        public Medicine_form()
        {
            InitializeComponent();
            database_to_combobox_visit_id();
        }

        public void Load_Medicine()
        {

            sqlConnection = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
            sqlConnection.Open();
            sqlCommand = new SqlCommand("select * from Medicine", sqlConnection);
            dataset = new DataSet();
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataset);
            dataGridView1_medicine.DataSource = dataset.Tables[0];
            sqlConnection.Close();
        }
 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Medicine_form_Load(object sender, EventArgs e)
        {
            Load_Medicine();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_add_medicine_Click(object sender, EventArgs e)
        {
            textBox2_medicine_name.Text = textBox1_auto_text_fill.Text;
        }

        private void button1_insert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string name=Convert.ToString(textBox2_medicine_name.Text);
            string quantity=Convert.ToString(comboBox1_quantity.Text);
            string times = Convert.ToString(comboBox2_times_per_day.Text);
            int visit_id = Convert.ToInt32(comboBox1_visit_id.Text);
            
            string s = "insert into Medicine values('"+name+"','"+quantity+"','"+times+"',"+visit_id+")";
            sqlCommand = new SqlCommand(s,sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data inserted successfully in Medicine table!!!");
            Load_Medicine();
        }
        public void database_to_combobox_visit_id()
        {
            // LoadAppointments();
            comboBox1_visit_id.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
            con.Open();

            string q = "select visit_id from visit_3";

            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand(q, con);
            sqlCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1_visit_id.Items.Add(dr["visit_id"].ToString());


            }

            con.Close();


        }

        private void comboBox1_visit_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_medicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_medicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2_medicine_name.Text = dataGridView1_medicine.CurrentRow.Cells[1].Value.ToString();
            comboBox1_quantity.Text = dataGridView1_medicine.CurrentRow.Cells[2].Value.ToString();
            comboBox2_times_per_day.Text = dataGridView1_medicine.CurrentRow.Cells[3].Value.ToString();
            comboBox1_visit_id.Text = dataGridView1_medicine.CurrentRow.Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {//this is delete button
            sqlConnection.Open();
            string name = Convert.ToString(dataGridView1_medicine.CurrentRow.Cells[1].Value.ToString());
            string s = "delete from Medicine where medicine_name= '"+name+ "'";
            sqlCommand = new SqlCommand(s, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data deleted successfully from Table");
            Load_Medicine();

        }

        private void button2_update_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBox2_medicine_name.Text);
            string quantity = Convert.ToString(comboBox1_quantity.Text);
            string times = Convert.ToString(comboBox2_times_per_day.Text);
            int visit_id = Convert.ToInt32(comboBox1_visit_id.Text);
            

            int id = Convert.ToInt32(dataGridView1_medicine.CurrentRow.Cells[0].Value.ToString()); //bringing the medicine_id from data grid view

          //  sqlConnection = new SqlConnection("Data Source=SIFAT\\SQLExpress;Initial Catalog=E_Prescription_2;Integrated Security=True");
            sqlConnection.Open();
            
            string s = "update Medicine set medicine_name='"+name+"',quantity='"+quantity+"',times_per_day='"+times+ "',visit_id="+visit_id+" where medicine_id='" + id + "' ";
            sqlCommand = new SqlCommand(s, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data Updates Successfully!!!");

            Load_Medicine();
        }

        private void button3_refresh_Click(object sender, EventArgs e)
        {
            textBox1_auto_text_fill.Text = "";
            textBox2_medicine_name.Text = "";
            comboBox1_quantity.Text = "";
            comboBox2_times_per_day.Text = "";
            comboBox1_visit_id.Text = "";
        }

        private void textBox1_auto_text_fill_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_back_to_form1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true;
            this.Hide();

        }

        private void button_get_patient_name_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(comboBox1_visit_id.Text);
            sqlConnection.Open();
            string sqlquery = "select patient_name from visit_3 where visit_id='"+y+"'";
            SqlCommand command = new SqlCommand(sqlquery,sqlConnection);
            textBox1_get_patient_name.Text = command.ExecuteScalar().ToString();
            sqlConnection.Close();



        }

        private void textBox1_get_patient_name_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
