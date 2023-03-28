using FarmaNetBackend.Dto.WorkerAccountDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
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
        public IActionResult GetWorkerAccounts()
        {
            List<WorkerAccountDto> workerAccounts = _repository.GetWorkerAccounts().ConvertAll(m => new WorkerAccountDto(m));
            return Ok(workerAccounts);
        }

        [HttpGet]
        [Route("workerAccount")]
        public IActionResult GetWorkerAccount(GetWorkerAccountDto workerAccountDto)
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
        public IActionResult AddWorkerAccount(AddWorkerAccountDto workerAccountDto)
        {
            LoginValidator.Validate(workerAccountDto.Login, ModelState);
            PasswordValidator.Validate(workerAccountDto.Password, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelStateError.Errors(ModelState));
            }

            _repository.AddWorkerAccount(workerAccountDto);
            return Ok();
        }

        [HttpPost]
        [Route("workerAccounts/update")]
        public IActionResult UpdateWorkerAccount(UpdateWorkerAccountDto workerAccountDto)
        {
            LoginValidator.Validate(workerAccountDto.Login, ModelState);
            PasswordValidator.Validate(workerAccountDto.Password, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelStateError.Errors(ModelState));
            }

            _repository.UpdateWorkerAccount(workerAccountDto);
            return Ok();
        }

        [HttpDelete]
        [Route("workerAccounts")]
        public IActionResult RemoveWorkerAccount(GetWorkerAccountDto workerAccountDto)
        {
            _repository.RemoveWorkerAccount(workerAccountDto);
            return Ok();
        }
    }
}
