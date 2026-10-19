using MethodFactory.Interface;
using System;

namespace MethodFactory.Implementaciones
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Abriendo documento Excel");
        }
    }
}