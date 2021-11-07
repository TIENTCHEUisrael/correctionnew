using CorrectionCC.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCC1.DAL
{
    public class Productrepository : BaseRepository<Product>
    {
        
        public Productrepository()
        {

        }
        public List<Product> FindByName(string reference)
        {
            List<Product> list = new List<Product>();
            foreach (var data in datas)
            {
                if (data.Reference.ToLower().Contains(reference.ToLower()))
                    list.Add(data);
            }
            return new List<Product>(list);
        }
    }
}
