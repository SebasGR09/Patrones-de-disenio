using MethodFactory.Interface;
using System;

namespace MethodFactory.Implementaciones
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Abriendo documento Word");
        }
    }
}