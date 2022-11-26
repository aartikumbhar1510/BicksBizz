namespace bricksnetcoreapi.Model
{
    public class CustomerOrder
    {
        public int Id { get; set; }
        public string? OrderId { get; set; }
        public string? CustomerName { get; set; }
        public string? MobileNo { get; set; }
        public string? Address { get; set; }
        public int? Qty { get; set; }
        public int? Rate { get; set; }
        public int? Total { get; set; }
        public string? Status { get; set; }

    }
}
