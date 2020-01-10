using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    public class DinnerParty
    {
        private int numberOfPeople;
        public int NumberOfPeople { get { return numberOfPeople; } }
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;
        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool Healthy)
        {
            CostOfBeveragesPerPerson = Healthy ?
                5.0M :
                20.0M;
        }
        public void CalculateCostOfDecorations(bool Fancy)
        {
            CostOfDecorations = Fancy ?
                15M * numberOfPeople + 50M :
                7.50M * numberOfPeople + 30M;
        }
        public decimal CalculateCost(bool Healthy)
        {
            decimal cost =
                CostOfDecorations +
                (CostOfBeveragesPerPerson + CostOfFoodPerPerson) * numberOfPeople;
            return Healthy ?
                cost * 0.95M :
                cost;
        }
        public void SetPartyOptions(int people, bool fancy)
        {
            numberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }
    }
}
