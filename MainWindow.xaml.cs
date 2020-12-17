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

namespace tili_toli
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
        int lepesek = 0;
        private void gomb1_Click(object sender, RoutedEventArgs e)
        {
            Button egyikgomb = sender as Button;
            Button nullagomb = (Button)FindName("Button0");
            int vTav = Math.Abs((int)(egyikgomb.Margin.Left - nullagomb.Margin.Left));
            int fTav = Math.Abs((int)(egyikgomb.Margin.Top - nullagomb.Margin.Top));
            if ((vTav <120 && fTav == 0) || (fTav < 120 && vTav == 0))
            {
                var seged = egyikgomb.Margin;
                egyikgomb.Margin = nullagomb.Margin;
                nullagomb.Margin = seged;
                lepesek++;
                lepes.Text = Convert.ToString(lepes);
                MessageBox.Show("Nyertél!");
            }
        }
        public void Megkeveres()
        {
            Random r = new Random();
            for (int i = 0; i < 40; i++);
            {
                Button nullagomb = (Button)FindName("gomb0");
                string button = "button" + r.Next(1, 9);
                Button gomb = (Button)FindName("button");
                int vTav = Math.Abs((int)(nullagomb.Margin.Left - nullagomb.Margin.Left));
                int fTav = Math.Abs((int)(gomb.Margin.Top - gomb.Margin.Top));
                if ((vTav < 120 && fTav == 0) || (fTav < 120 && vTav == 0))
                {
                    var asd = gomb.Margin;
                    gomb.Margin = nullagomb.Margin;
                    nullagomb.Margin = asd;
                }
        }
    }

        private void ujgomb_Click(object sender, RoutedEventArgs e)
        {
            lepesek = 0;
            lepes.Text = Convert.ToString(lepes);
            Megkeveres();

        }
    }
