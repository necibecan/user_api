using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Models.DTOs;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IMapper mapper) : ControllerBase
    {
        private readonly IUserService userService = new UserService(mapper);
        private readonly ISearchService<UserDTO> userSearchService = new UserSearchService(mapper);

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = userService.GetAll();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Add([FromBody] UserAddRequestDTO user)
        {
            // Veri validasyonu
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // User ekleme işlemi
            var createdUser = userService.Add(user);
            return CreatedAtAction(nameof(GetById), new { id = createdUser.Id }, createdUser);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = userSearchService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }        
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            var user = userSearchService.GetByName(name);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }         
        [HttpGet("{email}")]
        public IActionResult GetByEmail(string email)
        {
            var user = userSearchService.GetByEmail(email);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }        
        
        [HttpGet("{age}")]
        public IActionResult GetByAge(int age)
        {
            var users = userSearchService.GetByAge(age);
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        [HttpPut]
        public IActionResult Update([FromBody] UserUpdateRequestDTO user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedUser = userService.Update(user);
            if (updatedUser == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = userService.Delete(id);
            if (!user)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}
