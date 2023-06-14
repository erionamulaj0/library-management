using LibraryMengament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LibraryMengament.Controllers
{
    [Authorize]
    public class GmailController : Controller
    {
        // GET: Gmail
        public ActionResult Send()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Send(Gmail gmail)
        {
            await gmail.SendMail(gmail);
            return View("Sent");
        }
    }
}