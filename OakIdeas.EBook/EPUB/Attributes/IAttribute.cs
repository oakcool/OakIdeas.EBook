using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.EBook.EPUB.Attributes
{
    public interface IAttribute
    {
        string Name { get; }
        string Value { get; set; }
    }
}
