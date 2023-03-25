using FarmaNetBackend.Infrastructure;
using FarmaNetBackend.Models;
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

        [HttpPost]
        [Route("pharmacyImages/upload")]
        public async Task<IActionResult> AddImage(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                string path = "/Pharmacies/" + uploadedFile.FileName;

                using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                PharmacyImage image = new PharmacyImage { Title = uploadedFile.FileName, Path = path };
                _context.PharmacyImages.Add(image);
                _context.SaveChanges();

                return Ok(image.ImageId);
            }

            return RedirectToAction("GetImages");
        }
    }
}
