using Trail.Model;

namespace Trail.Services
{
    public interface IEmployeeService
    {
        public List<EmployeeModel> getAllEmployees();
        public List<EmployeeModel> addEmployee(EmployeeModel employ);
        public List<EmployeeModel> editEmployees(int id, EmployeeModel employ);
        public List<EmployeeModel> deleteEmployee(int id);
        public EmployeeModel getEmployeeById(int id);





    }
}
