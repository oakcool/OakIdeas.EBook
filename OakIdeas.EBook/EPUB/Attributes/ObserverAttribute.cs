using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.EBook.EPUB.Attributes
{
    public class ObserverAttribute : OakIdeas.EBook.EPUB.Property, OakIdeas.EBook.EPUB.Attributes.IAttribute
    {
        private readonly bool _defaultVocabulary;

        private readonly string _namespace;

        private readonly string _prefix;

        private readonly string _reference;

        public override bool DefaultVocabulary
        {
            get { return _defaultVocabulary; }
        }

        public override string Name
        {
            get
            {
                if (DefaultVocabulary)
                {
                    return Reference;
                }
                else
                {
                    return Prefix + ":" + Reference;
                }
            }
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

        public string Value { get; set; }

        public ObserverAttribute()
        {
            this._defaultVocabulary = false;
            this._prefix = "ev";
            this._reference = "observer";
            this._namespace = "http://www.w3.org/2001/xml-events";
        }

        public ObserverAttribute(string prefix, string reference, string nameSpace, bool defaultVocabulary)
        {
            this._defaultVocabulary = defaultVocabulary;
            this._prefix = prefix;
            this._reference = reference;
            this._namespace = nameSpace;
        }

        public ObserverAttribute(string value)
            : base()
        {
            Value = value;
        }
    }
}
