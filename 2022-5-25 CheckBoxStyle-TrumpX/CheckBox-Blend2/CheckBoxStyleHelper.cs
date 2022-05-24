using System.Windows;

namespace CheckBox_Blend2
{
    public class CheckBoxStyleHelper : DependencyObject
    {
        public static double GetIconSize(DependencyObject obj)
        {
            return (double)obj.GetValue(IconSizeProperty);
        }

        public static void SetIconSize(DependencyObject obj, double value)
        {
            obj.SetValue(IconSizeProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.RegisterAttached("IconSize", typeof(double), typeof(CheckBoxStyleHelper), new PropertyMetadata(30d));
    }
}
