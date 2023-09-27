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

namespace 第三堂
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int x, y, z;
            bool judge=true;
            List<double> Xx = new List<double>();
            List<double> Yy = new List<double>();
            List<double> Zz = new List<double>();
            List<bool> Yesno = new List<bool>();

            //輸入值是否為整數
            bool xx = int.TryParse(textbox1.Text, out x);
            bool yy = int.TryParse(textbox2.Text, out y);
            bool zz = int.TryParse(textbox3.Text, out z);

            if (!xx || !yy || !zz)
            {
                MessageBox.Show("請輸入整數。", "輸入錯誤");
            }
            else if (x < 0)
            {
                MessageBox.Show($"輸入值為{x}，請輸入大於0的整數", "輸入錯誤");
            }
            else if (y < 0)
            {
                MessageBox.Show($"輸入值為{y}，請輸入大於0的整數", "輸入錯誤");
            }
            else if (z < 0)
            {
                MessageBox.Show($"輸入值為{z}，請輸入大於0的整數", "輸入錯誤");
            }

            //判斷是否構成三角形
            BianChang(x, y, z, Yesno, judge);

            //存取
            //textblock1.Text = $"邊長{x},{y},{z},{judge}";
           /* Xx.Add(x);
            Yy.Add(y);
            Zz.Add(z);
            for(int i = 0; i < 4; i++)
            {
                textblock1.Text = $"邊長{x}";
            }*/
        }

        void BianChang(int x,int y,int z, List<bool> yesno,bool judge)
        {
            if ((x + z) > y && (x + y) > z && (z + y) > x) {
                label4.Content = $"邊長{x},{y},{z},可以構成三角形";
                label4.Background = Brushes.Green;
                judge = true;
                //yesno.Add(true);
            }
            else
            {
                label4.Content = $"邊長{x},{y},{z},不可構成三角形";
                label4.Background = Brushes.Red;
                judge = false;
                //yesno.Add(false);
            }
        }

        

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}



