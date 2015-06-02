# BmobPaySdk
<p>Bmob的支付SDK相关的说明可以<a href="http://docs.bmob.cn/androidpay/index.html?menukey=fast_start&key=start_android_pay">查看</a></p>
# 特别注意
<p>下载完成后的第一次编译会出现以下错误：</p>
<pre>
   类型“Com.Bmob.Pay.Listener.FailureEventArgs”已定义了一个名为“FailureEventArgs”的具有相同参数类型的成员
   类型“Com.Bmob.Pay.Tool.FailEventArgs”已定义了一个名为“FailEventArgs”的具有相同参数类型的成员
</pre>
<br/>
<p>
直接双击第一个进入到生成的源码中，然后修改FailureEventArgs为FailureEventArgs1以及对应的构造函数，然后定位到同一个文件的第166和173行
将FailureEventArgs该成FailureEventArgs1，然后按照同样的方式修改第二个文件，并将222和229行的FailEventArgs改成FailEventArgs1，然后在
生成，注意一定要保证修改完成后保存，并且窗口打开在那。如果出现被覆写请不要选择覆盖，而是打一个空格保存再生成。
</p>
