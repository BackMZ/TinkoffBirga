using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinkoffBirga
{
    internal class Companies
    {
        int companyID;
        static int IDCounter = 0;
        string nameCompany;
        string legalAddress;
        string email;
        string INN;

        public int CompanyID { get => companyID; set => companyID = value; }
        public string NameCompany { get => nameCompany; set => nameCompany = value; }
        public string LegalAddress { get => legalAddress; set => legalAddress = value; }
        public string Email { get => email; set => email = value; }
        public string CompanyINN { get => INN; set => INN = value; }

        public Companies(string nameCompany, string legalAddress, string email, string INN)
        {
            this.CompanyID = IDCounter;
            this.NameCompany = nameCompany;
            this.LegalAddress = legalAddress;
            this.Email = email;
            this.INN = INN;
            IDCounter++;
        }

        public Companies()
        {
            this.CompanyID = -1;
            this.NameCompany = null;
            this.LegalAddress = null;
            this.Email = null;
            this.INN = null;
        }
    }
}
