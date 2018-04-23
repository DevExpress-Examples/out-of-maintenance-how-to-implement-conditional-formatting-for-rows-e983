using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace ConditionalRowFormatting {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class ColorValueConverter : MarkupExtension, IValueConverter {
        public int MaxValue { get; set; }
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            int count = MaxValue - (int)value;
            return new SolidColorBrush(GetGradientColor(count));
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return null;
        }
        #endregion
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
        private Color GetGradientColor(int count) {
            Color color = Color.FromRgb(0xff, 0xad, 0x5d);
            byte r = (byte)(color.R + (0xff - color.R) * count / MaxValue);
            byte g = (byte)(color.G + (0xff - color.G) * count / MaxValue);
            byte b = (byte)(color.B + (0xff - color.B) * count / MaxValue);
            return Color.FromArgb(255, r, g, b);
        }
    }
}
