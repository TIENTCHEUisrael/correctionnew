using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrectionCC.BO;

namespace CorrectionCC1.DAL
{
    public class UserRepository:BaseRepository<User>
    {
        public UserRepository():base()
        {
            FileInfo fileinfo = new FileInfo(Path);
            if(!fileinfo.Exists || fileinfo.Length==0)
            {
                User user = new User("admin@gmail.com", "admin", "administrator");
                Add(user);
            }

        }
        public List<User> FindByPassword(string password)
        {
            List<User> list = new List<User>();
            foreach (var data in datas)
            {
                if (data.Password.ToLower().Contains(password.ToLower()))
                    list.Add(data);
            }
            return new List<User>(list);
        }
        public List<User> FindByName(string name)
        {
            List<User> list = new List<User>();
            foreach(var data in datas)
            {
                if (data.Fullname.ToLower().Contains(name.ToLower()))
                   list.Add(data);
            }
            return new List<User>(list);
        }
        public List<User> FindByEmail(string email)
        {
            List<User> list = new List<User>();
            foreach (var data in datas)
            {
                if (data.Email.ToLower().Contains(email.ToLower()))
                    list.Add(data);
            }
            return new List<User>(list);
        }
    }
}
