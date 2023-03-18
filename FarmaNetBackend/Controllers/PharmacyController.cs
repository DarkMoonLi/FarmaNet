using FarmaNetBackend.Dto.PharmacyDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class PharmacyController : Controller
    {
        private readonly IPharmacyRepository _repository;

        public PharmacyController(IPharmacyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("pharmacies")]
        public IActionResult GetPharmacies()
        {
            List<PharmacyDto> pharmacies = _repository.GetPharmacies().ConvertAll(m => new PharmacyDto(m));
            return Ok(pharmacies);
        }

        [HttpGet]
        [Route("pharmacy")]
        public IActionResult GetPharmacy(GetPharmacyDto pharmacyDto)
        {
            Pharmacy pharmacy = _repository.GetPharmacyById(pharmacyDto);

            if (pharmacy == null)
            {
                return NotFound();
            }

            return Ok(pharmacy);
        }

        [HttpPost]
        [Route("pharmacies/add")]
        public IActionResult AddPharmacy(AddPharmacyDto pharmacyDto)
        {
            _repository.AddPharmacy(pharmacyDto);
            return Ok();
        }

        [HttpPost]
        [Route("pharmacies/update")]
        public IActionResult UpdatePharmacy(UpdatePharmacyDto pharmacyDto)
        {
            _repository.UpdatePharmacy(pharmacyDto);
            return Ok();
        }

        [HttpDelete]
        [Route("pharmacies")]
        public IActionResult RemovePharmacy(GetPharmacyDto pharmacyDto)
        {
            _repository.RemovePharmacy(pharmacyDto);
            return Ok();
        }
    }
}
