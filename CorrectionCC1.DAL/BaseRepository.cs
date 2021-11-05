using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Serialisation;

namespace CorrectionCC1.DAL
{
    public class BaseRepository<T>
    {
        private readonly string Path= $"Data/{typeof(T).Name}.json";
        protected List<T> datas;
        private Serialiser<List<T>> serialiser;
        public BaseRepository()
        {
            datas = new List<T>();            
            FileInfo fi = new FileInfo(Path);
            if (!fi.Directory.Exists)
                fi.Directory.Create();
            serialiser = new Serialiser<List<T>>(Mode.JSON, Path);

            Restore();
        }
        public int Check(T obj)
        {
            var index = -1;
            for (int i = 0; i < datas.Count; i++)
            {
                if (obj.Equals(datas[i]))
                    index = i;
            }
            return index;
        }
        // methode Add pour ajouter un utilisateur ou un produit
        public void Add(T obj)
        {
            int index = Check(obj);
            if (index != 1)
                throw new DuplicateWaitObjectException($"{typeof(T).Name} already exists !");
            datas.Add(obj);
            Save();
        }
        // methode Set pour modifier
        public void Set(T oldObj, T newObj)
        {
            int oldIndex = Check(oldObj);
            if (oldIndex < 0)
                throw new KeyNotFoundException($"{typeof(T).Name} not found");
            var newIndex = Check(newObj);
            if (newIndex >= 0 && newIndex != oldIndex)
                throw new KeyNotFoundException($"{typeof(T).Name} already exist !");
            datas[oldIndex] = newObj;
        }

        // Supprimer  un user
        public void Delete(T obj)
        {
            var index = Check(obj);
            if(index==0)
            {
                datas.RemoveAt(index);
            }
            Save();
        }
        //...Pour recuperer toute la liste des utilisateurs ou produit..
        public List<T> GetAll()
        {
            Restore();
            T[] items = new T[datas.Count];
            datas.CopyTo(items);
            return items.ToList<T>();
        }
        //Methode Save pour enregistrer ou serialiser le fichier.
        public void Save()
        {
            serialiser.Serialize(datas);
        }
        // Restore et la deserialisation...
        public void Restore()
        {
            FileInfo fi = new FileInfo(Path);
            if (fi.Exists && fi.Length > 0)
                datas = serialiser.Deserialize();
        }
    }
}