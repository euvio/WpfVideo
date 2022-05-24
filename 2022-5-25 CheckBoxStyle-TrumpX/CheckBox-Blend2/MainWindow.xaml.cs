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

namespace CheckBox_Blend2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
$@"
标题：复选框美化（beautiful checkbox）
作者：TrumpX
时间：2022年5月25日 05点20分
地点：中国广东省珠海市斗门区翠湖苑
"
                );
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(
$@"
标题：复选框美化（beautiful checkbox）
作者：TrumpX
时间：2022年5月25日 05点20分
地点：中国广东省珠海市斗门区翠湖苑
"
                );
        }
    }
}
