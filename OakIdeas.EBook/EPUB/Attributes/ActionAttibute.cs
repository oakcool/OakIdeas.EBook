using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.EBook.EPUB.Attributes
{
    public class ActionAttibute : OakIdeas.EBook.EPUB.Property, OakIdeas.EBook.EPUB.Attributes.IAttribute
    {
        private readonly string[] _validActions = {"show", "hide", "play", "pause", "resume", "mute", "unmute"};

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

        private string _value;
        public string Value
        {
            get { return _value; }
            set
            {
                if (_validActions.Contains(value))
                {
                    _value = value;

                }
            }
        }

        public ActionAttibute()
        {
            this._defaultVocabulary = true;
            this._reference = "action";
        }

        public ActionAttibute(string prefix, string reference, string nameSpace, bool defaultVocabulary)
        {
            this._defaultVocabulary = defaultVocabulary;
            this._prefix = prefix;
            this._reference = reference;
            this._namespace = nameSpace;
        }

        public ActionAttibute(string value)
            : base()
        {
            Value = value;
        }
    }
}
