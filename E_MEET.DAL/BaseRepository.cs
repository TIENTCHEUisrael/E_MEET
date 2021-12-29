using Library.Serialisation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MEET.DAL
{
    public class BaseRepository<T>
    {
        protected readonly string Path = $"JSON/{typeof(T).Name}.json";
        protected List<T> Datas;
        private Serializer<List<T>> Serialiser;
        public BaseRepository()
        {
            Datas = new List<T>();
            FileInfo fi = new FileInfo(Path);
            if (!fi.Directory.Exists)
                fi.Directory.Create();
            Serialiser = new Serializer<List<T>>(Serializer<List<T>>.Mode.JSON, Path);
            Restore();
        }
        /// <summary>       
        /// permet de recuperer un index ou un indice sur un certain element 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Check(T obj)
        {
            var index = -1;
            for (int i = 0; i < Datas.Count; i++)
            {
                if (obj.Equals(Datas[i]))
                    index = i;
            }
            return index;
        }
        /// <summary>
        ///  methode Add pour ajouter un utilisateur
        /// </summary>
        /// <param name="obj"></param>
        public void Add(T obj)
        {
            int index = Check(obj);
            if (index != -1)
                throw new DuplicateWaitObjectException($"{typeof(T).Name} already exists !");
            Datas.Add(obj);
            Save();
        }
        /// <summary>
        ///  methode Set pour modifier
        /// </summary>
        /// <param name="oldObj"></param>
        /// <param name="newObj"></param>
        public void Set(T oldObj, T newObj)
        {
            int oldIndex = Check(oldObj);
            if (oldIndex < 0)
                throw new KeyNotFoundException($"{typeof(T).Name} not found");
            var newIndex = Check(newObj);
            if (newIndex >= 0 && newIndex != oldIndex)
                throw new KeyNotFoundException($"{typeof(T).Name} already exists !");
            Datas[oldIndex] = newObj;
            Save();
        }

        /// <summary>
        /// Supprimer un User
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(T obj)
        {
            var index = Check(obj);
            if (index == 0)
            {
                Datas.RemoveAt(index);
            }
            Save();
        }
        /// <summary>
        /// ...Pour recuperer toute la liste des utilisateurs ou produit..
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            Restore();
            T[] items = new T[Datas.Count];
            Datas.CopyTo(items);
            return items.ToList<T>();
        }
        /// <summary>
        /// Methode Save pour enregistrer ou serialiser le fichier.
        /// </summary>
        public void Save()
        {
            Serialiser.Serialize(Datas);
        }
        /// <summary>
        /// Restore et la deserialisation...
        /// </summary>
        public void Restore()
        {
            FileInfo fi = new FileInfo(Path);
            if (fi.Exists && fi.Length > 0)
                Datas = Serialiser.Deserialize();
        }
    }
}
