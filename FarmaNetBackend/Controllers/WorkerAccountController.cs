using FarmaNetBackend.Dto.WorkerAccountDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class WorkerAccountController : Controller
    {
        private readonly IWorkerAccountRepository _repository;

        public WorkerAccountController(IWorkerAccountRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("workerAccounts")]
        public IActionResult GetImports()
        {
            List<WorkerAccountDto> workerAccounts = _repository.GetWorkerAccounts().ConvertAll(m => new WorkerAccountDto(m));
            return Ok(workerAccounts);
        }

        [HttpGet]
        [Route("workerAccount")]
        public IActionResult GetImport(GetWorkerAccountDto workerAccountDto)
        {
            WorkerAccount workerAccount = _repository.GetWorkerAccountById(workerAccountDto);

            if (workerAccount == null)
            {
                return NotFound();
            }

            return Ok(workerAccount);
        }

        [HttpPost]
        [Route("workerAccounts/add")]
        public IActionResult AddImport(AddWorkerAccountDto workerAccountDto)
        {
            _repository.AddWorkerAccount(workerAccountDto);
            return Ok();
        }

        [HttpPost]
        [Route("workerAccounts/update")]
        public IActionResult UpdateImport(UpdateWorkerAccountDto workerAccountDto)
        {
            _repository.UpdateWorkerAccount(workerAccountDto);
            return Ok();
        }

        [HttpDelete]
        [Route("workerAccounts")]
        public IActionResult RemoveImport(GetWorkerAccountDto workerAccountDto)
        {
            _repository.RemoveWorkerAccount(workerAccountDto);
            return Ok();
        }
    }
}
