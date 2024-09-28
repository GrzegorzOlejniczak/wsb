using System;

namespace DocumentFactory
{
    // Interfejs dla dokumentów
    public interface IDocument
    {
        string Generate();
    }

    // Klasy dla różnych typów dokumentów
    public class PDFDocument : IDocument
    {
        private string title;

        public PDFDocument(string title)
        {
            this.title = title;
        }

        public string Generate()
        {
            return $"Generating PDF document titled: {title}";
        }
    }

    public class DOCXDocument : IDocument
    {
        private string title;

        public DOCXDocument(string title)
        {
            this.title = title;
        }

        public string Generate()
        {
            return $"Generating DOCX document titled: {title}";
        }
    }

    // Abstrakcyjna fabryka
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument(string title);
    }

    // Konkretne fabryki
    public class PDFDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument(string title)
        {
            return new PDFDocument(title);
        }
    }

    public class DOCXDocumentFactory : DocumentFactory
    {
        public override IDocument CreateDocument(string title)
        {
            return new DOCXDocument(title);
        }
    }

    // Klient
    public class Client
    {
        public static void GenerateDocument(DocumentFactory factory, string title)
        {
            IDocument document = factory.CreateDocument(title);
            Console.WriteLine(document.Generate());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy fabryki
            DocumentFactory pdfFactory = new PDFDocumentFactory();
            DocumentFactory docxFactory = new DOCXDocumentFactory();

            // Tworzymy dokumenty
            Client.GenerateDocument(pdfFactory, "My First PDF Document");
            Client.GenerateDocument(docxFactory, "My First DOCX Document");
            Console.ReadLine();
        }
        
    }
}
