using AutoMapper;
using KareAjansi.BLL.AbstractServices;
using KareAjansi.BLL.DTOs;
using KareAjansi.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KareAjansi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizasyonlarController : ControllerBase
    {
        private readonly IOrganizasyonService _organizasyonService;
        private readonly IMapper _mapper;

        public OrganizasyonlarController(IOrganizasyonService organizasyonService, IMapper mapper)
        {
            _organizasyonService = organizasyonService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("getallorganizasyonlar")]
        public IActionResult GetAllOrganizasyonlar()
        {
            var organizasyonlar = _organizasyonService.GetAll();
            var organizasyonDTOs = _mapper.Map<IEnumerable<OrganizasyonDTO>>(organizasyonlar);
            return Ok(organizasyonDTOs.ToList());
        }

        [HttpGet]
        [Route("getorganizasyon/{id}")]
        public IActionResult GetOrganizasyon(int id)
        {
            var organizasyon = _organizasyonService.GetById(id);

            if (organizasyon == null)
            {
                return NotFound();
            }

            var organizasyonDTO = _mapper.Map<OrganizasyonDTO>(organizasyon);
            return Ok(organizasyonDTO);
        }

        [HttpPost]
        [Route("addorganizasyon")]
        public IActionResult AddOrganizasyon([FromBody] OrganizasyonDTO organizasyonDTO)
        {
            if (organizasyonDTO == null)
            {
                return BadRequest("Organizasyon bilgileri boş olamaz");
            }

            try
            {
                var organizasyonEntity = _mapper.Map<Organizasyon>(organizasyonDTO);
                _organizasyonService.Create(organizasyonEntity);
                return Ok("Organizasyon Başarıyla Eklendi");
            }
            catch (Exception ex)
            {
                return BadRequest($"Organizasyon eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("deletorganizasyon/{id}")]
        public IActionResult DeleteOrganizasyon(int id)
        {
            var deletedOrganizasyon = _organizasyonService.Delete(id);

            if (deletedOrganizasyon == null)
            {
                return NotFound();
            }

            return Ok(deletedOrganizasyon);
        }

        [HttpPut]
        [Route("updateorganizasyon")]
        public IActionResult UpdateOrganizasyon([FromBody] OrganizasyonDTO updatedOrganizasyonDTO)
        {
            if (updatedOrganizasyonDTO == null)
            {
                return BadRequest("Güncellenecek organizasyon bilgileri boş olamaz");
            }

            try
            {
                var updatedOrganizasyonEntity = _mapper.Map<Organizasyon>(updatedOrganizasyonDTO);
                var updateOrganizasyonResult = _organizasyonService.Update(updatedOrganizasyonEntity);

                if (updateOrganizasyonResult != null)
                {
                    return Ok(updateOrganizasyonResult);
                }
                else
                {
                    return NotFound("Belirtilen ID'ye sahip organizasyon bulunamadı veya güncelleme başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Organizasyon güncellenirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}