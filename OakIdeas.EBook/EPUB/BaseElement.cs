using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.EBook.EPUB.Attributes;

namespace OakIdeas.EBook.EPUB
{
    public abstract class BaseElement
    {

        public abstract string Name { get; }

        public abstract string Namespace { get; }

        public abstract string Value
        {
            get;
            set;
        }

        public abstract List<IAttribute> Attributes { get; }

        public abstract string Prefix { get; }

        public abstract string Reference { get; }

        private readonly List<BaseElement> _children = new List<BaseElement>();
        public  List<BaseElement> Children
        {
            get { return this._children; }
        }
    }
}
