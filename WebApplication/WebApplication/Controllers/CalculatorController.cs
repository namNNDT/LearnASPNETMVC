using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculator/
        public ActionResult Index()
        {
            return View();
        }

        public string ShowAuthor()
        {
            return "Nguyen Nhat Nam";
        }
        public double Factorial(int n )
        {
            
            double f = 1;
            for (int i = 2; i <= n; n++)
               f= f * i;
            return f;
        }
        public int Sum(int a, int b)
        {

            return a + b ;
        }
	}
}