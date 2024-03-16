namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIDQuery
    {
        public int Id { get; set; } // buraya yapıcı dönmem lazım 

        public GetProductByIDQuery(int id)
        {
            Id = id;
        }
    }
}
