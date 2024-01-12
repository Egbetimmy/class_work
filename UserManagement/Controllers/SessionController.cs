using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManagement.Data;
using UserManagement.Models;
using UserMangement.Models;

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : Controller
    {
        private readonly DataContext _dataContext;

        public SessionController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // GET: api/<UserController>
        [HttpGet]
        [Route("get-all-session")]
        public ActionResult<IEnumerable<SessionDto>> Get()
        {
            var sessions = _dataContext.Sessions
                .Include(x => x.Departments)
                .ToList();

            var sessionDtos = sessions.Select(session => new SessionDto
            {
                Id = session.Id,
                Name = session.Name,
                CreatedBy = session.CreatedBy,
                CreatedAt = session.CreatedAt,
                Departments = session.Departments.Select(department => new DepartmentDto
                {
                    Id = department.Id,
                    Name = department.Name,
                    SessionId = department.SessionId
                }).ToList()
            }).ToList();

            return Ok(sessionDtos);
        } 

        [HttpPost]
        [Route("add-session-department")]
        public IActionResult NewSessioAndDepartments([FromBody] SessionRequestDto model)
        {
            try
            {
                var c = new Session
                {
                    Name = model.Name,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "USER"
                };
                c.Departments = new List<Department>() { };

                model.Departments.ForEach(x =>
                {
                    var sc = new Department
                    {
                        SessionId = c.Id,
                        Name = x.Name
                    };
                    c.Departments.Add(sc);
                });

                _dataContext.Sessions.Add(c);
                _dataContext.SaveChanges();

                return Ok("Session Add Succesfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpPost]
        [Route("add-departmnet")]
        public IActionResult NewDepartment([FromBody] DepartmentPostDto model)
        {
            try
            {
                var sessionExist = _dataContext.Sessions.Find(model.SessionId);
                if (sessionExist != null)
                {
                    var c = new Department
                    {
                        SessionId = sessionExist.Id,
                        Name = model.Name
                    };

                    _dataContext.departments.Add(c);
                    _dataContext.SaveChanges();

                    return Ok("Session Add Succesfully");
                }
                else
                {
                    return Ok("no session could found with the request session id");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("new-session")]
        public IActionResult NewSession([FromBody] SessionPostDto model)
        {
            try
            {
                var newSession = new Session
                {
                    Name = model.Name,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "USER"
                };

                _dataContext.Sessions.Add(newSession);
                _dataContext.SaveChanges();

                var sessionDto = new SessionDto
                {
                    Id = newSession.Id,
                    Name = newSession.Name,
                    CreatedBy = newSession.CreatedBy,
                    CreatedAt = newSession.CreatedAt,
                    Departments = new List<DepartmentDto>() // You can leave it empty or populate as needed
                };

                return Ok(sessionDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
