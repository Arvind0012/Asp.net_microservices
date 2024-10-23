using Product.Microservice.DataAccess.Interface;
using Product.Microservice.Models;

namespace Product.Microservice.DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext productDbContext)
        {
            _context = productDbContext;
        }
        public Prod addProduct(Prod prod)
        {
            try
            {
                var product = new Prod
                {
                    Id = prod.Id,
                    Name = prod.Name,
                    Description = prod.Description,
                    Price = prod.Price,
                    Stock = prod.Stock,
                };
                _context.Products.Add(product);
                _context.SaveChanges();
                return prod;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public List<Prod> getAllProduct()
        {
            try
            {
                var products = (from prod in _context.Products select prod).ToList();
                return products;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
