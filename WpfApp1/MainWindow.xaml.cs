using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      
        private void img_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Move;
                string[] pic =(string[])e.Data.GetData(DataFormats.FileDrop);

               
                    BitmapImage myBitmapImage = new BitmapImage();
  
                    myBitmapImage.BeginInit();
                    myBitmapImage.UriSource = new Uri(pic[pic.Length-1]);
                    
                    myBitmapImage.DecodePixelWidth = 200;
                    myBitmapImage.EndInit();
                    img.Stretch = Stretch.Uniform;
                    img.Source = myBitmapImage;
                
                
                
            }
        }

      
    }
}
