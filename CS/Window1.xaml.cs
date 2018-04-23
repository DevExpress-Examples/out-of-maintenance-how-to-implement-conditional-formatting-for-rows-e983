using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace ConditionalRowFormatting {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }

    public class SimpleData {
        public string Column1 { get; set; }
        public int Column2 { get; set; }

        public SimpleData() { }

        public SimpleData(string str1, int int2) {
            Column1 = str1;
            Column2 = int2;
        }
    }

    public class ColorValueConverter : MarkupExtension, IValueConverter {
        public int MaxValue { get; set; }

        #region IValueConverter Members
        public object Convert(object value, Type targetType,
        object parameter, CultureInfo culture) {
            int count = MaxValue - (int)value;

            int rStart = 0xff;
            int gStart = 0xad;
            int bStart = 0x5d;

            double r = rStart + (0xff - rStart) * count / MaxValue;
            double g = gStart + (0xff - gStart) * count / MaxValue;
            double b = bStart + (0xff - bStart) * count / MaxValue;

            return new SolidColorBrush(Color.FromArgb(255, 
                (byte)r, (byte)g, (byte)b));
        }

        public object ConvertBack(object value, Type targetType, 
        object parameter, CultureInfo culture) {
            return null;
        }
        #endregion

        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
