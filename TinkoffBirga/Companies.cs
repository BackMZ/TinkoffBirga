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
        static int IDCounter = 1;
        string nameCompany;
        string legalAddress;
        string email;
        string INN;

        public int CompanyID { get => companyID; }
        public string NameCompany { get => nameCompany; set => nameCompany = value; }
        public string LegalAddress { get => legalAddress; set => legalAddress = value; }
        public string Email { get => email; set => email = value; }
        public string CompanyINN { get => INN; set => INN = value; }

        public Companies(string nameCompany, string legalAddress, string email, string INN)
        {
            this.companyID = IDCounter;
            IDCounter++;

            this.nameCompany = nameCompany;
            this.legalAddress = legalAddress;
            this.email = email;
            this.INN = INN;
        }
    }
}
