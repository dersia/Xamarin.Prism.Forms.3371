using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Prism.Forms3371.ContentProvider
{
    public class FakeContentProvider : IFakeContentProvider
    {
        public Dictionary<string, string> Lookup { get; } = new Dictionary<string, string>
        {
            ["1"] = "This",
            ["2"] = "Looks",
            ["3"] = "Up",
            ["4"] = "Some",
            ["5"] = "Fake",
            ["6"] = "Data",
        };
    }
}
