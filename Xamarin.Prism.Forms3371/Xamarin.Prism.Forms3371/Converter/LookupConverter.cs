using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin.Prism.Forms3371.ContentProvider;

namespace Xamarin.Prism.Forms3371.Converter
{
    public class LookupConverter : IValueConverter
    {
        private readonly IFakeContentProvider _fakeContentProvider;

        public LookupConverter(IFakeContentProvider fakeContentProvider)
        {
            _fakeContentProvider = fakeContentProvider;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(_fakeContentProvider.Lookup.TryGetValue(value.ToString(), out var data))
                return data;
            return value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) 
            => throw new NotImplementedException();
    }
}
