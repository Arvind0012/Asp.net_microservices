using Customer.Microservice.Models;

namespace Customer.Microservice.DataAccess.Interface
{
    public interface ICustomerRepository
    {
        public User addUser(User user);
        public List<User> getAllUsers();
    }
}
