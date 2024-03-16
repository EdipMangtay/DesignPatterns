namespace DesignPattern.CQRS.CQRSPattern.Command
{
    public class RemoveProductCommand
    {
        public RemoveProductCommand(int id)
        {
            Id = id;

        }
        public int Id { get; set; }

    }
}
