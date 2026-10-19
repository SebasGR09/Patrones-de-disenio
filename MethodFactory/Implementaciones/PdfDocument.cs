using MethodFactory.Interface;
using System;

namespace MethodFactory.Implementaciones
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Abriendo documento PDF");
        }
    }
}