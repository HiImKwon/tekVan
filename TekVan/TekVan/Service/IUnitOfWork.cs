namespace TekVan.Service
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; set; }
        IProductRepository Products { get; set; }
    }
}