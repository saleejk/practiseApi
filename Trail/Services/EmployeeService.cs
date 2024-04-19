using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Trail.Model;

namespace Trail.Services
{
    public class EmployeeService:IEmployeeService
    {
        public List<EmployeeModel> employees = new List<EmployeeModel>()
        {new EmployeeModel(){Id=1,name="vaavachi",age=21,designation="pune"}
        };
        public List<EmployeeModel> getAllEmployees()
        {
            return employees;
        }
        public List<EmployeeModel>addEmployee(EmployeeModel employ)
        {
            try
            {
                var idd = employees.LastOrDefault().Id + 1;
                EmployeeModel em = new EmployeeModel() { Id = idd, name = employ.name, age = employ.age, designation = employ.designation };
                employees.Add(em);
            }catch(InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
            return employees;
        }
        public List<EmployeeModel> editEmployees(int id, EmployeeModel employ)
        {
            var edits = employees.FirstOrDefault(val=>val.Id==id);
            edits.name=employ.name;
            edits.age=employ.age;
            edits.designation=employ.designation;
            return employees;
        }
        public List<EmployeeModel> deleteEmployee(int id)
        {
            var deleteEm=employees.FirstOrDefault(val=>val.Id==id);
            employees.Remove(deleteEm);
            return employees;
        }
        public EmployeeModel getEmployeeById(int id)
        {
            var em=employees.FirstOrDefault(val=>val.Id == id);
            return em;
        }
    }
   
}
