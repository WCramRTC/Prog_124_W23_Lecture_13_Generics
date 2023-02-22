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

namespace Prog_124_W23_Lecture_13_Generics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TeamRoster<Player> seahawks = new TeamRoster<Player>();
        public MainWindow()
        {
            InitializeComponent();
            seahawks.AddPlayer(new FootballPlayer("Bander", "10", 30000000));

            // Boxing ( box and unbox )
            Player player = new FootballPlayer("Will", "7", 19);
            

            // Casting in programming means converting from one type to another

            int age = (int)54.7; // Explict Casting
            double alsoAge = 54; // Implicit Casting

            FootballPlayer teamPlayers = (FootballPlayer)player;
            MessageBox.Show(player2.GetType().ToString());

            // object
            // player
            // football player

            

        }
    }
}
