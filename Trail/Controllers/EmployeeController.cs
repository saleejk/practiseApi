using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trail.Model;
using Trail.Services;

namespace Trail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeService employyy;
      public EmployeeController(IEmployeeService employ)
        {
            employyy = employ;
        }
        [HttpGet]
        public IActionResult getAllEmployees()
        {
            try
            {
                return Ok(employyy.getAllEmployees());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpPost]
        public IActionResult addEmploy(EmployeeModel em)
        {
            return Ok(employyy.addEmployee(em));
        }
        [HttpPut]
        public IActionResult editEmploy(int id,EmployeeModel em)
        {
            return Ok(employyy.editEmployees(id, em)); 
        }
        [HttpDelete]
        public IActionResult deleteEmployee(int id) {
            employyy.deleteEmployee(id); 
            return Ok("deleted successfully");
        }
        [HttpGet("id = {id}")]
        public IActionResult getEmployeeById(int id)
        {
            try
            {
                var data = employyy.getEmployeeById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
