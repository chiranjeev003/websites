using StudentPortal.DO;
using System.Web.Mvc;

namespace StudentPortal.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            StudentDetails studentDetails = new StudentDetails();
            var studentList = studentDetails.studentDetails();
            studentList.Sort((x, y) => y.TotalMarks.CompareTo(x.TotalMarks));
            return View(studentList);
        }

        public ActionResult showResultsOfAll()
        {
            StudentDetails studentDetails = new StudentDetails();
            var studentList = studentDetails.studentDetails();
            studentList.Sort((x, y) => y.TotalMarks.CompareTo(x.TotalMarks));
            return View(studentList);
        }

        public ActionResult showResultWithGraceMarks()
        {
            StudentDetails studentDetails = new StudentDetails();
            var studentList = studentDetails.studentResult();
            studentList.Sort((x, y) => y.TotalMarks.CompareTo(x.TotalMarks));
            return View(studentList);
        }
    }
}