MyCalculator
============

A simple calculator written by C#

### features
* ��������̣���װ�ࡢ����
* �򵥹���ģʽ+��̬�����á�

### update record

v0.1
* �������
* �򵥹���ģʽ������ɼӼ��˳��㷨
* ����UI�
* ʵ�ֻ�������

v0.2
* �������桢������ɫ������λ�õ�
* ���ӹ��ܣ���̬��ʾ�������ʽ
* ���Ӳ˵����ܣ����Ը��ơ�ճ��������������˳����ܣ���ӹ��ڹ���
* TODO����ӡ���ѧ��������ģ��

v0.3
* ��ѧ���������ڰ�ť̫�࣬��ÿ����ť�����һ��Click�¼���һ����ɵ���¡��Ľ������������е�Button����ͬһ��OnClick�¼���
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