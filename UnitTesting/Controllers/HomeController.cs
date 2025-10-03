using Microsoft.AspNetCore.Mvc;
using UnitTesting.Services;

namespace UnitTesting.Controllers
{
    public class HomeController : Controller
    {
        private readonly UtilityService _service = new UtilityService();

        // GET: Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: Home/Index
        [HttpPost]
        public IActionResult Index(string vowelInput, string leapInput, string palindromeInput)
        {
            int vowelCount = _service.CountVowels(vowelInput);

            bool? isLeap = null;
            if (int.TryParse(leapInput, out int year))
            {
                try
                {
                    isLeap = _service.IsLeapYear(year);
                }
                catch
                {
                    isLeap = null;
                }
            }

            bool? isPalindrome = null;
            if (int.TryParse(palindromeInput, out int number))
            {
                isPalindrome = _service.IsPalindromeNumber(number);
            }

            // Pass results to view using ViewBag
            ViewBag.VowelCount = vowelCount;
            ViewBag.LeapResult = isLeap.HasValue ? (isLeap.Value ? "a leap year" : "not a leap year") : "invalid year";
            ViewBag.PalindromeResult = isPalindrome.HasValue ? (isPalindrome.Value ? "a palindrome" : "not a palindrome") : "invalid number";

            return View();
        }
    }
}