using PartyPlanner_v3.Types_Party;

namespace PartyPlanner_v2_0.Types_Party
{
    class BirthdayParty : Party
    {
        // Для инициализации объекта BirthdayParty необходимы данные о количестве гостей, 
        // виде оформления 
        // и надписи на торте. 
        // В этом случае стоимость будет правильно рассчитана.
        
        // Конструктор
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            /* Конструктор задает состояние объектов, определяя свойства таким образом, 
            чтобы впоследствии можно было рассчитать стоимость. */
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        public string CakeWriting { get; set; }
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
        // Метод расчета общей стоимости торжества
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;                
                if (CakeSize() == 8) cakeCost = 40M + ActualLength * .25M;
                else cakeCost = 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
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
    }
}
