using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;

namespace csvLoadClass
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[][] str=new string[30][];
            for (int loop = 0; loop < 30; ++loop)
            {
                str[loop] = new string[30];
            }
            List<string> sl = new List<string>();
            CSVLoadClass.LoadCsv(ref sl);
            this.label1.Content = sl.Count;
            this.label2.Content = sl[0];
/*            this.label3.Content = sl[1].ToString();
            this.label4.Content = sl[2].ToString();
            this.label5.Content = sl[3].ToString();
            this.label6.Content = sl[4].ToString();
            this.label7.Content = sl[5].ToString();
            this.label8.Content = sl[6].ToString();
            this.label9.Content = sl[7].ToString();
            this.label10.Content = sl[8].ToString();*/

            CSVLoadClassVer2.LoadCSV(ref str);
            this.label3.Content = str[1][3];
        }
    }
}
