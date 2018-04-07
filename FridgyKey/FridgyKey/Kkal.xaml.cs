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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Threading;
using System.Data.Linq;

namespace FridgyKey
{ 
    public partial class Kkal : Window
    {
        #region var declaration
        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        static int count_hack;
        Label l1, l2, l3, l4, l5, l6, l7, l8;
        Image i1, i2, i3, i4, i5;
        TextBox r1, r2, r3, r4, r5;
        SolidColorBrush Mcolor, Mcolor2;
        TextBox hack_txt;
        ComboBox combo;
        ListBox recipe;
        #endregion
        public Kkal()
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

            i1 = (Image)FindName("icon_r1");
            i2 = (Image)FindName("icon_r2");
            i3 = (Image)FindName("icon_r3");
            i4 = (Image)FindName("icon_r4");
            i5 = (Image)FindName("icon_r5");

            r1 = (TextBox)FindName("text_r1");
            r2 = (TextBox)FindName("text_r2");
            r3 = (TextBox)FindName("text_r3");
            r4 = (TextBox)FindName("text_r4");
            r5 = (TextBox)FindName("Text_r5");

            combo = (ComboBox)FindName("comboBox");
            hack_txt = (TextBox)FindName("hack_text");

            recipe = (ListBox)FindName("list_recipe");
            #endregion

            int count_hack = 0;

            // string connectionString = @"Data Source=DESKTOP-B9P5U74\SQLEXPRESS; Initial Catalog=FridgyKeyDB; Integrated Security=true;"; 
            // DataContext db = new DataContext(connectionString);

            //var queryHack = db.GetTable<Hack>();
             


            //            var query = db.GetTable<User>().Where(u => u.Age > 25).OrderBy(u => u.FirstName); 
            //            foreach (var user in query)
            //{ 
            //    Console.WriteLine("{0} \t{1} \t{2}", user.Id, user.FirstName, user.Age); 
            //} 
            /////////
            //List<string> list_products = new List<string>();
            //list_products.Add("Banan");
            //list_products.Add("Milk");
            //combo.ItemsSource  = list_products;
            string[] s = { "Banana", "Milk" };
            combo.ItemsSource = s;
            ///////////////////
            #region service
            Mcolor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#C2CAD1"));
            Mcolor2 = (SolidColorBrush)(new BrushConverter().ConvertFrom("#313937"));

            MyNotifyIcon = new System.Windows.Forms.NotifyIcon();
            MyNotifyIcon.Icon = new System.Drawing.Icon("Pusheen_Love.ico");
            MyNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(MyNotifyIcon_MouseDoubleClick);
            #endregion
            ///////////
            //FridgyKeyDB dc = new FridgyKeyDB(); 
            //var query = from s in dc.Songs
            //            select s;
            ////dataListBox.ItemsSource = query.ToList();
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

        private void list_recipe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RecipeView rv = new RecipeView();
            rv.Show(); 
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
        #endregion

       
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //добавить логику для подбора рецептов с данным ингредиентом
            //i1.Source = new BitmapImage(new Uri(@"/images/recipe/1.png", UriKind.Relative));// не работает ?????
            //r1.Text = "Name_of_recipe_for_selected_product";
            List<string> ls = new List<string>();
            //if recipe.ingred=combobox.item
            ls.Add("text this ingred");

            recipe.ItemsSource= ls;
        }
        private void text_r1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RecipeView rv = new RecipeView();
            rv.Show();
        }
    }
}
