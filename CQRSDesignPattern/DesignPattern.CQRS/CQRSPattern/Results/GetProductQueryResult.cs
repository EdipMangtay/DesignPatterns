namespace DesignPattern.CQRS.CQRSPattern.Results
{
    public class GetProductQueryResult
    {
        public int ID { get; set; }
        public string ProductName { get; set; } // buradaki isimle entitydeki isim aynı olmak zorunda değil
        public int Stock { get; set; }      //burası çıktının karşılığını tutuyor 
        public decimal Price { get; set; }
    }
}
