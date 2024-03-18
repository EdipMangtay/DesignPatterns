namespace DesignPattern.TemplateMerhod.TemplatePattern
{
    public abstract class NetflixPlans
    {
        public void CreatePlan()
        {
            PlanType(string.Empty);
            CountPerson(0);
            Price(0);
            ReSolution(string.Empty);
            Content(string.Empty);

        }
        public abstract string PlanType(string PlanType);
        public abstract int CountPerson(int countPerson);

        public abstract double Price(double Price);
        public abstract string ReSolution(string ReSolution);
        public abstract string Content(string Content);







    }
}
