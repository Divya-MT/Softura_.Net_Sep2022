using Microsoft.AspNetCore.Mvc;
using SampleApp.Models;
namespace SampleApp.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            Teacher teacher = new Teacher()
            {
 Department="Science",Id=1001,Inchargefor="First Year",Name="Jayanthi",Qualification="M.Ed",MajorSubject="Physics"
            };
            return View(teacher);
        }
    }
}
