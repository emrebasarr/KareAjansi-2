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
    public class OrganizasyonMankenService : IOrganizasyonMankenService
    {
        private readonly IRepository<OrganizasyonManken> _organizasyonMankenRepository;

        public OrganizasyonMankenService(IRepository<OrganizasyonManken> organizasyoMankennRepository)
        {
            _organizasyonMankenRepository = organizasyoMankennRepository;
        }

        public string Create(OrganizasyonManken entity)
        {
           return _organizasyonMankenRepository.Create(entity);
        }

        public string Delete(int id)
        {
            return _organizasyonMankenRepository.Delete(id);
        }

        public IEnumerable<OrganizasyonManken> GetAll()
        {
            return _organizasyonMankenRepository.GetAll();
        }

        public OrganizasyonManken GetById(int id)
        {
            return _organizasyonMankenRepository.GetById(id);
        }

        public string Update(OrganizasyonManken entity)
        {
            return _organizasyonMankenRepository.Update(entity);
        }
    }
}