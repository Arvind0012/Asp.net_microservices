using Product.Microservice.Models;

namespace Product.Microservice.DataAccess.Interface
{
    public interface IProductRepository
    {
        public Prod addProduct(Prod prod);
        public List<Prod> getAllProduct();
    }
}
