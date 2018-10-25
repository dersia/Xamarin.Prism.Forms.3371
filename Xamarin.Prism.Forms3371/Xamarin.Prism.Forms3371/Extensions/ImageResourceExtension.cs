using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Prism.Forms3371.Extensions
{
    [ContentProperty("Source")]
    public class ImageResourceExtension:IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if(Source == null)
                return null;

            return ImageSource.FromResource(Source);
        }
    }
}
