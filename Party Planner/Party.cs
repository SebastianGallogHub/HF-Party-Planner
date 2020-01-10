namespace Party_Planner
{
    public class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        virtual public decimal Cost
        {
            get
            {
                decimal cost = CalculateCostOfDecorations() + CostOfFoodPerPerson * NumberOfPeople;
                if (NumberOfPeople > 12)
                    cost += 100;
                return cost;
            }
        }

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfDecorations()
        {
            return FancyDecorations ?
                15m * NumberOfPeople + 50m :
                7.50m * NumberOfPeople + 30m;
        }
    }
}
