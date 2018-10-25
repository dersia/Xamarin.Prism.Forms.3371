using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Prism.Forms3371.ContentProvider
{
    public interface IFakeContentProvider
    {
        Dictionary<string, string> Lookup { get; }
    }
}
