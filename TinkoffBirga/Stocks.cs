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
        static int stockIDCounter = 0;  // переменная для присвоения id переменной stockID (удалить, если это делается в БД)

        int companyID;
        string nameCompany;
        int cost;  // цена акции
        int dynamic;  // переменная для сохранения изменения цены (за определённый период)

        Stocks(int companyID, string nameCompany, int cost)
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

        // метод вычисления изменения цены
        void CalculateDynamic(int newCost)
        {
            dynamic = newCost - cost;
        }

    }
}
