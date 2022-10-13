using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlueScreen
{
    public partial class MainWindow : Window
    {
        ImageBrush background = new ImageBrush();
        public MainWindow()
        {
            InitializeComponent();
            background.ImageSource = BitmapConverter.ImageSourceFromBitmap(Properties.Resources.image);
            Window1.Background = background;
        }

        private void Close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow Window1 = new MainWindow();
            Window1.Show();
        }
    }
}
