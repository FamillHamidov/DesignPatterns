namespace DesignPattern.CQRS.CQRSPattern.Commands
{
    public class UpdateProductCommand
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}
