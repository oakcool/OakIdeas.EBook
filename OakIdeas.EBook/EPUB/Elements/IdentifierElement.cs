using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.EBook.EPUB.Attributes;

namespace OakIdeas.EBook.EPUB.Elements
{
    public class IdentifierElement : OakIdeas.EBook.EPUB.BaseElement
    {
        private readonly List<IAttribute> _attributes;

        private readonly string _namespace;

        private readonly string _prefix;

        private readonly string _reference;

        public override List<IAttribute> Attributes
        {
            get { return this._attributes; }
        }

        public override string Name
        {
            get { return Prefix + ":" + Reference; }
        }

        public override string Namespace
        {
            get { return this._namespace; }
        }

        public override string Prefix
        {
            get { return this._prefix; }
        }

        public override string Reference
        {
            get { return _reference; }
        }

        public override string Value { get; set; }

        public IdentifierElement()
        {
            this._attributes = new List<IAttribute>();
            this._prefix = "dc";
            this._reference = "identifier";
            this._namespace = "http://purl.org/dc/elements/1.1/";
        }

        public IdentifierElement(string value)
            : base()
        {
            this.Value = value;
        }

        public IdentifierElement(string id, string value) :base()
        {
            if (!String.IsNullOrEmpty(id))
            {
                this._attributes.Add(new IdAttribute(id));
            }

            this.Value = value;
        }
    }
}
