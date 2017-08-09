using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Prescription
{
    class DoctorDTO
    {
        private int doctor_id;
        private string doctor_name,designation,concentration,doctor_phone;

        public DoctorDTO(int doctor_id,string doctor_name,string designation,string concentration,string doctor_phone)
        {
            this.doctor_id = doctor_id;
            this.doctor_name = doctor_name;
            this.designation = designation;
            this.concentration = concentration;
            this.doctor_phone = doctor_phone;


        }
        public DoctorDTO(string doctor_name,string designation,string concentration,string doctor_phone)
        {
            this.doctor_name = doctor_name;
            this.designation = designation;
            this.concentration = concentration;
            this.doctor_phone = doctor_phone;
        
        }

        public DoctorDTO()
        {
            // TODO: Complete member initialization
        }
        public int ID
        {
            get { return doctor_id; }
            set { ID = value; }
        }
        public string Name
        {
            get { return doctor_name; }
            set { Name = value; }
        }
        public string Designation
        {
            get { return designation; }
            set { Designation = value; }
        }
        public string Concentration
        {
            get { return concentration; }
            set { Concentration = value; }

        }
        public string Phone
        {
            get { return doctor_phone; }
            set { Phone = value; }
        
        }
    }
}
