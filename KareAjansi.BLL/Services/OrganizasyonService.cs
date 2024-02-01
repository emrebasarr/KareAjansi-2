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
    public class OrganizasyonService : IOrganizasyonService
    {
        private readonly IRepository<Organizasyon> _organizasyonRepository;

        public OrganizasyonService(IRepository<Organizasyon> organizasyonRepository)
        {
            _organizasyonRepository = organizasyonRepository;
        }

        public  string Create(Organizasyon entity)
        {
           return _organizasyonRepository.Create(entity);
        }

        public string Delete(int id)
        {
            return _organizasyonRepository.Delete(id);
        }

        public IEnumerable<Organizasyon> GetAll()
        {
            return _organizasyonRepository.GetAll();
        }

        public Organizasyon GetById(int id)
        {
            return _organizasyonRepository.GetById(id);
        }

        public string Update(Organizasyon entity)
        {
            return _organizasyonRepository.Update(entity);
        }
    }
}