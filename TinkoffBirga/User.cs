using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinkoffBirga
{
    internal class User
    {
        int userID;
        static int IDCounter = 1;
        string fisrtname;
        string lastname;
        string surname; // отчество
        string email;
        string INN;

        public User (string firstname, string lastname, string surname, string email, string INN)
        {
            userID = IDCounter;
            IDCounter++;

            this.fisrtname = firstname;
            this.lastname = lastname;
            this.surname = surname;
            this.email = email;
            this.INN = INN;
        }
    }
}
