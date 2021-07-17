using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfAppGiulioMVVM
{
    public class CultureAwareMultiBinding : MultiBinding
    {
        public CultureAwareMultiBinding() : base()
        {
            ConverterCulture = CultureInfo.CurrentCulture;
        }
    }
    public class CultureAwareBinding : Binding
    {
        public CultureAwareBinding() : base()
        {
            ConverterCulture = CultureInfo.CurrentCulture;
        }
        public CultureAwareBinding(string path) : base(path)
        {
            ConverterCulture = CultureInfo.CurrentCulture;
        }
    }
}
