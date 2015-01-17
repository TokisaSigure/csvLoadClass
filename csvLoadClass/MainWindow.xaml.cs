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
            ArrayList al = new ArrayList();
            CSVLoadClass.LoadCsv(ref al);
            this.label1.Content = al.Capacity;
            this.label2.Content = al[0];
/*            this.label3.Content = al[1].ToString();
            this.label4.Content = al[2].ToString();
            this.label5.Content = al[3].ToString();
            this.label6.Content = al[4].ToString();
            this.label7.Content = al[5].ToString();
            this.label8.Content = al[6].ToString();
            this.label9.Content = al[7].ToString();
            this.label10.Content = al[8].ToString();*/
        }
    }
}
