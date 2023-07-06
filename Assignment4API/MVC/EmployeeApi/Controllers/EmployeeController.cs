using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>()
        {
            new Employee(){Id=1 ,FirstName="Arvind", LastName="Kejriwal", Department=1, Gender="Male", Country="Country.UK", Salary=12351, Dob=new DateTime(1999,05,01)},
                                                                    new Employee(){Id=2 ,FirstName="Sandeep", LastName="Banerjee", Department=1, Gender="Male", Country="Country.Cannada", Salary=33546, Dob=new DateTime(1995,01,15)},
                                                                    new Employee(){Id=3 ,FirstName="Bharat", LastName="Loksabha", Department=8, Gender="Male", Country="Country.USA", Salary=89383, Dob=new DateTime(1969,2,12)},
                                                                    new Employee(){Id=4 ,FirstName="Ajit", LastName="Pawar", Department=9, Gender="Male", Country="Country.UK", Salary=34343, Dob=new DateTime(1999,01,18)},
                                                                    new Employee(){Id=5 ,FirstName="Nitish", LastName="Kumar", Department=15, Gender="Male", Country="Country.USA", Salary=34458, Dob=new DateTime(1995,09,28)},
                                                                    new Employee(){Id=6 ,FirstName="Narendra", LastName="Modi", Department=55, Gender="Male", Country="Country.India", Salary=55786, Dob=new DateTime(1996,08,08)},
                                                                    new Employee(){Id=7 ,FirstName="Joe", LastName="Biden", Department=32,Gender="Male", Country="Country.France", Salary=82567, Dob=new DateTime(1997,08,23)},
                                                                    new Employee(){Id=8 ,FirstName="Bhagwant", LastName="Maan", Department=33, Gender="Male", Country="Country.UK", Salary=22579, Dob=new DateTime(1993,12,05)},
                                                                    new Employee(){Id=9 ,FirstName="Rajat", LastName="Sabale", Department=58,Gender="Male", Country="Country.India", Salary=20052, Dob=new DateTime(2022,01,25)},
                                                                    new Employee(){Id=10 ,FirstName="Kirron", LastName="Bedi",  Department=58, Gender="FeMale", Country="Country.USA", Salary=15115, Dob=new DateTime(2014,05,17)},
                                                                    new Employee(){Id=11 ,FirstName="Akhilesh", LastName="Yadav",  Department=88,Gender="Male", Country="Country.UK", Salary=21354, Dob=new DateTime(2019,04,07)},
                                                                    new Employee(){Id=12 ,FirstName="Raj", LastName="Mittal",  Department=58,Gender="Male", Country="Country.Cannada", Salary=13515, Dob=new DateTime(2011,06,30)},
                                                                    new Employee(){Id=22 ,FirstName="Mukesh", LastName="Ambani",  Department=64,Gender="Male", Country="Country.France", Salary=87684, Dob=new DateTime(2007,05,04)},
                                                                    new Employee(){Id=13 ,FirstName="Raj", LastName="Thakrey",  Department=65,Gender="Male", Country="Country.Cannada", Salary=94864, Dob=new DateTime(2000,08,09)},
                                                                    new Employee(){Id=28 ,FirstName="Rahul", LastName="Gandhi",  Department=45, Gender="Male", Country="Country.USA", Salary=84684, Dob=new DateTime(2000,01,09)},
                                                                    new Employee(){Id=92 ,FirstName="Gau", LastName="K",  Department=58,Gender="Male", Country="Country.UK", Salary=13535, Dob=new DateTime(1999,01,06)},
                                                                    new Employee(){Id=97 ,FirstName="Adil", LastName="Ray",  Department=55,Gender="Male", Country="Country.India", Salary=6456, Dob=new DateTime(1971,06,30)},
                                                                    new Employee(){Id=95 ,FirstName="Yatin", LastName="Reddy",  Department=55, Gender="Male", Country="Country.France", Salary=68784, Dob=new DateTime(2001,05,18)},
                                                                    new Employee(){Id=19 ,FirstName="Raghuram", LastName="Rajan",  Department=55,Gender="Male", Country="Country.UK", Salary=99846, Dob=new DateTime(2008,04,17)},
                                                                    new Employee(){Id=26 ,FirstName="Nitin", LastName="Gulati",  Department=5, Gender="Male", Country="Country.France", Salary=13148, Dob=new DateTime(2017,09,13)},
                                                                    new Employee(){Id=35 ,FirstName="Mukul", LastName="Sharma",  Department=5,Gender="Male", Country="Country.USA", Salary=36546, Dob=new DateTime(2013,07,11)},
                                                                    new Employee(){Id=74 ,FirstName="Hambir", LastName="",  Department=55, Gender="Male", Country="Country.Cannada", Salary=25466, Dob=new DateTime(2019,11,04)},
                                                                    new Employee(){Id=76 ,FirstName="Pooja", LastName="Chavan",  Department=85, Gender="FeMale", Country="Country.Cannada", Salary=16854, Dob=new DateTime(2022,01,01)},
                                                                    new Employee(){Id=79 ,FirstName="Prajakta", LastName="Bhosale",  Department=74, Gender="FeMale", Country="Country.France", Salary=34685, Dob=new DateTime(2019,05,05)},
                                                                    new Employee(){Id=70 ,FirstName="Dnyanada", LastName="Kadam",  Department=33, Gender="FeMale", Country="Country.USA", Salary=55486, Dob=new DateTime(2023,06,12)},
                                                                    new Employee(){Id=60 ,FirstName="Akshay", LastName="Salunkhe",  Department=99, Gender="Male", Country="Country.Cannada", Salary=54664, Dob=new DateTime(2011,11,11)},
                                                                    
        };

        [HttpGet("all")]
        public IActionResult GetAllEmployees()
        {
            return Ok(_employees);
        }

        [HttpPost]
        public IActionResult InsertEmployee([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Invalid employee data.");
            }

            int newEmployeeId = _employees.Max(e => e.Id) + 1;
            employee.Id = newEmployeeId;

            _employees.Add(employee);

            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id }, employee);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpGet("male")]
        public IActionResult GetEmployeeMale()
        {
            var employee = _employees.Where(e => e.Gender == "Male");
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpGet("female")]
        public IActionResult GetEmployeeFeMale()
        {
            var employee = _employees.Where(e => e.Gender == "FeMale");
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
