using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using MicropensionWeekend.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Spreadsheet;

namespace MicropensionWeekend.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var path = Server.MapPath("~/Content/products.json");

            ViewBag.Sheets = JsonConvert.DeserializeObject<IEnumerable<SpreadsheetSheet>>(System.IO.File.ReadAllText(path));
            return View();
        }
        public JsonResult MPPAjaxBinding_Read([DataSourceRequest]DataSourceRequest request)
        {
            var result = Enumerable.Range(0, 50).Select(i => new MppModel
            {
                Id = i,
                Surname = "Surname" + i,
                Firstname = "Firstname" + i,
                Othernames = "Othernames " + i,
                Agent = "Agent " + i,
                Pin = "PEN1200000002" + i,
                EmployerCode = i % 2 == 0 ? "Employer 1" : "Employer 2",
                Phone = "080234142145",
                Amount = i * 10,
                Channel = "Web",

                LastPayDate = DateTime.Now.AddDays(i)

            });

            return Json(result.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
            //return Json(result);

        }
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            var workbook = Workbook.Load(file.InputStream, Path.GetExtension(file.FileName));

            TempRemittanceMList RemittanceUpload = new TempRemittanceMList();
            RemittanceUpload.ExcelItem = new List<TempRemittanceModel>();
            int exceloffsetpoint = 4;
            int stoppingpoint = workbook.Sheets[0].Rows.Count() - exceloffsetpoint;
            //var workitems = workbook.Sheets[0].Rows;
            var workitems = workbook.Sheets[0].Rows.GetRange(exceloffsetpoint, stoppingpoint);

            foreach (var item in workitems)
            {
                RemittanceUpload.ExcelItem.Add(new TempRemittanceModel(item.Cells[1].Value.ToString().Trim(), item.Cells[2].Value.ToString().Trim(),
                    item.Cells[3].Value.ToString().Trim(), item.Cells[4].Value.ToString().Trim(), item.Cells[5].Value.ToString().Trim(), decimal.Parse(item.Cells[6].Value.ToString()), item.Cells[1].Value.ToString().Trim()));
            }


            //return Content(workbook.ToJson(), Telerik.Web.Spreadsheet.MimeTypes.JSON);
            return Json(RemittanceUpload, JsonRequestBehavior.AllowGet);

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