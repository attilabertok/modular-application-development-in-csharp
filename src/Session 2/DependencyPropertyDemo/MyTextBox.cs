using System.Windows;
using System.Windows.Controls;

namespace DependencyPropertyDemo
{
    public class MyTextBox : TextBox
    {
        public static readonly DependencyProperty DefaultTextProperty;
        public static readonly string DefaultTextPropertyName = "DefaultText";
        public string DefaultText
        {
            get => (string)GetValue(DefaultTextProperty);
            set => SetValue(DefaultTextProperty, value);
        }

        static MyTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyTextBox), new FrameworkPropertyMetadata(typeof(MyTextBox)));
            MyTextBox.DefaultTextProperty = DependencyProperty.Register(
                DefaultTextPropertyName,
                typeof(string),
                typeof(MyTextBox),
                new FrameworkPropertyMetadata(string.Empty));
        }
    }
}
