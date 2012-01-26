using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.EBook.EPUB.Attributes;

namespace OakIdeas.EBook.EPUB.Elements
{
    public class DefaultElement : OakIdeas.EBook.EPUB.BaseElement
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

        public DefaultElement()
        {
            this._attributes = new List<IAttribute>();
            this._prefix = "epub";
            this._reference = "default";
            this._namespace = "http://www.idpf.org/2007/ops";

        }

        public DefaultElement(string prefix, string reference, string nameSpace)
        {
            this._attributes = new List<IAttribute>();
            this._prefix = prefix;
            this._reference = reference;
            this._namespace = nameSpace;

        }

        public DefaultElement(string id)
            : base()
        {
            this._attributes.Add(new IdAttribute(id));
        }
    }
}
