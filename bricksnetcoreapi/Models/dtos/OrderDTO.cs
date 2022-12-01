namespace bricksnetcoreapi.Models.dtos
{
    public class OrderDTO
    {
        public int OrderId { get; set; }

        public int? OrderCode { get; set; }

        public int? Qty { get; set; }

        public double? Rate { get; set; }

        public double? Total { get; set; }

        public string? Status { get; set; }

        public int? CustomerId { get; set; }
    }
}
