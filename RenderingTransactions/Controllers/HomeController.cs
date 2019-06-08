using BusinessLogic;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace RenderingTransactions.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return RedirectToAction("FilterTransactions");
        }
        public ActionResult FilterTransactions(int? transactionType = null, int? currency = null)
        {
            TransactionsService transactionsService = new TransactionsService();
            TransactionsFilter transactionsFilter = new TransactionsFilter();

            if(transactionType != null)
            {
                transactionsFilter.Action = ((Variables.ActionValues)transactionType).ToString();
                ViewBag.SelectedAction = transactionType;
            }
            if (currency != null)
            {
                transactionsFilter.CurrencyCode = ((Variables.CurrencyCodeValues)currency).ToString();
                ViewBag.SelectedCurrency = currency;
            }

            return View("Index", transactionsService.GetTransactions(transactionsFilter));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}