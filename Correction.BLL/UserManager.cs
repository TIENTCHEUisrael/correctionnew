using CorrectionCC.BO;
using CorrectionCC1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correction.BLL
{
    public class UserManager
    {
        private UserRepository userRepository;
        private Productrepository productrepository;
        public UserManager()
        {
            userRepository = new UserRepository();
            productrepository = new Productrepository();
        }
        public void EditUser(User oldUser,User newUser)
        {
            userRepository.Set(oldUser, newUser);
        }
        public void AddUser(User user)
        {
            userRepository.Add(user);
        }
        public void DeleteUSer(User user)
        {
            userRepository.Delete(user);
        }
        public User Authenticate(string email, string password)
        {
            var users= userRepository.FindByEmail(email);
            foreach (var u in users)
                if (u.Email == email && u.Password == password)
                    return u;
            return null;
        }
        public List<User> GetAllUSer()
        {
            return userRepository.GetAll();
        }
        public List<Product> GetAllProduct()
        {
            return productrepository.GetAll();
        }

        public void AddUserProduct(User user,Product product)
        {
            if (userRepository.Check(user) < 0)
                throw new KeyNotFoundException($"{nameof(User)} not found");
            user.AddProduct(product);
            userRepository.Set(user, user);
        }
        public void RemoveUserProduct(User user, Product product)
        {
            if (userRepository.Check(user) < 0)
                throw new KeyNotFoundException($"{nameof(User)} not found");
            user.DeleteProduct(product);
            userRepository.Set(user, user);
        }

    }
}
