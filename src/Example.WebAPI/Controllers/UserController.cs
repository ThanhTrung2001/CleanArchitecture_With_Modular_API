
using Example.Domain.Entities;
using Example.SharedKernel.Abstractions.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Example.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _unitOfWork.Repository<User>().GetAllAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            await _unitOfWork.Repository<User>().AddAsync(user);
            await _unitOfWork.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { id = user.ID }, user);
        }
    }
}
