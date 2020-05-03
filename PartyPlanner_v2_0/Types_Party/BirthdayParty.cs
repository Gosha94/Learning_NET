using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner_v2_0.Types_Party
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecoraions { get; set; }

        public string CakeWriting { get; set; }
        // Для инициализации объекта BirthdayParty необходимы данные о количестве гостей, 
        // виде оформления 
        // и надписи на торте. 
        // В этом случае стоимость будет правильно рассчитана.
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            /* Конструктор задает состояние объектов, определяя свойства таким образом, 
            чтобы впоследствии можно было рассчитать стоимость. */

            NumberOfPeople = numberOfPeople;
            FancyDecoraions = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        // Метод расчета кол-ва букв на торте, которое уместится на торт текущего диаметра
        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }
        
        // Метод расчета диаметра торта в зависимости от кол-ва гостей
        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }

        // Метод расчета макс кол-ва букв, помещающихся на торт определенного диаметра
        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }

        /* Cвойство для определения помещается ли надпись на торт, обладает только методом чтения, но не меняет состояние объекта. 
        Оно всего лишь использует поля и методы для вычисления логического значения.*/
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }
        
        // Метод расчета стоимости особого оформления
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecoraions)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;
        }

        // Метод расчета общей стоимости торжества
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                if (NumberOfPeople > 12) totalCost += (CostOfFoodPerPerson * NumberOfPeople) + 100M;
                else totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8) cakeCost = 40M + ActualLength * .25M;
                else cakeCost = 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }

    }
}
