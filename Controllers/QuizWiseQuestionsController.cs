using Microsoft.AspNetCore.Mvc;

namespace Quiz_Management.Controllers
{
    public class QuizWiseQuestionsController : Controller
    {
        public IActionResult QuizWiseQuestionsList()
        {
            return View();
        }

        public IActionResult AddQuizWiseQuestions()
        {
            return View();
        }
    }
}
