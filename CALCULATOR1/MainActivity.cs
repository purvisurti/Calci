using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System;
using Android.Views;

namespace CALCULATOR1
{
    [Activity(Label = "CALCULATOR1", MainLauncher = true,Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        static int temp;
        string oper = "";
        PrintNumber print;
        TextView answer, subans;
        Calculate calc;
        Button c1, c2, c3, c4, c5, c6, c7, c8, c9, c0, cmul, cplus, cminus, cdiv, clear;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            findAllView();
            print = new PrintNumber(subans,answer);
            c1.Click += btnclick;
            c2.Click += btnclick;
            c3.Click += btnclick;
            c4.Click += btnclick;
            c5.Click += btnclick;
            c6.Click += btnclick;
            c7.Click += btnclick;
            c8.Click += btnclick;
            c9.Click += btnclick;
            c0.Click += btnclick;
            cplus.Click += delegate {
                oper = "Add";
                int.TryParse(subans.Text, out temp);
                subans.Append("+");
                calc = new Add();

            };
            cminus.Click += delegate {
                oper = "Add";
                int.TryParse(subans.Text, out temp);
                subans.Append("-");
                calc = new Sub();

            };
            cmul.Click += delegate {
                oper = "Add";
                int.TryParse(subans.Text, out temp);
                subans.Append("*");
                calc = new Mul();

            };
            cdiv.Click += delegate {
                oper = "Add";
                int.TryParse(subans.Text, out temp);
                subans.Append("/");
                calc = new Div();

            };
            clear.Click += delegate {
                subans.Text = "";
                answer.Text = "";
                oper = "";
            };
        }

        private void btnclick(object sender, EventArgs e)
        {
            Button b =(Button)sender ;
            if (answer.Text.Equals(""))
                print.show(b, oper, temp,calc);
            else
            {
                //int.TryParse(answer.Text, out temp);
                print.show(b, oper, temp,  calc);
            }
        }

        private void findAllView()
        {
            answer = FindViewById<TextView>(Resource.Id.answer);
            subans = FindViewById<TextView>(Resource.Id.subanswer);
            c1 = FindViewById<Button>(Resource.Id.c1);
            c2 = FindViewById<Button>(Resource.Id.c2);
            c3 = FindViewById<Button>(Resource.Id.c3);
            c4 = FindViewById<Button>(Resource.Id.c4);
            c5 = FindViewById<Button>(Resource.Id.c5);
            c6 = FindViewById<Button>(Resource.Id.c6);
            c7 = FindViewById<Button>(Resource.Id.c7);
            c8 = FindViewById<Button>(Resource.Id.c8);
            c9 = FindViewById<Button>(Resource.Id.c9);
            c0 = FindViewById<Button>(Resource.Id.c0);
            cplus = FindViewById<Button>(Resource.Id.cplus);
            cminus = FindViewById<Button>(Resource.Id.cminus);
            cmul = FindViewById<Button>(Resource.Id.cmul);
            cdiv = FindViewById<Button>(Resource.Id.cdiv);

            clear = FindViewById<Button>(Resource.Id.clear);
        }
    }
}

