using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using Todo.BAL.Interface;

namespace Todo.API.Controllers
{
    [Produces("application/json")]
    [ApiController]
    public class ReportController : ControllerBase
    {

        [Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IGroupService _group;
        private readonly ITodoService _todo;
        private readonly IListTodoService _list;

        [Obsolete]
        public ReportController(IHostingEnvironment hostingEnvironment, IGroupService _group, ITodoService _todo, IListTodoService _list)
        {
            this.hostingEnvironment = hostingEnvironment;
            this._group = _group;
            this._todo = _todo;
            this._list = _list;
        }

        [HttpGet]
        [Route("api/export")]
        public IActionResult ExportReportt()
        {
            var GroupReport = _group.GetListGroupSV();
            var TodoReport = _todo.GetTodoAllGroup();
            string fileName = "GroupList.xlsx";
            var stream = new MemoryStream();
            using (var package = new ExcelPackage(stream))
            {
                ExcelWorksheet worksheet2 = package.Workbook.Worksheets.Add("GroupList");
                worksheet2.Cells[2, 1].LoadFromCollection(GroupReport, true, TableStyles.Light19);
                worksheet2.DeleteColumn(1);
                worksheet2.DefaultColWidth = 25;
                worksheet2.Cells.Style.WrapText = true;
                worksheet2.Cells[1, 2].Value = $"Group List :({GroupReport.Count})";

                worksheet2.Cells[2, 5].LoadFromCollection(TodoReport, true, TableStyles.Light19);
                worksheet2.DeleteColumn(5);
                worksheet2.DeleteColumn(7);
                worksheet2.DeleteColumn(8);
                worksheet2.DeleteColumn(7);
                worksheet2.DefaultColWidth = 30;
                worksheet2.Cells.Style.WrapText = true;
                worksheet2.Cells[1, 9].Value = $"Todo List :({TodoReport.Count})";
                package.Save();
            }
            stream.Position = 0;
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }

        //[HttpGet]
        //[Route("api/exportv2")]
        //public async Task<string> ExportReport()
        //{
        //    string rootFolder = hostingEnvironment.WebRootPath;
        //    string fileName = "GroupList.xlsx";
        //    string downloadUrl = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, fileName);
        //    FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));
        //    if (file.Exists)
        //    {
        //        file.Delete();
        //        file = new FileInfo(Path.Combine(rootFolder, fileName));
        //    }
        //    await Task.Yield();
        //    using (ExcelPackage package = new ExcelPackage(file))
        //    {
        //        ExcelWorksheet worksheet2 = package.Workbook.Worksheets.Add("GroupList");
        //        var GroupReport = _group.GetListGroupSV();
        //        var TodoReport = _todo.GetTodoAllGroup();
        //        worksheet2.Cells[2, 1].LoadFromCollection(GroupReport, true, TableStyles.Light19);
        //        worksheet2.DeleteColumn(1);
        //        worksheet2.DefaultColWidth = 25;
        //        worksheet2.Cells.Style.WrapText = true;
        //        worksheet2.Cells[1, 2].Value = $"Group List :({GroupReport.Count})";

        //        worksheet2.Cells[2, 5].LoadFromCollection(TodoReport, true, TableStyles.Light19);
        //        worksheet2.DeleteColumn(5);
        //        worksheet2.DeleteColumn(7);
        //        worksheet2.DeleteColumn(8);
        //        worksheet2.DeleteColumn(7);
        //        worksheet2.DefaultColWidth = 30;
        //        worksheet2.Cells.Style.WrapText = true;
        //        worksheet2.Cells[1, 9].Value = $"Todo List :({TodoReport.Count})";
        //        package.Save();

        //        return downloadUrl;
        //    }
        //}
    }
}