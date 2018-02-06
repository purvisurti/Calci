using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CALCULATOR1
{
    class PrintNumber
    {

        TextView subans, ans;
        int temp;

        public PrintNumber(TextView tv, TextView ans)
        {
            this.subans = tv;
            this.ans = ans;
        }
        public void show(Button n, string oper, int temp, Calculate calc)
        {
            if (oper.Equals(""))
                subans.Text += n.Text;

            else if (oper.Contains("Add"))
            {
                int no;
                subans.Text += n.Text;
                var data = subans.Text.Split(new char[] { '+', '*', '/', '-' });
                var data1 = data[data.Length - 1];
                int.TryParse(data1, out no);

                ans.Text = calc.cal(temp, no) + "";


            }
        }
    }
}
