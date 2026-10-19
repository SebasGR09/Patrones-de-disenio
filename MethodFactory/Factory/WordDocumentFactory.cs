using MethodFactory.AbstractClass;
using MethodFactory.Implementaciones;
using MethodFactory.Interface;
using System;

namespace MethodFactory.Factory
{
    public class WordDocumentFactory : DocumentFactory
    {
        public override IDocument Create()
        {
            return new WordDocument();
        }
    }
}