namespace Party_Planner
{
    class BirthdayParty : Party
    {
        public string CakeWriting { get; set; }
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
        public bool CakeWritingTooLong { get { return CakeWriting.Length > MaxWritingLength(); } }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost = CakeSize() == 8 ?
                    40M + ActualLength * .25M :
                    75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
            : base(numberOfPeople, fancyDecorations)
        {
            CakeWriting = cakeWriting;
        }
        private int CakeSize()
        {
            return NumberOfPeople <= 4 ? 8 : 16;
        }

        private int MaxWritingLength()
        {
            return CakeSize() == 8 ? 16 : 40;
        }
    }
}
