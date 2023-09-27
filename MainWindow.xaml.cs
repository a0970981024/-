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
            int x,y,z;
            List<Triangle> test = new <Triangle>;
            bool xx = int.TryParse(textbox1.Text, out x);
            bool yy = int.TryParse(textbox2.Text, out y);
            bool zz = int.TryParse(textbox3.Text, out z);

            if (!xx || !yy || !zz) {
                MessageBox.Show("請輸入整數。", "輸入錯誤");
            } else if(x<0){
                MessageBox.Show($"輸入值為{x}，請輸入大於0的整數", "輸入錯誤");
            }
            else if (y < 0){
                MessageBox.Show($"輸入值為{y}，請輸入大於0的整數", "輸入錯誤");
            }
            else if (z < 0){
                MessageBox.Show($"輸入值為{z}，請輸入大於0的整數", "輸入錯誤");
            }




        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}



