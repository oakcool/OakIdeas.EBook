using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.EBook.EPUB.Attributes
{
    public class PhAttribute : OakIdeas.EBook.EPUB.Property, IAttribute
    {
        private readonly bool _defaultVocabulary;

        private readonly string _prefix;

        private readonly string _reference;

        private readonly string _namespace;

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

        public override string Prefix
        {
            get { return this._prefix; }
        }

        public override string Reference
        {
            get { return this._reference; }
        }

        public override string Namespace
        {
            get { return this._namespace; }
        }
        
        public string Value { get; set; }
        
        public PhAttribute()
        {
            this._defaultVocabulary = false;
            this._prefix = "ssml";
            this._reference = "ph";
            this._namespace = "http://www.w3.org/2001/10/synthesis";
        }

        public PhAttribute(string value) : base()
        {
            Value = value;
        }

        public PhAttribute(string prefix, string reference, string nameSpace, bool defaultVocabulary)
        {
            this._defaultVocabulary = defaultVocabulary;
            this._prefix = prefix;
            this._reference = reference;
            this._namespace = nameSpace;
        }

        
    }
}
