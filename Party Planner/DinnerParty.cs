using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    public class DinnerParty
    {
        public int NumberOfPeople;
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
                15M * NumberOfPeople + 50M :
                7.50M * NumberOfPeople + 30M;
        }
        public decimal CalculateCost(bool Healthy)
        {
            decimal cost =
                CostOfDecorations +
                (CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople;
            return Healthy ?
                cost * 0.95M :
                cost;
        }
    }
}
