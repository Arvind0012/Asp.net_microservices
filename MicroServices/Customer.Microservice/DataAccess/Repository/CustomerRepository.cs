using Customer.Microservice.DataAccess.Interface;
using Customer.Microservice.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Customer.Microservice.DataAccess.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext _context;

        public CustomerRepository(CustomerDbContext customerDbContext)
        {
            _context = customerDbContext;
        }
        public User addUser(User user)
        {
            try
            {
                var customer = new User 
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                    City = user.City,
                    Password = user.Password,
                };
                _context.Users.Add(customer);
                _context.SaveChanges();
                return customer;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public List<User> getAllUsers()
        {
            try
            {
                var users = (from user in _context.Users select user);
                return users.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
