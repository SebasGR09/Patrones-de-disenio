using MethodFactory.AbstractClass;
using MethodFactory.Factory;
using MethodFactory.Interface;
using System;

namespace MethodFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory factoryPDF = new PdfDocumentFactory();

            DocumentFactory factoryWord = new WordDocumentFactory();

            DocumentFactory factoryExcel = new ExcelDocumentFactory();

            IDocument filePdf = factoryPDF.Create();

            IDocument fileWord = factoryWord.Create();

            IDocument fileExcel = factoryExcel.Create();

            filePdf.Open();
            fileWord.Open();
            fileExcel.Open();
        }
    }
}