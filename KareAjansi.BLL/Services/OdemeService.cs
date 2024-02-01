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
    public class OdemeService : IOdemeService
    {
        private readonly IRepository<Odeme> _odemeRepository;

        public OdemeService(IRepository<Odeme> odemeRepository)
        {
            _odemeRepository = odemeRepository;
        }

        public string Create(Odeme entity)
        {
            if (entity.KategoriId == 3)
            {
                entity.Odenecek = (int)(entity.SirkettenAlinacakUcret * 0.20) / entity.MankenSayisi;
            }
            else if (entity.KategoriId == 2)
            {
                entity.Odenecek = entity.GunSayisi * 100;

            }
            else if (entity.KategoriId == 1)
            {
                entity.Odenecek = entity.GunSayisi * 40;
            }

            entity.Harcama = entity.GunSayisi * entity.YemekUcreti;
            entity.Toplam = entity.Odenecek + entity.Harcama;
            entity.Kar = entity.SirkettenAlinacakUcret - entity.Toplam ;

            return _odemeRepository.Create(entity);
        }

        public string Delete(int id)
        {
            return _odemeRepository.Delete(id);
        }

        public IEnumerable<Odeme> GetAll()
        {
            return _odemeRepository.GetAll();
        }

        public Odeme GetById(int id)
        {
            return _odemeRepository.GetById(id);
        }

       
        public string Update(Odeme entity)
        {
            return _odemeRepository.Update(entity);
        }
    }
}