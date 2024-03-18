namespace DesignPattern.TemplateMerhod.TemplatePattern
{
    public class BasicPlan : NetflixPlans
    {
        public override string Content(string Content)
        {
            return Content;
        }

        public override int CountPerson(int countPerson)
        {
            return countPerson;

        }

        public override string PlanType(string PlanType)
        {
            return PlanType;
        }

        public override double Price(double Price)
        {
            return Price;
        }

        public override string ReSolution(string ReSolution)
        {
            return ReSolution;
        }
    }
}
