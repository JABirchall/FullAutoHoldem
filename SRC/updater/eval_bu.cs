using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
public class eval_bu : UserControl
{
	private HtmlDocument eval_a;
	private string eval_b = "";
	public WebBrowser c;
	private int eval_d;
	private IContainer eval_e;
	public eval_bu()
	{
		this.eval_a();
		this.c = new WebBrowser();
		this.c.Location = new Point(0, 0);
		this.c.MinimumSize = new Size(20, 20);
		this.c.Name = "web1";
		this.c.TabIndex = 4;
		this.c.WebBrowserShortcutsEnabled = false;
		base.Controls.Add(this.c);
	}
	public void b()
	{
		if (true)
		{
		}
		FileStream documentStream = File.Open("status.html", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
		this.c.DocumentStream = documentStream;
		this.eval_a = this.c.Document;
		this.c.Size = new Size(base.Width - 4, base.Height - 4);
		this.eval_a.Write("<body leftmargin='1'><font size=2>");
	}
	private void eval_a(string A_0, int A_1, int A_2)
	{
		while (true)
		{
			if (true)
			{
			}
			this.eval_b = "h" + A_1.ToString() + "l" + A_2.ToString();
			string text = string.Concat(new string[]
			{
				"<div id='",
				this.eval_b,
				"' style=\"margin-top='0';margin-bottom='0'\">",
				A_0,
				"</div>"
			});
			this.eval_a.Write(text);
			HtmlElement elementById = this.eval_a.GetElementById(this.eval_b);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (elementById != null)
					{
						num = 2;
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					elementById.ScrollIntoView(true);
					num = 1;
					continue;
				}
				break;
			}
		}
	}
	private void eval_a(string A_0)
	{
		this.eval_a.Write(A_0);
	}
	public void eval_c(string A_0)
	{
		if (true)
		{
		}
		this.eval_d++;
		this.eval_a(A_0, 1, this.eval_d);
	}
	public void b(string A_0)
	{
		this.eval_a(A_0);
	}
	protected override void Dispose(bool disposing)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
				goto IL_44;
			case 1:
				this.eval_e.Dispose();
				num = 0;
				continue;
			case 3:
				num = 4;
				continue;
			case 4:
				if (this.eval_e != null)
				{
					if (true)
					{
					}
					num = 1;
					continue;
				}
				goto IL_68;
			}
			if (!disposing)
			{
				break;
			}
			num = 3;
		}
		IL_44:
		IL_68:
		base.Dispose(disposing);
	}
	private void eval_a()
	{
		if (true)
		{
		}
		base.SuspendLayout();
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
