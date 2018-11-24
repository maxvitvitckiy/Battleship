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
using System.Windows.Shapes;

namespace BattleShip.View
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();

            double desctopWidth = SystemParameters.VirtualScreenWidth;
            double desctopHeight = SystemParameters.VirtualScreenHeight;

            double formWidth = desctopWidth * 0.7;
            double formHeight = desctopHeight* 0.7;
            this.Height = formHeight;
            this.Width = formWidth;
            this.ResizeMode = ResizeMode.CanMinimize;
            CreateOwnerBattlefield();


        }

        private void CreateOwnerBattlefield()
        {
            double posStepY = this.Height / 13;
            double posStepX = this.Width / 13/2;
            double startPosX = posStepX;
            double startPosY = posStepY;
            double curPosX = startPosX;
            double curPosY = startPosY;
            for (int i = 0; i < 11; i++)
            {
                if (i == 0)
                {
                    Label l = new Label();
                    l.Height = posStepY;
                    l.Width = posStepX;
                    l.Background = Brushes.AliceBlue;
                    l.BorderBrush = Brushes.Black;
                    l.BorderThickness = new Thickness(1);
                    l.Margin = new Thickness(curPosX, curPosY, 0, 0);
                    canvas.Children.Add(l);
                }
                curPosX = startPosX;
                for (int j = 0; j < 11; j++)
                {
                    if (j == 0)
                    {
                        Label l = new Label();
                        l.Height = posStepY;
                        l.Width = posStepX;
                        l.Background = Brushes.AliceBlue;
                        l.BorderBrush = Brushes.Black;
                        l.BorderThickness = new Thickness(1);
                        l.Margin = new Thickness(curPosX, curPosY, 0, 0);
                        canvas.Children.Add(l);
                    }
                    else
                    {
                        Rectangle l = new Rectangle();
                        l.Height = posStepY;
                        l.Width = posStepX;
                        l.Fill = Brushes.AliceBlue;
                        l.StrokeThickness = 1;
                        l.Stroke = Brushes.Black;
                        l.Margin = new Thickness(curPosX, curPosY, 0, 0);
                        l.MouseDown += rectangle_click;
                        canvas.Children.Add(l);
                    }
                    curPosX += posStepX;
                }
                curPosY += posStepY;
            }
        }

        private void rectangle_click(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
