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
   public abstract class Calculate
    {
        public abstract int cal(int a,int b);
    }
    public class Add : Calculate
    {
        public override int cal(int a, int b)
        {
            return a + b;
        }
    }
    public class Sub : Calculate
    {
        public override int cal(int a, int b)
        {
            return a - b;
        }
    }
    public class Mul : Calculate
    {
        public override int cal(int a, int b)
        {
            return a * b;
        }
    }
    public class Div : Calculate
    {
        public override int cal(int a, int b)
        {
            return a / b;
        }
    }

}