using employee.api.api.Domain.EmployeeOperations.Interfaces;
using employee.api.api.Domain.EmployeeOperations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace employee.api.api.Web.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly IConfiguration _configuration;
        readonly IEmployeeService employeeService;
        public EmployeeController(IConfiguration configuration, IEmployeeService employeeService)
        {
            _configuration = configuration;
            this.employeeService = employeeService;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult GetAllEmployeeList()
        {
            try
            {
                var ListOfItem = employeeService.GetAllEmployeeList();
                if (ListOfItem.Any())
                    return Ok(ListOfItem);
            }
            catch (Exception ex)
            {
                Log.Logger.Information(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "");
            }
            return NotFound("Employee List is empty, Please add details");
        }

        // GET api/<EmployeeController>/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetEmployee(int id)
        {
            try
            {
                var Item = employeeService.GetEmployee(id);
                if(Item != null)
                return Ok(Item);
            }
            catch (Exception ex)
            {
                Log.Logger.Information(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "");
            }
            return NotFound("Employee not found");
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            try
            {
                var code = employeeService.AddEmployee(employee);
                if(code ==0)
                return Ok("Successfully Added");
            }
            catch (Exception ex)
            {
                Log.Logger.Information(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "");
            }
            return BadRequest("Error in adding the data");

        }

        //// PUT api/<EmployeeController>/5
        //[HttpPut("{id}")]
        //public void UpdateEmployee(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<EmployeeController>/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                var code = employeeService.DeleteEmployee(id);
                if (code == 0)
                    return Ok("Successfully Deleted");
            }
            catch (Exception ex)
            {
                Log.Logger.Information(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "");
            }
            return BadRequest("Error in deleting the data");
        }
    }
}
