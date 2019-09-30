using System;
using System.Collections.Generic;
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



namespace WpfApp1
{
    /// <summary>
    /// MyGridView.xaml の相互作用ロジック
    /// </summary>
    public partial class MyGridView : UserControl
    {
        //private  int GRID_SIZE = 20;
        int delta = 20;
        public MyGridView()
        {
            InitializeComponent();
        }

        private void MyCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            delta = 20;

            BuildView(delta);
        }

        private void MyCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            BuildView(delta);
        }
        // キャンバスに線を描画する
        private void BuildView(int GRID_SIZE)
        {
            myCanvas.Children.Clear();


            Style lineStyle = this.FindResource("GridLineStyle") as Style;

            for (int i = 0; i < this.ActualWidth; i += GRID_SIZE)
            {
                Line line = new Line()
                {
                    X1 = i,
                    Y1 = 0,
                    X2 = i,
                    Y2 = this.ActualHeight,
                    Style = lineStyle
                };

                myCanvas.Children.Add(line);
            }

            for (int i = 0; i < this.ActualHeight; i += GRID_SIZE)
            {
                Line line = new Line()
                {
                    X1 = 0,
                    Y1 = i,
                    X2 = this.ActualWidth,
                    Y2 = i,
                    Style = lineStyle
                };

                myCanvas.Children.Add(line);
            }
        }

        private void MyCanvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {

        }

        private void MyCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void myCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("ころころ");
            //int delta = Math.Abs(e.Delta / 120);
            System.Diagnostics.Debug.WriteLine("増ぽち");
            delta = delta*2;
            BuildView(delta);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("減ぽち");
            delta = delta / 2;
            BuildView(delta);
        }
    }
}
