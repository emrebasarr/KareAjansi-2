using KareAjansi.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.BLL.AbstractRepositories
{
    public interface IRepository<T> where T : BaseClass
    {
        //List
        IEnumerable<T> GetAll();

        //Create
        string Create(T entity);

        //Update
        string Update(T entity);

        //Delete
        string Delete(int id);

        //Get
        T GetById(int id);
    }
}