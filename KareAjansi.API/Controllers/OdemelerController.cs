using AutoMapper;
using KareAjansi.BLL.AbstractServices;
using KareAjansi.BLL.DTOs;
using KareAjansi.BLL.Services;
using KareAjansi.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace KareAjansi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OdemelerController : ControllerBase
    {
        private readonly IOdemeService _odemeService;
        private readonly IMapper _mapper;

        public OdemelerController(IOdemeService odemeService, IMapper mapper)
        {
            _odemeService = odemeService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("getallodemeler")]
        public IActionResult GetAllOdemeler()
        {
            var odemeler = _odemeService.GetAll();
            var odemeDTOs = _mapper.Map<IEnumerable<OdemeDTO>>(odemeler);
            return Ok(odemeDTOs.ToList());
        }

        [HttpGet]
        [Route("getodeme/{id}")]
        public IActionResult GetOdeme(int id)
        {
            var odeme = _odemeService.GetById(id);

            if (odeme == null)
            {
                return NotFound();
            }

            var odemeDTO = _mapper.Map<OdemeDTO>(odeme);
            return Ok(odemeDTO);
        }

        [HttpGet]
        [Route("exporttxt")]
        public IActionResult ExportTxt()
        {
            try
            {
                var odemeler = _odemeService.GetAll();
                using (StreamWriter sw = new StreamWriter("OdemeListesi.txt", false, Encoding.UTF8))
                {
                    sw.WriteLine("Ödeme Listesi");
                    foreach (var odeme in odemeler)
                    {
                        sw.WriteLine($"{odeme.Id}\t{odeme.MankenAdi}\t{odeme.MankenId}\t{odeme.KategoriId}\t{odeme.OrganizasyonId}\t{odeme.KonaklamaUcreti}\t{odeme.YemekUcreti}\t{odeme.Odenecek}\t{odeme.Harcama}\t{odeme.Toplam}\t{odeme.Kar}");
                    }
                }
                return Ok("OdemeListesi.txt dosyası oluşturuldu.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Dosya oluşturulurken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("addodeme")]
        public IActionResult AddOdeme([FromBody] OdemeDTO odemeDTO)
        {
            if (odemeDTO == null)
            {
                return BadRequest("Odeme bilgileri boş olamaz");
            }

            try
            {       
                var odemeEntity = _mapper.Map<Odeme>(odemeDTO);
                _odemeService.Create(odemeEntity);
                return Ok("Odeme Başarıyla Eklendi");
            }
            catch (Exception ex)
            {
                return BadRequest($"Odeme eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("deleteodeme/{id}")]
        public IActionResult DeleteOdeme(int id)
        {
            var deletedOdeme = _odemeService.Delete(id);

            if (deletedOdeme == null)
            {
                return NotFound();
            }

            return Ok(deletedOdeme);
        }

        [HttpPut]
        [Route("updateodeme")]
        public IActionResult UpdateOdeme([FromBody] OdemeDTO updatedOdemeDTO)
        {
            if (updatedOdemeDTO == null)
            {
                return BadRequest("Güncellenecek odeme bilgileri boş olamaz");
            }

            try
            {
                var updatedOdemeEntity = _mapper.Map<Odeme>(updatedOdemeDTO);
                var updateOdemeResult = _odemeService.Update(updatedOdemeEntity);

                if (updateOdemeResult != null)
                {
                    return Ok(updateOdemeResult);
                }
                else
                {
                    return NotFound("Belirtilen ID'ye sahip odeme bulunamadı veya güncelleme başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Odeme güncellenirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}