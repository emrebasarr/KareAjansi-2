using KareAjansi.BLL.AbstractRepositories;
using KareAjansi.DAL.Context;
using KareAjansi.Entity.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.BLL.Concretes
{
    public class BaseRepository<T> : IRepository<T> where T : BaseClass
    {
        private readonly KareAjansiContext _kareAjansiContext;
        private DbSet<T> _entities;

        public BaseRepository(KareAjansiContext kareAjansiContext)
        {
            _kareAjansiContext = kareAjansiContext;
            _entities = kareAjansiContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.Where(x => x.Status == Entity.Enums.DataStatus.Active || x.Status == Entity.Enums.DataStatus.Updated ).ToList();
        }

        public string Create(T entity)
        {
            try
            {
                entity.Status = Entity.Enums.DataStatus.Active;
                _entities.Add(entity);
                _kareAjansiContext.SaveChanges();
                return "Veri Kaydedildi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(T entity)
        {
            try
            {
                _entities.Entry(entity).State = EntityState.Modified;
                _kareAjansiContext.SaveChanges();
                return "Veri Güncellendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                var entity = GetById(id);
                if (entity != null)
                {
                    entity.Status = Entity.Enums.DataStatus.Deleted;
                    Update(entity);
                    return "Veri Silindi!";
                }
                else
                {
                    return "Silinecek Veri Bulunamadı!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public T GetById(int id)
        {
            return _entities.Find(id);
        }
    }
}