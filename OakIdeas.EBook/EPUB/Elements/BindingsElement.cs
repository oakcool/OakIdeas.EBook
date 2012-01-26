using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.EBook.EPUB.Attributes;

namespace OakIdeas.EBook.EPUB.Elements
{
    public class BindingsElement : OakIdeas.EBook.EPUB.BaseElement
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

        private BindingsElement()
        {
            this._attributes = new List<IAttribute>();
            this._reference = "package";
            this._namespace = "http://www.idpf.org/2007/ops";
        }

        public BindingsElement(string id, string version, string uniqueIdentifier, string language, string direction)
            : base()
        {
            if (!String.IsNullOrEmpty(id))
            {
                this._attributes.Add(new IdAttribute(id));
            }

            if (!String.IsNullOrEmpty(version))
            {
                this._attributes.Add(new VersionAttribute(version));
            }
            else
            {
                throw new Exception("Invalid Package Contruction");
            }

            if (!String.IsNullOrEmpty(uniqueIdentifier))
            {
                this._attributes.Add(new UniqueIdentifierAttribute(uniqueIdentifier));
            }
            else
            {
                throw new Exception("Invalid Package Contruction");
            }

            if (!String.IsNullOrEmpty(language))
            {
                this._attributes.Add(new LanguageAttribute(language));
            }

            if (!String.IsNullOrEmpty(direction))
            {
                this._attributes.Add(new DirectionAttribute(direction));
            }
        }

        public BindingsElement(string version, string uniqueIdentifier)
            : base()
        {
            if (!String.IsNullOrEmpty(version))
            {
                this._attributes.Add(new VersionAttribute(version));
            }
            else
            {
                throw new Exception("Invalid Package Contruction");
            }

            if (!String.IsNullOrEmpty(uniqueIdentifier))
            {
                this._attributes.Add(new UniqueIdentifierAttribute(uniqueIdentifier));
            }
            else
            {
                throw new Exception("Invalid Package Contruction");
            }
        }
    }
}
