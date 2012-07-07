using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace idolcup
{
    public partial class MainPage : PhoneApplicationPage
    {
        List<string> a=new List<string>();
        string b, c;

        

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            init_list();
        //    IComparer<string> myComparer = new myReverserClass();
        //    a.Sort(myComparer);
//            a.Sort(Compare);
            startscreen.Source = new BitmapImage(new Uri("startscreen.jpg", UriKind.RelativeOrAbsolute));      
            next();
        }
        
    

        private void init_list()
        {
            a.Add("ckh.jpg");
            a.Add("gar.jpg");
            a.Add("ghs.jpg");
            a.Add("hgi.jpg");
            a.Add("hhj.jpg");
            a.Add("hje.jpg");
            a.Add("hjm.jpg");
            a.Add("hjw.jpg");
            a.Add("hm.jpg");
            a.Add("iu.jpg");
            a.Add("jessica.jpg");
            a.Add("jjh.jpg");
            a.Add("jy.jpg");
            a.Add("jyj.jpg");
            a.Add("khj.jpg");
            a.Add("kth.jpg");
            a.Add("lhl.jpg");
            a.Add("lmj.jpg");
            a.Add("lyh.jpg");
            a.Add("mgy.jpg");
            a.Add("sandra.jpg");
            a.Add("sh.jpg");
            a.Add("shg.jpg");
            a.Add("sjh.jpg");
            a.Add("sma.jpg");
            a.Add("sohee.jpg");
            a.Add("ssk.jpg");
            a.Add("suji.jpg");
            a.Add("sunny.jpg");
            a.Add("sy.jpg");
            a.Add("syj.jpg");
            a.Add("syr.jpg");
            a.Add("ty.jpg");
            a.Add("ya.jpg");
            Random rng = new Random();
            int n = a.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = a[k];
                a[k] = a[n];
                a[n] = value;
            }
        }

        private void next()
        {
            if (a.Count() == 1)
            {
                a.Add("end.jpg");
            }
            else
            {
                image1.Source = new BitmapImage(new Uri(a[0], UriKind.RelativeOrAbsolute));
                image2.Source = new BitmapImage(new Uri(a[1], UriKind.RelativeOrAbsolute));
                b = a[0];
                c = a[1];
                a.RemoveAt(0);
                a.RemoveAt(0);
            }
        }


        private void image1_Tap(object sender, GestureEventArgs e)
        {
            if (c != "end.jpg")
            {
                a.Add(b);
                next();

                //            MessageBox.Show("image1");
            }
            else
            {
                startscreen.Visibility = Visibility.Visible;
                a.Clear();
                init_list();
                next();
            }
        }

        private void image2_Tap(object sender, GestureEventArgs e)
        {
            if (c != "end.jpg")
            {
                a.Add(c);
                next();
                //            MessageBox.Show("image2");
            }
            else
            {
                startscreen.Visibility = Visibility.Visible;
                a.Clear();
                init_list();
                next();
            }
        }

        private void startscreen_Tap(object sender, GestureEventArgs e)
        {
            startscreen.Visibility =Visibility.Collapsed;
        }

    }
}