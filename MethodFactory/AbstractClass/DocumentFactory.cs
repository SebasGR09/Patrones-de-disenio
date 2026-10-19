using MethodFactory.Interface;
using System;

namespace MethodFactory.AbstractClass
{
    public abstract class DocumentFactory
    {
        public abstract IDocument Create();

        public void ShowMessage()
        {
            Console.WriteLine("Esto es un mensajito");
        }
    }
}