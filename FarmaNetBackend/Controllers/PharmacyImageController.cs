using FarmaNetBackend.Infrastructure;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaNetBackend.Controllers
{
    [ApiController]
    public class PharmacyImageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public PharmacyImageController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [HttpGet]
        [Route("pharmacyImages")]
        public IActionResult GetImages()
        {
            List<PharmacyImage> images = _context.PharmacyImages.ToList();

            return Ok(images);
        }

        [HttpGet]
        [Route("pharmacyImages/{id}")]
        public IActionResult GetImageById(int id)
        {
            PharmacyImage image = _context.PharmacyImages.FirstOrDefault(i => i.ImageId.Equals(id));

            if (image == null)
            {
                return NotFound();
            }

            return Ok(image);
        }

        [HttpGet]
        [Route("pharmacyImageByPharmacy/{id}")]
        public IActionResult GetImageByPharmacy(int id)
        {
            PharmacyImage image = (from p in _context.Pharmacies
                                    join i in _context.PharmacyImages
                                    on p.PharmacyImageId equals i.ImageId
                                    where p.PharmacyImageId.Equals(id)
                                    select i).First();

            if (image == null)
            {
                return NotFound();
            }

            return Ok(image);
        }

        [HttpPost]
        [Route("pharmacyImages/upload")]
        public async Task<IActionResult> AddImage(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                const string directory = "/Pharmacies/";
                string path = directory + uploadedFile.FileName;

                NameValidator.Validate(uploadedFile.FileName, ModelState);
                ImagePathValidator.Validate(path, ModelState);

                if (!ModelState.IsValid)
                {
                    return BadRequest( ModelStateError.Errors(ModelState) );
                }

                if (!Directory.Exists(_environment.WebRootPath + directory))
                {
                    Directory.CreateDirectory(_environment.WebRootPath + directory);
                }

                using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                PharmacyImage image = new PharmacyImage { Title = uploadedFile.FileName, Path = path };
                _context.PharmacyImages.Add(image);
                _context.SaveChanges();

                return Ok(image);
            }

            return RedirectToAction("GetImages");
        }
    }
}
