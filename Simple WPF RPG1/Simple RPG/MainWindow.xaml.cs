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
using Engine.ViewModels;

namespace Simple_RPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;
        public MainWindow()
        {
            InitializeComponent();
            _gameSession = new GameSession();
            //This changes the data context of the window so that the bindings are grabbing values from the newly instantiated GameSession _gameSession.
            DataContext = _gameSession;

        }
        private void OnClickMoveDirection (object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            switch (clickedButton.Content)
            {
                case "North":
                    _gameSession.MoveDirection("North");
                    break;
                case "East":
                    _gameSession.MoveDirection("East");
                    break;
                case "South":
                    _gameSession.MoveDirection("South");
                    break;
                case "West":
                    _gameSession.MoveDirection("West");
                    break;
                default:
                    break;
            }
}
        private void OnClickMoveEast (object sender, RoutedEventArgs e)
        {

        }
        private void OnClickMoveSouth (object sender, RoutedEventArgs e)
        {

        }
        private void OnClickMoveWest(object sender, RoutedEventArgs e)
        {

        }

        private void Test(object sender, RoutedEventArgs e)
        {
            _gameSession.CurrentPlayer.Gold += 10;
        }

    }
}
