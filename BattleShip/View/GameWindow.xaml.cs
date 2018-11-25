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
using BattleShip.Model;

namespace BattleShip.View
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        Controller.Controller controller;
        Label[,] seaBattle;

        string keys = "ABCDEFGHTJ";
        string values = "0123456789";

        public GameWindow()
        {
            InitializeComponent();
            seaBattle = new Label[10, 10];
            controller = new Controller.Controller();
            double desctopWidth = SystemParameters.VirtualScreenWidth;
            double desctopHeight = SystemParameters.VirtualScreenHeight;

            double formWidth = desctopWidth * 0.7;
            double formHeight = desctopHeight* 0.7;
            this.Height = formHeight;
            this.Width = formWidth;
            this.ResizeMode = ResizeMode.CanMinimize;
            }

        public GameWindow(Controller.Controller c, Label[,] sb, Canvas canv)
        {
            controller = c;
            seaBattle = sb;
            canvas = canv;
            
        }
        //private void CreateOwnerBattlefield()
        //{
        //    double posStepY = this.Height / 15;
        //    double posStepX = this.Width / 15/2;
        //    double startPosX = posStepX;
        //    double startPosY = posStepY;
        //    double curPosX = startPosX;
        //    double curPosY = startPosY;
        //    for (int i = 0; i < 11; i++)
        //    {
        //        curPosX = startPosX;
        //        for (int j = 0; j < 11; j++)
        //        {
        //            Label l = new Label();
        //            l.Height = posStepY;
        //            l.Width = posStepX;
        //            l.Background = Brushes.AliceBlue;
        //            l.BorderBrush = Brushes.Black;
        //            l.BorderThickness = new Thickness(1);
        //            l.Margin = new Thickness(curPosX, curPosY, 0, 0);
        //            l.MouseDown += Label_click;
        //            l.MouseDoubleClick += Label_Doubleclick;
        //            canvas.Children.Add(l);
        //            curPosX += posStepX;
        //            if (i > 0 && j > 0)
        //            {
        //                seaBattle[i - 1, j - 1] = l;
        //            }
        //            else if(i == 0 && j > 0)
        //            {
        //                //l.Content =
        //            }

        //        }
        //        curPosY += posStepY;
        //    }
        //}

        private void CreateButtons()
        {

        }
        

        private void DrawShips()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (controller.IsDeck(i, j)) seaBattle[i, j].Background = Brushes.Black;
                }
            }
        }
    }
}
