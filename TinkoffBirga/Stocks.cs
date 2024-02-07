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
        bool dynamicsDirection; // true - цена увеличивается, false - цена уменьшается

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
            dynamicsDirection = true;
        }

        // метод для изменения цены
        public void ChangeCost(int newCost)
        {
            int costChange = newCost - cost;
            CalculateDynamic(newCost, costChange);
            cost = newCost;
        }

        // метод вычисления изменения динамики цены
        void CalculateDynamic(int newCost, int costChange)
        {
            if (newCost > cost && dynamicsDirection == true)
            {
                IncreaseDynamics(newCost);
            }
            else if (newCost > cost && dynamicsDirection == false)
            {
                dynamic = 0;
                IncreaseDynamics(newCost);
                dynamicsDirection = true;
            }
            else if (newCost < cost && dynamicsDirection == false)
            {
                reduceDynamics(newCost);
            }
            else if (newCost < cost && dynamicsDirection == true)
            {
                dynamic = 0;
                reduceDynamics(newCost);
                dynamicsDirection = false;
            }
        }

        // метод увеличения динамики цены
        void IncreaseDynamics(int newCost)
        {
            dynamic += newCost - cost;
        }

        // метод уменьшения динамики цены
        void reduceDynamics(int newCost)
        {
            dynamic += newCost - cost;
        }
    }
}
