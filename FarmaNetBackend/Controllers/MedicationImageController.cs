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
    public class MedicationImageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        
        public MedicationImageController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [HttpGet]
        [Route("/medicationImages")]
        public IActionResult GetImages()
        {
            List<MedicationImage> images = _context.MedicationImages.ToList();

            return Ok(images);
        }

        [HttpGet]
        [Route("/medicationImages/{id}")]
        public IActionResult GetImageById(int id)
        {
            MedicationImage image = _context.MedicationImages.FirstOrDefault(i => i.ImageId.Equals(id));

            if (image == null)
            {
                return NotFound();
            }

            return Ok(image);
        }

        [HttpPost]
        [Route("/medicationImages/upload")]
        public async Task<IActionResult> AddImage(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                string path = "/Medications/" + uploadedFile.FileName;

                using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                MedicationImage image = new MedicationImage { Title = uploadedFile.FileName, Path = path };
                _context.MedicationImages.Add(image);
                _context.SaveChanges();

                return Ok(image.ImageId);
            }

            return RedirectToAction("GetImages");
        }
    }
}
