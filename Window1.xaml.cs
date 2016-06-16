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

namespace lb3
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void showColumnChart()
        {
            int[] array = new int[10];
            MainWindow a = new MainWindow();

            Random Rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = Rand.Next(-100, 100);
            }

            List<KeyValuePair<string, int>> valueList = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < 10; i++)
                valueList.Add(new KeyValuePair<string, int>(i + 1.ToString(), array[i]));

            Grafik.DataContext = valueList;
        }
    }
}
