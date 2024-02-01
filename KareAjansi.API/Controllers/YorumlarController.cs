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
    public class YorumlarController : ControllerBase
    {
        private readonly IYorumService _yorumService;
        private readonly IMapper _mapper;

        public YorumlarController(IYorumService yorumService, IMapper mapper)
        {
            _yorumService = yorumService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("getallyorumlar")]
        public IActionResult GetAllYorumlar()
        {
            var yorumlar = _yorumService.GetAll();
            var yorumDTOs = _mapper.Map<IEnumerable<YorumDTO>>(yorumlar);
            return Ok(yorumDTOs.ToList());
        }

        [HttpGet]
        [Route("getyorum/{id}")]
        public IActionResult GetManken(int id)
        {
            var yorum = _yorumService.GetById(id);

            if (yorum == null)
            {
                return NotFound();
            }

            var yorumDTO = _mapper.Map<YorumDTO>(yorum);
            return Ok(yorumDTO);
        }

        [HttpPost]
        [Route("addyorum")]
        public IActionResult AddYorum([FromBody] YorumDTO yorumDTO)
        {
            if (yorumDTO == null)
            {
                return BadRequest("Yorum bilgileri boş olamaz");
            }

            try
            {
                var yorumEntity = _mapper.Map<Yorum>(yorumDTO);
                _yorumService.Create(yorumEntity);
                return Ok("Yorum Başarıyla Eklendi");
            }
            catch (Exception ex)
            {
                return BadRequest($"Yorum eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("deleteyorum/{id}")]
        public IActionResult DeleteYorum(int id)
        {
            var deletedYorum = _yorumService.Delete(id);

            if (deletedYorum == null)
            {
                return NotFound();
            }

            return Ok(deletedYorum);
        }

        [HttpPut]
        [Route("updateyorum")]
        public IActionResult UpdateYorum([FromBody] YorumDTO updatedYorumDTO)
        {
            if (updatedYorumDTO == null)
            {
                return BadRequest("Güncellenecek yorum bilgileri boş olamaz");
            }

            try
            {
                var updatedYorumEntity = _mapper.Map<Yorum>(updatedYorumDTO);
                var updateYorumResult = _yorumService.Update(updatedYorumEntity);

                if (updateYorumResult != null)
                {
                    return Ok(updateYorumResult);
                }
                else
                {
                    return NotFound("Belirtilen ID'ye sahip yorum bulunamadı veya güncelleme başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Yorum güncellenirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}