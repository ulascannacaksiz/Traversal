using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "Dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Trevarsal rezervasyon pdf raporu");
            document.Add(paragraph);
            document.Close();
            return File("/PdfReports/Dosya1.pdf", "application/pdf","Dosya1.pdf");
        }

        public IActionResult StaticCustomerfReport()
        {
            Guid guid = Guid.NewGuid();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + guid+".pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            PdfPTable pdfTable = new PdfPTable(3);
            pdfTable.AddCell("Misafir Adı");
            pdfTable.AddCell("Misafir Soyadı");
            pdfTable.AddCell("Misafir Tc");

            pdfTable.AddCell("Ulaş Can");
            pdfTable.AddCell("Nacaksız");
            pdfTable.AddCell("12345678910");

            pdfTable.AddCell("Can");
            pdfTable.AddCell("Deneme");
            pdfTable.AddCell("12345678910");

            pdfTable.AddCell("kemal");
            pdfTable.AddCell("Asdf");
            pdfTable.AddCell("12345678910");

            document.Add(pdfTable);
            document.Close();
            return File("/PdfReports/"+guid+".pdf", "application/pdf", guid + ".pdf");
        }
    }
}
