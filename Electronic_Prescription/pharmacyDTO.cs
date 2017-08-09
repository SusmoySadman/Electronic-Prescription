using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Electronic_Prescription
{
    class pharmacyDTO
    {
        private int pharmacy_id;
        private string owner_name, pharmacy_name, contact_number, address;
        private int doctor_id_fk;


        public pharmacyDTO(int id,string name,string ph_name,string number,string address,int id_fk)
        {
            this.pharmacy_id = id;
            this.owner_name = name;
            this.pharmacy_name = ph_name;
            this.contact_number = number;
            this.address = address;
            this.doctor_id_fk = id_fk;
        
        }  
        public pharmacyDTO(string name,string ph_name,string number,string address,int id_fk)
        {
            this.owner_name = name;
            this.pharmacy_name = ph_name;
            this.contact_number = number;
            this.address = address;
            this.doctor_id_fk = id_fk;
        }

        public int ID
        {
            get { return pharmacy_id; }
            set { ID = value; }
        } 
        public string OWN_NAME
        {
            get { return owner_name; }
            set { OWN_NAME = value; }

        } 
        public string PHR_NAME
        {
            get { return pharmacy_name; }
            set { PHR_NAME = value; }

        }
        public string PHONE
        {
            get { return contact_number; }
            set { PHONE = value; }
        }
        public string ADDRESS
        {
            get { return address; }
            set { ADDRESS = value; }
        }
        public int ID_FK
        {
            get { return doctor_id_fk; }
            set { ID_FK = value; }
        
        }
    }
}
