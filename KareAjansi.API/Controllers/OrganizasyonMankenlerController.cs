using AutoMapper;
using KareAjansi.BLL.AbstractServices;
using KareAjansi.BLL.DTOs;
using KareAjansi.BLL.Services;
using KareAjansi.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KareAjansi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizasyonMankenlerController : ControllerBase
    {
        private readonly IOrganizasyonMankenService _organizasyonMankenService;
        private readonly IMapper _mapper;

        public OrganizasyonMankenlerController(IOrganizasyonMankenService organizasyonMankenService, IMapper mapper)
        {
            _organizasyonMankenService = organizasyonMankenService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("getallorganizasyonmankenler")]
        public IActionResult GetAllOrganizasyonMankenler()
        {
            var organizasyonMankenler = _organizasyonMankenService.GetAll();
            var organizasyonMankenDTOs = _mapper.Map<IEnumerable<OrganizasyonMankenDTO>>(organizasyonMankenler);
            return Ok(organizasyonMankenDTOs.ToList());
        }

        [HttpGet]
        [Route("getorganizasyonmanken/{id}")]
        public IActionResult GetOrganizasyonManken(int id)
        {
            var organizasyonManken = _organizasyonMankenService.GetById(id);

            if (organizasyonManken == null)
            {
                return NotFound();
            }

            var organizasyonMankenDTO = _mapper.Map<OrganizasyonMankenDTO>(organizasyonManken);
            return Ok(organizasyonMankenDTO);
        }

        [HttpPost]
        [Route("addorganizasyonmanken")]
        public IActionResult AddOrganizasyonManken([FromBody] OrganizasyonMankenDTO organizasyonMankenlerDTO)
        {
            if (organizasyonMankenlerDTO == null)
            {
                return BadRequest("OrganizasyonManken bilgileri boş olamaz");
            }

            try
            {
                var organizasyonMankenEntity = _mapper.Map<OrganizasyonManken>(organizasyonMankenlerDTO);
                _organizasyonMankenService.Create(organizasyonMankenEntity);
                return Ok("OrganizasyonManken Başarıyla Eklendi");
            }
            catch (Exception ex)
            {
                return BadRequest($"OrganizasyonManken eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("deletorganizasyonmanken/{id}")]
        public IActionResult DeleteOrganizasyonManken(int id)
        {
            var deletedOrganizasyonManken = _organizasyonMankenService.Delete(id);

            if (deletedOrganizasyonManken == null)
            {
                return NotFound();
            }

            return Ok(deletedOrganizasyonManken);
        }



        [HttpPut]
        [Route("updateorganizasyonmanken")]
        public IActionResult UpdateOrganizasyonManken([FromBody] OrganizasyonMankenDTO updatedOrganizasyonMankenDTO)
        {
            if (updatedOrganizasyonMankenDTO == null)
            {
                return BadRequest("Güncellenecek manken bilgileri boş olamaz");
            }

            try
            {
                var updatedOrganizasyonMankenEntity = _mapper.Map<OrganizasyonManken>(updatedOrganizasyonMankenDTO);
                var updateOrganizasyonMankenResult = _organizasyonMankenService.Update(updatedOrganizasyonMankenEntity);

                if (updateOrganizasyonMankenResult != null)
                {
                    return Ok(updateOrganizasyonMankenResult);
                }
                else
                {
                    return NotFound("Belirtilen ID'ye sahip organizasyonmanken bulunamadı veya güncelleme başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"OrganizasyonManken güncellenirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}