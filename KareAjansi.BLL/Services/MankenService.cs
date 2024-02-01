using KareAjansi.BLL.AbstractRepositories;
using KareAjansi.BLL.AbstractServices;
using KareAjansi.BLL.DTOs;
using KareAjansi.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.BLL.Services
{
    public class MankenService : IMankenService
    {
        private readonly IRepository<Manken> _mankenRepository;

        public MankenService(IRepository<Manken> mankenRepository)
        {
            _mankenRepository = mankenRepository;
        }

        public string Create(Manken entity)
        {
           return _mankenRepository.Create(entity);
        }

        public string Delete(int id)
        {
            return _mankenRepository.Delete(id);
        }

        public IEnumerable<Manken> GetAll()
        {
            return _mankenRepository.GetAll();
        }

        public Manken GetById(int id)
        {
            return _mankenRepository.GetById(id);
        }

        public string Update(Manken entity)
        {
            return _mankenRepository.Update(entity);  
        }
    }
}