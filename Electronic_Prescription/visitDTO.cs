using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Prescription
{
    class visitDTO
    {
        private int visit_id;
        private string patient_name, patient_history,test_name, test_report;
       // private int doctor_id_fk;
        private int appointment_id_fk;
     //   private int appointment_id;
       
       

       /* public visitDTO(int visit_id,string patient_name,string patient_history,string test_name,string test_report,int appointment_id_fk)
        {
            this.visit_id = visit_id;
            this.patient_name = patient_name;
            this.patient_history = patient_history;
           // this.medicine = medicine;
            this.test_name = test_name;
            this.test_report = test_report;
           // this.doctor_id_fk = doctor_id_fk;
            this.appointment_id_fk = appointment_id_fk;
        
        }*/
   

      /*  public visitDTO(string patient_name,string patient_history, string test_name, string test_report,int appointment_id_fk)
        {
            // TODO: Complete member initialization
            this.patient_name = patient_name;
            this.patient_history = patient_history;
           // this.medicine = medicine;
           
            
            this.test_name = test_name;
            this.test_report = test_report;
            //this.doctor_id_fk = doctor_id;
            this.appointment_id_fk = appointment_id_fk;
        }*/

       /* public visitDTO(int visit_id, string patient_name, string patient_history,string test_name, string test_report, int appointment_id_fk)
        {
            this.visit_id = visit_id;
            this.patient_name = patient_name;
            this.patient_history = patient_history;
         //   this.medicine = medicine;
            this.test_name = test_name;
            this.test_report = test_report;
            this.appointment_id_fk = appointment_id_fk;

        }*/
     /*   public visitDTO(string patient_name,string patient_history, string test_name, string test_report, int appointment_id_fk)
        {
            // TODO: Complete member initialization
            this.patient_name = patient_name;
            this.patient_history = patient_history;
          //  this.medicine = medicine;


            this.test_name = test_name;
            this.test_report = test_report;
            this.appointment_id_fk = appointment_id_fk;
        }*/
        public visitDTO(string patient_name,string patient_history, string test_name, string test_report, int appointment_id_fk)
        {
            // TODO: Complete member initialization
            //for update
           
            this.patient_name = patient_name;
            this.patient_history = patient_history;

            this.test_name = test_name;
            this.test_report = test_report;
            this.appointment_id_fk = appointment_id_fk;
        }

        public visitDTO(int visit_id, string patient_name, string patient_history, string test_name, string test_report, int appointment_id_fk)
        {
            // TODO: Complete member initialization
            //for insert
            this.visit_id = visit_id;
            this.patient_name = patient_name;
            this.patient_history = patient_history;
            this.test_name = test_name;
            this.test_report = test_report;
            this.appointment_id_fk = appointment_id_fk;
        }
       
        public int ID
        {
            get { return visit_id; }
            set { ID = value; }
        }
        public string NAME
        {
            get { return patient_name; }
            set { NAME = value; }
        }
        public string HISTORY
        {
            get { return patient_history; }
            set { HISTORY = value; }
        }
    /*    public string MEDICINE
        {
            get { return medicine; }
            set { MEDICINE = value; }
        }
     */
        public string TEST_NAME
        {
            get { return test_name; }
            set { TEST_NAME = value; }
        }
        public string TEST_REPORT
        {
            get { return test_report; }
            set { TEST_REPORT = value; }
        }
  /*      public int DOCTOR_ID
        {
            get { return doctor_id_fk; }
            set { DOCTOR_ID = value; }
        }
   */
        public int APP_ID_FK
        {
            get { return appointment_id_fk; }
            set { APP_ID_FK = value; }
        }

    }
}
