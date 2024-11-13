using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVentasNortFarma.Models
{
    public class Persona
    {
        private int idPersona;
        private string name;
        private string lastname;
        private string nroDocument;
        private string email;
        private string phoneNumber;
        private string dateBirth;
        private string placeBirth;
        private string address;
        private string status;

        public Persona() { }

        public Persona(int idPersona, string name, string lastname, string nroDocument, string email,
                       string phoneNumber, string dateBirth, string placeBirth, string address, string status)
        {
            this.idPersona = idPersona;
            this.name = name;
            this.lastname = lastname;
            this.nroDocument = nroDocument;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.dateBirth = dateBirth;
            this.placeBirth = placeBirth;
            this.address = address;
            this.status = status;
        }

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string NroDocument
        {
            get { return nroDocument; }
            set { nroDocument = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string DateBirth
        {
            get { return dateBirth; }
            set { dateBirth = value; }
        }

        public string PlaceBirth
        {
            get { return placeBirth; }
            set { placeBirth = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
