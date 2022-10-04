using CIS174AssignmentApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174AssignmentApp.Controllers
{
    public class Assignment6_1Controller : Controller
    {
        public IActionResult Index(int accessLevel)
        {
            List<StudentModel> students = new List<StudentModel>();

            students.Add(new StudentModel { FirstName = "John", LastName = "Smith", Grade = "A" });
            students.Add(new StudentModel { FirstName = "Alice", LastName = "Williams", Grade = "A" });
            students.Add(new StudentModel { FirstName = "Ryan", LastName = "Maddison", Grade = "C" });

            return View(students);
        }
    }
}
