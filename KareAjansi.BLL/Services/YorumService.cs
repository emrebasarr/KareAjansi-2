using KareAjansi.BLL.AbstractRepositories;
using KareAjansi.BLL.AbstractServices;
using KareAjansi.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.BLL.Services
{
    public class YorumService : IYorumService
    {
        private readonly IRepository<Yorum> _repository;

        public YorumService(IRepository<Yorum> repository) 
        {
            _repository = repository;
        }

        public string Create(Yorum entity)
        {
            return _repository.Create(entity);
        }

        public string Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Yorum> GetAll()
        {
            return _repository.GetAll();
        }

        public Yorum GetById(int id)
        {
            return _repository.GetById(id);
        }

        public string Update(Yorum entity)
        {
            return _repository.Update(entity);
        }
    }
}