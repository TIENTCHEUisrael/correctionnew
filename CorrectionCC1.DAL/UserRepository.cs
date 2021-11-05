using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrectionCC.BO;

namespace CorrectionCC1.DAL
{
    public class UserRepository:BaseRepository<User>
    {
        public UserRepository()
        {

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
                if (data.Fullname.ToLower().Contains(email.ToLower()))
                    list.Add(data);
            }
            return new List<User>(list);
        }
    }
}
