using System.Reflection.Metadata.Ecma335;

namespace DesignPattern.Observer.DAL
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountAmount { get; set; }
        public bool Status { get; set; }
    }
}
