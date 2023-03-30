using FarmaNetBackend.Dto.PharmacyDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
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
            List<PharmacyDto> pharmacies = _repository.GetPharmacies();
            return Ok(pharmacies);
        }

        [HttpGet]
        [Route("pharmacy/{id}")]
        public IActionResult GetPharmacy(int id)
        {
            PharmacyDto pharmacy = _repository.GetPharmacyById(id);

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
            NameValidator.Validate(pharmacyDto.Name, ModelState);
            AddressValidator.Validate(pharmacyDto.Address, ModelState);
            EmailValidator.Validate(pharmacyDto.Email, ModelState);
            DescriptionValidator.Validate(pharmacyDto.Description, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest( ModelStateError.Errors(ModelState) );    
            }

            _repository.AddPharmacy(pharmacyDto);
            return Ok();
        }

        //[HttpPost]
        //[Route("pharmacies/update")]
        //public IActionResult UpdatePharmacy(UpdatePharmacyDto pharmacyDto)
        //{
        //    NameValidator.Validate(pharmacyDto.Name, ModelState);
        //    AddressValidator.Validate(pharmacyDto.Address, ModelState);
        //    EmailValidator.Validate(pharmacyDto.Email, ModelState);
        //    DescriptionValidator.Validate(pharmacyDto.Description, ModelState);

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest( ModelStateError.Errors(ModelState) );
        //    }

        //    _repository.UpdatePharmacy(pharmacyDto);
        //    return Ok();
        //}

        //[HttpDelete]
        //[Route("pharmacies")]
        //public IActionResult RemovePharmacy(GetPharmacyDto pharmacyDto)
        //{
        //    _repository.RemovePharmacy(pharmacyDto);
        //    return Ok();
        //}
    }
}
