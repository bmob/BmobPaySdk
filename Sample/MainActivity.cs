using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Bmob.Pay.Tool;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity,IPayListener
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            BmobPay.Init(BaseContext, "756640b24c51a3db47bc386df0534570");
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate {
                new BmobPay(this).Pay(0.02, "测试商品", this);
            };
        }

        public void Fail(int p0, string p1)
        {
            Toast.MakeText(this, "出现异常" + p0 + " " + p1, ToastLength.Long).Show();
        }

        public void OrderId(string p0)
        {
            Toast.MakeText(this, "订单号为" + p0, ToastLength.Long).Show();
        }

        public void Succeed()
        {
            Toast.MakeText(this, "成功", ToastLength.Long).Show();
        }

        public void Unknow()
        {
            Toast.MakeText(this, "未知错误", ToastLength.Long).Show();
        }
    }
}

