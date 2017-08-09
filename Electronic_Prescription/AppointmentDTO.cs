using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Prescription
{
    class AppointmentDTO
    {
        private int ap_id;
        private string patient_name, visit_date, visit_time;
        private string sex, age;
        private int doctor_id_fk;

        public AppointmentDTO(int ap_id,string patient_name,string visit_date,string visit_time,string sex,string age,int doctor_id_fk)
        {
            this.ap_id = ap_id;
            this.patient_name = patient_name;
            this.visit_date = visit_date;
            this.visit_time = visit_time;
            this.sex = sex;
            this.age = age;
            this.doctor_id_fk = doctor_id_fk;
        }
        public AppointmentDTO(string patient_name, string visit_date, string visit_time, string sex, string age, int doctor_id_fk)
        {
           
            this.patient_name = patient_name;
            this.visit_date = visit_date;
            this.visit_time = visit_time;
            this.sex = sex;
            this.age = age;
            this.doctor_id_fk = doctor_id_fk;
        }
        public int ID
        {
            get { return ap_id; }
            set { ID = value; }
        }
        public string Name
        {
            get { return patient_name; }
            set { Name = value; }
        }
        public string Date
        {
            get { return visit_date; }
            set { Date = value; }
        }
        public string Time
        {
            get { return visit_time; }
            set { Time = value; }

        }
        public string Sex
        {
            get { return sex; }
            set { Sex = value; }

        }
        public string Age
        {
            get { return age; }
            set { Age = value; }
        
        }
        public int Doctor_id_fk
        {
            get { return doctor_id_fk; }
            set { Doctor_id_fk = value; }
        
        }


    }
}
