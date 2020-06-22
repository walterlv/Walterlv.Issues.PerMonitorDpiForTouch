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

namespace Walterlv.Issues.PerMonitorDpiForTouch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MouseMove += OnMouseMove;
            TouchMove += OnTouchMove;
            StylusMove += OnStylusMove;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            MouseDebugRun.Text = e.GetPosition(this).ToString();
        }

        private void OnTouchMove(object sender, TouchEventArgs e)
        {
            TouchDebugRun.Text = e.GetTouchPoint(this).Position.ToString();
        }

        private void OnStylusMove(object sender, StylusEventArgs e)
        {
            StylusDebugRun.Text = e.GetStylusPoints(this).FirstOrDefault().ToPoint().ToString();
        }
    }
}
