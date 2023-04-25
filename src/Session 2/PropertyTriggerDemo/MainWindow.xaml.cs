using System.Windows.Controls;
using System.Windows.Input;

namespace PropertyTriggerDemo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProgrammaticBackgroundButton_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Border b) b.Background = System.Windows.Media.Brushes.LightGreen;
        }

        private void ProgrammaticBackgroundButton_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Border b) b.Background = System.Windows.Media.Brushes.Green;

            // Note that this line sets the background to the default value instead of clearing it.
            // this might cause problems if you want to use the default value in a style.
            // Try using the following line instead:
            // b.ClearValue(Border.BackgroundProperty);
        }
    }
}
