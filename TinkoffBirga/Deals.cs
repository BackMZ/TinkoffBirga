using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinkoffBirga
{
    internal class Deals
    {
        int dealID;
        int FirstCompanyID;
        int SecondCompanyID;

        public int DealID { get => dealID; set => dealID = value; }
        public int FirstCompanyID1 { get => FirstCompanyID; set => FirstCompanyID = value; }
        public int SecondCompanyID1 { get => SecondCompanyID; set => SecondCompanyID = value; }

        public Deals(int dealID, int firstCompanyID, int secondCompanyID)
        {
            this.DealID = dealID;
            FirstCompanyID1 = firstCompanyID;
            SecondCompanyID1 = secondCompanyID;
        }

        public Deals()
        {
            this.DealID = -1;
            FirstCompanyID1 = -1;
            SecondCompanyID1 = -1;
        }
    }
}
