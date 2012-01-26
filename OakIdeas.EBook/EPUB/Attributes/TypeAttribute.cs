using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.EBook.EPUB.Attributes
{
    public class TypeAttribute : OakIdeas.EBook.EPUB.Property, IAttribute
    {

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

        private readonly string _prefix;
        public override string Prefix
        {
            get { return this._prefix; }
        }

        private readonly string _reference;
        public override string Reference
        {
            get { return _reference; }
        }

        private readonly bool _defaultVocabulary;

        public override bool DefaultVocabulary
        {
            get { return _defaultVocabulary; }
        }

        public string Value { get; set; }

        private readonly string _namespace;
        public override string Namespace
        {
            get { return this._namespace; }
        }

        public TypeAttribute()
        {
            this._defaultVocabulary = false;
            this._prefix = "epub";
            this._reference = "type";
            this._namespace = "http://www.idpf.org/2007/ops";
        }

        public TypeAttribute(string value)
            : base()
        {
            Value = value;
        }

        public TypeAttribute(string prefix,string reference, string nameSpace, bool defaultVocabulary)
        {
            this._defaultVocabulary = defaultVocabulary;
            this._prefix = prefix;
            this._reference = reference;
            this._namespace = nameSpace;
        }

        
    }
}
