﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents; 
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace FridgyKey
{ 
    public partial class AddRecipe : Window
    {
        #region var declaration
        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        Label l1, l2, l3, l4, l5, l6, l7, l8;
        TextBox txtamount;
        SolidColorBrush Mcolor = new SolidColorBrush();
        SolidColorBrush Mcolor2 = new SolidColorBrush();
        ComboBox combo;
        #endregion
        public AddRecipe()
        {
            InitializeComponent();
            #region FindName
            l1 = (Label)FindName("label1");
            l2 = (Label)FindName("label2");
            l3 = (Label)FindName("label3");
            l4 = (Label)FindName("label4");
            l5 = (Label)FindName("label5");
            l6 = (Label)FindName("label6");
            l7 = (Label)FindName("label7");
            l8 = (Label)FindName("label8");
            txtamount = (TextBox)FindName("amount");
            combo = (ComboBox)FindName("comboBox");
            #endregion

            string[] ar = new string[] { "Banana", "Milk" }; //add to fridge combobox
            combo.ItemsSource = ar;

            #region service
            Mcolor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#C2CAD1"));
            Mcolor2 = (SolidColorBrush)(new BrushConverter().ConvertFrom("#313937"));

            MyNotifyIcon = new System.Windows.Forms.NotifyIcon();
            MyNotifyIcon.Icon = new System.Drawing.Icon("Pusheen_Love.ico");
            MyNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(MyNotifyIcon_MouseDoubleClick);
            #endregion
        }

        #region methods_menu
        #region methods_click_mouse
        private void Label1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            this.Close();
        }

        private void label7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            {
                About Menu = new About();
                Menu.Show();
                this.Close();
            }
        }
        private void Label8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Login Menu = new Login();
            Menu.Show();
            this.Close();
        }
        private void label2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GetRecipe Menu = new GetRecipe();
            Menu.Show();
            this.Close();
        }

        private void label3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AddProduct Menu = new AddProduct();
            Menu.Show();
            this.Close();
        }

        private void label6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Settings Menu = new Settings();
            Menu.Show();
            this.Close();
        }

        private void label5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Kkal Menu = new Kkal();
            Menu.Show();
            this.Close();
        }

        private void label4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AddRecipe Menu = new AddRecipe();
            Menu.Show();
            this.Close();
        }
        #endregion

        #region methods_move_mouse
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            l1.Foreground = Mcolor;
            //l1.FontWeight = FontWeights.SemiBold;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            l2.Foreground = Mcolor;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            l3.Foreground = Mcolor;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            l4.Foreground = Mcolor;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            l5.Foreground = Mcolor;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            l6.Foreground = Mcolor;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            l7.Foreground = Mcolor;
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            l8.Foreground = Mcolor;
        }
        #endregion 

        #region methods_mouse_leave
        private void label2_MouseLeave(object sender, MouseEventArgs e)
        {
            l2.Foreground = Mcolor2;
        }

        private void label1_MouseLeave(object sender, MouseEventArgs e)
        {
            l1.Foreground = Mcolor2;
        }

        private void label3_MouseLeave(object sender, MouseEventArgs e)
        {
            l3.Foreground = Mcolor2;
        }

        private void label4_MouseLeave(object sender, MouseEventArgs e)
        {
            l4.Foreground = Mcolor2;
        }

        private void label5_MouseLeave(object sender, MouseEventArgs e)
        {
            l5.Foreground = Mcolor2;
        }

        private void label6_MouseLeave(object sender, MouseEventArgs e)
        {
            l6.Foreground = Mcolor2;
        }

        private void label7_MouseLeave(object sender, MouseEventArgs e)
        {
            l7.Foreground = Mcolor2;
        }


        private void label8_MouseLeave(object sender, MouseEventArgs e)
        {
            l8.Foreground = Mcolor2;
        }
        #endregion
        #endregion

        #region methods_control_window
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        void MyNotifyIcon_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.WindowState = WindowState.Normal;
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                MyNotifyIcon.BalloonTipTitle = "Minimize Sucessful";
                MyNotifyIcon.BalloonTipText = "Minimized the app ";
                MyNotifyIcon.ShowBalloonTip(400);
                MyNotifyIcon.Visible = true;
            }
            else if (this.WindowState == WindowState.Normal)
            {
                MyNotifyIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }
        #endregion

        #region small logica
        private void btnLoadImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog
                //    {
                //        FileName = "image.jpg",
                //        InitialDirectory = "Lab4_5"
                //    };
                //    openFileDialog.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
                //    if (openFileDialog.ShowDialog() == true)
                //    {
                //        TextRange textRange = new TextRange(MainText.Document.ContentStart, MainText.Document.ContentEnd);
                //        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                //        {
                //            if (Path.GetExtension(openFileDialog.FileName).ToLower() == ".rtf")
                //                textRange.Load(fs, DataFormats.Rtf);
                //            else if (Path.GetExtension(openFileDialog.FileName).ToLower() == ".txt")
                //                textRange.Load(fs, DataFormats.Text);
                //            else
                //                textRange.Load(fs, DataFormats.Xaml);
                //        }
                //        this.Title = "TextEditor (" + openFileDialog.FileName + ") ";
                //    }
                //    else
                //    {
                //        throw new Exception("uncorrect extension");
                //    }
            }
            catch
            {
                MessageBox.Show("open error");
            }
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (!(combo.SelectedItem == null || txtamount.Text == ""))
            {
                //показать и добавить ингердиент
            }
            else
            {
                string s = "Please, confirm all field";
            }
        }
        private void btnCleanProduct_Click(object sender, RoutedEventArgs e)
        {
            txtamount.Text = "";
            combo.Text = "";
        }
        #endregion
    }
}
