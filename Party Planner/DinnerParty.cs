namespace Party_Planner
{
    public class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }
        override public decimal Cost
        {
            get
            {
                decimal cost = base.Cost + CalculateCostOfBeveragesPerPerson() * NumberOfPeople;
                if (HealthyOption) cost *= .95m;
                return cost;
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
            : base(numberOfPeople, fancyDecorations)
        {
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return HealthyOption ? 5.00m : 20.00m;
        }
    }
}
