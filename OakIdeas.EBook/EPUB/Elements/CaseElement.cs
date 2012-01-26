using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.EBook.EPUB.Attributes;

namespace OakIdeas.EBook.EPUB.Elements
{
    public class CaseElement : OakIdeas.EBook.EPUB.BaseElement
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

        public string RequiredNamespace
        {
            get
            {
                IAttribute requiredNamespace = (from a in Attributes
                                                  where a.Name == "required-namespace"
                                                  select a).FirstOrDefault();

                if (requiredNamespace != null)
                {
                    return requiredNamespace.Value;
                }
                else
                {
                    return String.Empty;
                }
            }
            set
            {
                IAttribute requiredNamespace = (from a in Attributes
                                                where a.Name == "required-namespace"
                                                select a).FirstOrDefault();

                if (requiredNamespace != null)
                {
                    if (!String.IsNullOrEmpty(value))
                    {
                        requiredNamespace.Value = value;
                    }
                    else
                    {
                        this._attributes.Remove(requiredNamespace);
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(value))
                    {
                        this._attributes.Add(new RequiredNamespaceAttribute(value));
                    }
                }
            }
        }

        public override string Value { get; set; }

        public CaseElement()
        {
            this._attributes = new List<IAttribute>();
            this._prefix = "epub";
            this._reference = "case";
            this._namespace = "http://www.idpf.org/2007/ops";

        }

        public CaseElement(string prefix, string reference, string nameSpace)
        {
            this._attributes = new List<IAttribute>();
            this._prefix = prefix;
            this._reference = reference;
            this._namespace = nameSpace;
            
        }

        public CaseElement(string id)
            : base()
        {
            this._attributes.Add(new IdAttribute(id));
        }

        public CaseElement(string id, string requiredNamespace)
            : base()
        {
            if (!String.IsNullOrEmpty(id))
            {
                this._attributes.Add(new IdAttribute(id));
            }
            RequiredNamespace = requiredNamespace;

        }
    }
}
