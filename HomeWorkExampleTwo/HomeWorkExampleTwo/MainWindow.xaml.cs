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

namespace HomeWorkExampleTwo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double buttonPositionX1, buttonPositionY , buttonPositionX2;
        private double marginForInvisibleButtonSpace = 10; // Поле для визуального пространства кнопки 
        Random rndX = new Random();
        Random rndY = new Random();
        int rangeStartX = 10;
        int rangeEndX = 680;
        int rangeStartY = 10;
        int rangeEndY = 430;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLocationCheck()
        {
            buttonPositionY = untouchableButton.Margin.Top-marginForInvisibleButtonSpace;
            buttonPositionX1 = untouchableButton.Margin.Left - marginForInvisibleButtonSpace;
            buttonPositionX2 = untouchableButton.Margin.Left + untouchableButton.Width + marginForInvisibleButtonSpace;
        }


        private bool CheckButton(MouseEventArgs e)
        {
            if(e.GetPosition(null).X >= buttonPositionX1 && e.GetPosition(null).X <= buttonPositionX2)
            {
                if(e.GetPosition(null).Y >= buttonPositionY)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonLocationCheck();
            if (CheckButton(e))
            {
                untouchableButton.Margin = new Thickness(Convert.ToDouble(rndY.Next(rangeStartX, rangeEndX)),Convert.ToDouble(rndY.Next(rangeStartY, rangeEndY)),0,0) ;
            }           
        }

        
    }
}
