using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mob_lab1
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            
            var layout = new StackLayout {BackgroundColor=Color.Blue};
            
            var label = new Label
            {
                Text = "Clicker master 2000",
                TextColor = Color.Yellow,
                BackgroundColor = Color.Blue,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center,
                
            };
            
            var Button = new Button
            {
                Text = "Натисни мене",
                BackgroundColor = Color.Yellow,
                TextColor = Color.Blue,
                

            };
            Button.Clicked += V;
            
            
            Content = new StackLayout
            {
                Children =
            {
                label,
                Button
            }
            };

        }


       
        

        int count = 0;
        int t1 = 25;
        int t2 = 100;
        int t3 = 50;

        public Color StackLayout { get; private set; }

        public void V(object sender, EventArgs e)
        {

            count++;
            ((Button)sender).Text = $"Ви клікнули {count} разів.";
            ((Button)sender).BackgroundColor = Color.Yellow;
            bool count1 = Convert.ToBoolean(count);
            if (count == t1)
            {


                ((Button)sender).Text = $"25%";
                ((Button)sender).BackgroundColor = Color.Red;
                StackLayout = BackgroundColor = Color.Pink ;
            }
            if (count == t3)
            {
                ((Button)sender).Text = $"50%";
                ((Button)sender).BackgroundColor = Color.Green;
                StackLayout = BackgroundColor = Color.Coral;
            }
            if (count == t2)
            {
                var s = new StackLayout { BackgroundColor = Color.Gold };
                Label label = new Label
                {
                    Text = "~~Win!~~",
                    TextColor = Color.Red,
                    FontSize = 20,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.Center,
                };
                s.Children.Add(label);
                this.Content = s;
            }

        }


    }
        }
    

