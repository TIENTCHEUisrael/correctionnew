using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mylibrary.serialisation;

namespace CorrectionCC.BO
{
    public class User
    {
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public List<Product> products;
       
        public User()
        {
            products = new List<Product>();
        }
        public User(string Email,string Fullname, string Password):this()
        {
            this.Email = Email;
            this.Fullname = Fullname;
            this.Password = Password;            

        }
        public User(User user):this(user?.Email,user?.Fullname, user?.Password)
        {

        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void DeleteProduct(Product product)
        {
            products.Remove(product);
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Email == user.Email;
        }

        public override int GetHashCode()
        {
            return -506688385 + EqualityComparer<string>.Default.GetHashCode(Email);
        }
    }
}
