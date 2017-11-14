using Movie_DB.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Models.Framework;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Abstarcts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Data;

namespace Movie_DB.Core.Commands
{
    public class PDFExportCommand : AbstractCommand, ICommand
    {
        private readonly List<string> listData = new List<string>();

        public PDFExportCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer) : base(context, factory, reader, writer)
        {

        }

        public void CollectData()
        {
            writer.WriteLine("=================");
            writer.WriteLine("Choose What To Print");
            writer.WriteLine("(Type 'Movies', 'Genres', 'People' or 'Series')...");
            listData.Add(reader.ReadLine());

        }

        public string Execute()
        {
            FileStream stream = new FileStream("PdfLogFile.pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Document doc = new Document();
            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, stream);

            CollectData();
            string typeOfObjects = listData[0];

            writer.WriteLine("");
            writer.WriteLine("Printing....");

            switch (typeOfObjects)
            {
                case "Movies":
                    var moviesToPrint = context.Movies.ToList();
                    doc.Open();
                    doc.Add(new Paragraph(string.Join("\n", moviesToPrint)));
                    doc.Close();
                    break;
                case "Genres":
                    var genresToPrint = context.Genres.ToList();
                    doc.Open();
                    doc.Add(new Paragraph(string.Join("\n", genresToPrint)));
                    doc.Close();
                    break;
                case "People":
                    var peopleToPrint = context.Persons.ToList();
                    doc.Open();
                    doc.Add(new Paragraph(string.Join("\n", peopleToPrint)));
                    doc.Close();
                    break;
                case "Series":
                    var seriesToPrint = context.SeriesCollection.ToList();
                    doc.Open();
                    doc.Add(new Paragraph(string.Join("\n", seriesToPrint)));
                    doc.Close();
                    break;
            }

            return @"=================
PDF CREATED!
=================";
        }
    }
}


