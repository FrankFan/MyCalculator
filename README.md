MyCalculator
============

A simple calculator written by C#

### features
* 面向对象编程：封装类、对象
* 简单工厂模式+多态的运用。

### update record

v0.1
* 搭建代码框架
* 简单工厂模式灵活生成加减乘除算法
* 界面UI搭建
* 实现基本运算

v0.2
* 美化界面、字体颜色、窗体位置等
* 增加功能：动态显示输入的算式
* 增加菜单功能：可以复制、粘贴计算结果；添加退出功能；添加关于功能
* TODO：填坑【科学计算器】模块

v0.3
* 科学计算器由于按钮太多，给每个按钮都添加一个Click事件是一件很傻的事。改进方法是让所有的Button公用同一个OnClick事件。
```csharp
	private void btnInput_Click(object sender, EventArgs e)
	{
		Button currentBtn = sender as Button;
		if (currentBtn != null && currentBtn.Tag != null)
		{
			string input = currentBtn.Tag.ToString();
			// TO DO Next...
		}
	}
```