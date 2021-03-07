using Crystal_Report.Models;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.IO;
using System.Web.Mvc;

namespace Crystal_Report.Controllers
{
    public class EmployeeController : Controller
    {
        Employee aEmployee = new Employee();
        public ActionResult Index()
        {

            return View(aEmployee.GetEmployees());
        }

        public ActionResult GetReport()
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/Report"), "EmployeeReport.rpt"));
            rd.SetDataSource(aEmployee.GetEmployees());
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            try
            {
                Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                stream.Seek(0, SeekOrigin.Begin);
                return File(stream, "application/pdf", "employee_list.pdf");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}