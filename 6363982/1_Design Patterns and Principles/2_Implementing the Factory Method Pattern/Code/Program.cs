using System;

public abstract class Document
{
    public abstract void Open();
}


public class WordDocument : Document
{
    public override void Open()
    {
        System.Console.WriteLine("Opening Word Document");
    }
}

public class PdfDocument : Document
{
    public override void Open()
    {
        System.Console.WriteLine("Opening PDF Document");
    }
}

public class ExcelDocument : Document
{
    public override void Open()
    {
        System.Console.WriteLine("Opening Excel Document");
    }
}

// Step 4: Implement the Factory Method
public abstract class DocumentFactory
{
    public abstract Document CreateDocument();
}

public class WordDocumentFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new WordDocument();
    }
}

public class PdfDocumentFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new PdfDocument();
    }
}

public class ExcelDocumentFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new ExcelDocument();
    }
}


public class Program
{
    public static void Main()
    {
        DocumentFactory wordFactory = new WordDocumentFactory();
        Document wordDoc = wordFactory.CreateDocument();
        wordDoc.Open();

        DocumentFactory pdfFactory = new PdfDocumentFactory();
        Document pdfDoc = pdfFactory.CreateDocument();
        pdfDoc.Open();

        DocumentFactory excelFactory = new ExcelDocumentFactory();
        Document excelDoc = excelFactory.CreateDocument();
        excelDoc.Open();
    }
}
