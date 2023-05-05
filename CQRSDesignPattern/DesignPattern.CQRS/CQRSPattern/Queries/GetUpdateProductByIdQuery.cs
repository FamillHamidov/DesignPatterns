namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetUpdateProductByIdQuery
    {
        public int Id { get; set; }

        public GetUpdateProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
