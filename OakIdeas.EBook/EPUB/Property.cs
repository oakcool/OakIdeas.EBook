using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.EBook.EPUB
{
    public abstract class Property
    {
        public abstract bool DefaultVocabulary { get;}
        public abstract string Name { get;}
        public abstract string Prefix { get; }
        public abstract string Reference { get; }

        public abstract string Namespace { get; }
    }
}
