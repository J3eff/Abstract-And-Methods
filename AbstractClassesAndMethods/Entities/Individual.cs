
namespace AbstractClassesAndMethods.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (AnualIncome < 20000.00)
            {
                tax = (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else
            {
                tax = (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }

            return tax;
        }

    }
}
