using AutoMapper;
using KareAjansi.BLL.AbstractServices;
using KareAjansi.BLL.DTOs;
using KareAjansi.Common;
using KareAjansi.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KareAjansi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MankenlerController : ControllerBase
    {
        private readonly IMankenService _mankenService;
        private readonly IMapper _mapper;

        public MankenlerController(IMankenService mankenService, IMapper mapper)
        {
            _mankenService = mankenService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("getallmankenler")]
        public IActionResult GetAllMankenler()
        {
            var mankenler = _mankenService.GetAll();
            var mankenDTOs = _mapper.Map<IEnumerable<MankenDTO>>(mankenler);
            return Ok(mankenDTOs.ToList());
        }

        [HttpGet]
        [Route("getmanken/{id}")]
        public IActionResult GetManken(int id)
        {
            var manken = _mankenService.GetById(id);

            if (manken == null)
            {
                return NotFound();
            }

            var mankenDTO = _mapper.Map<MankenDTO>(manken);
            return Ok(mankenDTO);
        }

        [HttpPost]
        [Route("addmanken")]
        public IActionResult AddManken([FromBody] MankenDTO mankenDTO )
        {
            if (mankenDTO == null)
            {
                return BadRequest("Manken bilgileri boş olamaz");
            }

            try
            {
                var mankenEntity = _mapper.Map<Manken>(mankenDTO);
                _mankenService.Create(mankenEntity);
                return Ok("Manken Başarıyla Eklendi");
            }
            catch (Exception ex)
            {
                return BadRequest($"Manken eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("deletemanken/{id}")]
        public IActionResult DeleteManken(int id)
        {
            var deletedManken = _mankenService.Delete(id);

            if (deletedManken == null)
            {
                return NotFound();
            }

            return Ok(deletedManken);
        }

        [HttpPut]
        [Route("updatemanken")]
        public IActionResult UpdateManken([FromBody] MankenDTO updatedMankenDTO)
        {
            if (updatedMankenDTO == null)
            {
                return BadRequest("Güncellenecek manken bilgileri boş olamaz");
            }

            try
            {
                var updatedMankenEntity = _mapper.Map<Manken>(updatedMankenDTO);
                var updateMankenResult = _mankenService.Update(updatedMankenEntity);

                if (updateMankenResult != null)
                {
                    return Ok(updateMankenResult);
                }
                else
                {
                    return NotFound("Belirtilen ID'ye sahip manken bulunamadı veya güncelleme başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Manken güncellenirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}