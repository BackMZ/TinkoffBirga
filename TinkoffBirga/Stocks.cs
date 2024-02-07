using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinkoffBirga
{
    internal class Stocks
    {
        int stockID;
        static int stockIDCounter = 1; // переменная для присвоения id переменной stockID

        int companyID;
        string nameCompany;
        int cost; // цена акции
        int dynamic; // переменная для сохранения изменения цены (на данный момент это последнее изменение цены)

        public int CompanyID { get => companyID;}
        public string NameCompany { get => nameCompany; set => nameCompany = value; }
        public int Cost { get => cost; }
        public int Dynamic { get => dynamic; }

        public Stocks(int companyID, string nameCompany, int cost)
        {
            stockID = stockIDCounter;
            stockIDCounter++;

            this.companyID = companyID;
            this.nameCompany = nameCompany;
            this.cost = cost;
            dynamic = 0;
        }

        // метод установки новой цены акции
        public void SetCost(int newCost)
        {
            CalculateDynamic(newCost);
            cost = newCost;
        }

        public void ChangeCost(int costChange)
        {
            int newCost = cost + costChange;
            CalculateDynamic(newCost);
            cost = newCost;
        }

        // метод вычисления изменения цены
        void CalculateDynamic(int newCost)
        {
            dynamic = newCost - cost;
        }

    }
}
