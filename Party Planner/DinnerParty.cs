namespace Party_Planner
{
    public class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal Cost
        {
            get
            {
                decimal cost =
                    CalculateCostOfDecorations() +
                    (CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople;
                if (HealthyOption) cost *= .95m;
                return cost;
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfDecorations()
        {
            return FancyDecorations ?
                15m * NumberOfPeople + 50m :
                7.50m * NumberOfPeople + 30m;
        }
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return HealthyOption ? 5.00m : 20.00m;
        }
    }
}
