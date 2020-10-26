using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppSAV.Metier
{
    class Reparation
    {
        public String Nom { get; set; }

        public String Prenom { get; set; }

        public String ModelPhone { get; set; }

        public int Mobile { get; set; }

        public String Email { get; set; }

        public DateTime DateRecue { get; set; }

        public String Description { get; set; }

        public String Status { get; set; }

        public int PrixReparation { get; set; }



        public Reparation(String Nom, String Prenom, String ModelPhone, int Mobile, String Email, DateTime DateRecue, 
                          String Description, String Status, int PrixReparation)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.ModelPhone = ModelPhone;
            this.Mobile = Mobile;
            this.Email = Email;
            this.DateRecue = DateRecue;
            this.Description = Description;
            this.Status = Status;
            this.PrixReparation = PrixReparation;

        }


    }
}
