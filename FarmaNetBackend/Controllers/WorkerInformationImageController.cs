using FarmaNetBackend.Dto;
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
    public class WorkerInformationImageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public WorkerInformationImageController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [HttpGet]
        [Route("workerInfromationImages")]
        public IActionResult GetImages()
        {
            List<WorkerInformationImage> images = _context.WorkerInformationImages.ToList();

            return Ok(images);
        }

        [HttpGet]
        [Route("workerInfromationImages/{id}")]
        public IActionResult GetImageById(int id)
        {
            WorkerInformationImage image = _context.WorkerInformationImages.FirstOrDefault(i => i.ImageId.Equals(id));

            if (image == null)
            {
                return NotFound();
            }

            return Ok(image);
        }

        [HttpGet]
        [Route("workerImageByWorker/{id}")]
        public IActionResult GetImageByWorker(int id)
        {
            WorkerInformationImage image = (from w in _context.WorkersInformation
                                           join i in _context.WorkerInformationImages
                                           on w.WorkerInformationImageId equals i.ImageId
                                           where w.WorkerInformationId.Equals(id)
                                           select i).First();

            return Ok(image);
        }

        [HttpPost]
        [Route("workerInfromationImages/upload")]
        public async Task<IActionResult> AddImage(/*[FromForm(Name = "uploadedFile")]*/ IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                string path = "/WorkerInformations/" + uploadedFile.FileName;

                NameValidator.Validate(uploadedFile.FileName, ModelState);
                ImagePathValidator.Validate(path, ModelState);

                if (!ModelState.IsValid)
                {
                    return BadRequest( ModelStateError.Errors(ModelState) );
                }

                using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                WorkerInformationImage image = new WorkerInformationImage { Title = uploadedFile.FileName, Path = path };
                _context.WorkerInformationImages.Add(image);
                _context.SaveChanges();

                return Ok(image);
            }

            return RedirectToAction("GetImages");
        }
    }
}
