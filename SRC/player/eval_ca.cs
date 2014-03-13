using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using System.Xml;
public class eval_ca : UserControl
{
	public float eval_a;
	private decimal eval_b;
	private decimal eval_c = 100.0m;
	private decimal eval_d;
	private string eval_e;
	private eval_by eval_f;
	private string eval_g;
	private decimal eval_h;
	private decimal eval_i;
	private TextWriter j;
	private HtmlDocument eval_k;
	public WebBrowser l;
	private int eval_m;
	private string eval_n = "";
	private string eval_o = "";
	private string eval_p = "";
	private string eval_q = "";
	private int eval_r;
	private int eval_s;
	private IContainer eval_t;
	public eval_ca(eval_by A_0)
	{
		this.eval_f = A_0;
		this.eval_a();
		base.Resize += new EventHandler(this.eval_a);
		this.l.AllowNavigation = true;
		this.l.ScriptErrorsSuppressed = false;
		this.l.WebBrowserShortcutsEnabled = true;
		this.eval_f.eval_cg.eval_ba.DoubleClick += new EventHandler(this.eval_b);
		this.eval_s = global::eval_s.eval_a(20, 50);
	}
	private void eval_b(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.eval_f.eval_cg.eval_ba.Text = "0";
		this.eval_d = 0m;
	}
	private string eval_a(decimal A_0, decimal A_1, string A_2)
	{
		string text;
		while (true)
		{
			text = A_0.ToString("N1");
			this.eval_a += (float)A_0;
			this.eval_f.eval_cg.eval_be.Text = Math.Round((double)(this.eval_a / (float)this.eval_r), 2).ToString();
			this.eval_d += A_1;
			this.eval_f.eval_cg.eval_ba.Text = this.eval_d.ToString();
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 0:
					goto IL_106;
				case 1:
					goto IL_108;
				case 2:
					this.eval_b = A_0;
					this.eval_f.eval_cg.eval_bg.Text = text + "/" + A_2;
					num = 1;
					continue;
				case 3:
					if (A_0 < this.eval_c)
					{
						num = 4;
						continue;
					}
					goto IL_163;
				case 4:
					this.eval_c = A_0;
					this.eval_f.eval_cg.eval_bc.Text = text + "/" + A_2;
					num = 0;
					continue;
				case 5:
					if (A_0 > this.eval_b)
					{
						if (true)
						{
						}
						num = 2;
						continue;
					}
					goto IL_108;
				}
				break;
				IL_108:
				num = 3;
			}
		}
		IL_106:
		IL_163:
		eval_x.eval_a(A_0, A_1, this.eval_f.eval_bc);
		return text;
	}
	private void eval_a(object A_0, HtmlElementEventArgs A_1)
	{
		while (true)
		{
			HtmlElement htmlElement = ((HtmlDocument)A_0).ActiveElement;
			int num = 13;
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (!(htmlElement == null))
					{
						num = 4;
						continue;
					}
					goto IL_73;
				case 2:
					if (htmlElement != null)
					{
						num = 7;
						continue;
					}
					return;
				case 3:
					num = 12;
					continue;
				case 4:
					goto IL_16C;
				case 5:
					num = 8;
					continue;
				case 6:
					if (htmlElement.Id != "")
					{
						if (true)
						{
						}
						num = 10;
						continue;
					}
					return;
				case 7:
					num = 6;
					continue;
				case 8:
					goto IL_16C;
				case 9:
					goto IL_73;
				case 10:
					Process.Start(new ProcessStartInfo
					{
						Arguments = this.eval_f.eval_au() + htmlElement.Id,
						FileName = "C:\\Program Files\\Internet Explorer\\iexplore.exe"
					});
					num = 0;
					continue;
				case 11:
					if (htmlElement.TagName == "TABLE")
					{
						num = 3;
						continue;
					}
					goto IL_C1;
				case 12:
					if (htmlElement.Id != "")
					{
						num = 9;
						continue;
					}
					goto IL_C1;
				case 13:
					if (htmlElement.TagName != "A")
					{
						num = 5;
						continue;
					}
					goto IL_73;
				}
				break;
				IL_73:
				num = 2;
				continue;
				IL_C1:
				htmlElement = htmlElement.Parent;
				num = 1;
				continue;
				IL_16C:
				num = 11;
			}
		}
	}
	private void eval_a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.l.Size = new Size(base.Width - 30, base.Height - 10);
		this.eval_m = (this.l.Width - 60) / 10;
	}
	public void eval_e(string A_0)
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			int num = 7;
			while (true)
			{
				string path;
				switch (num)
				{
				case 0:
					if (A_0.Length > 0)
					{
						num = 3;
						continue;
					}
					path = this.eval_f.eval_au() + global::eval_s.eval_a() + "hands.html";
					num = 6;
					continue;
				case 1:
					this.j.Flush();
					this.j.Close();
					num = 5;
					continue;
				case 2:
					return;
				case 3:
				{
					int length = A_0.IndexOf(".");
					path = A_0.Substring(0, length) + "hands.html";
					num = 4;
					continue;
				}
				case 4:
					goto IL_D6;
				case 5:
					goto IL_8A;
				case 6:
					goto IL_D6;
				case 8:
					if (this.j != null)
					{
						num = 1;
						continue;
					}
					goto IL_8A;
				case 9:
					this.eval_n = A_0;
					num = 8;
					continue;
				}
				if (this.eval_n != A_0)
				{
					num = 9;
					continue;
				}
				break;
				IL_8A:
				num = 0;
				continue;
				IL_D6:
				if (true)
				{
				}
				FileStream stream = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
				this.j = new StreamWriter(stream);
				string value = "<body leftmargin='1' topmargin='0'>";
				this.j.Write(value);
				num = 2;
			}
			return;
		}
		}
		goto IL_0E;
	}
	public void e()
	{
		if (true)
		{
		}
		FileStream documentStream = File.Open("hands.html", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
		this.l.DocumentStream = documentStream;
		this.eval_k = this.l.Document;
		string text = "<body leftmargin='1' topmargin='0'>";
		this.eval_k.Write(text);
		this.l.Document.Click += new HtmlElementEventHandler(this.eval_a);
	}
	private void eval_c(string A_0)
	{
		if (true)
		{
		}
		string text = "<div style=\"margin-top='0';margin-bottom='0'\">" + A_0 + "</div>";
		this.eval_k.Write(text);
		this.eval_k.Body.ScrollTop = this.eval_k.Body.ScrollRectangle.Height;
	}
	private void eval_b(string A_0)
	{
		this.eval_k.Write(A_0);
	}
	private void a(string A_0)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (true)
				{
				}
				num = 1;
				continue;
			case 1:
				if (this.eval_r % 10 == 1)
				{
					num = 3;
					continue;
				}
				goto IL_7A;
			case 3:
				goto IL_78;
			}
			if (this.eval_r <= 1)
			{
				goto IL_7A;
			}
			num = 0;
		}
		IL_78:
		A_0 = "<br><br>" + A_0;
		this.eval_c(A_0);
		this.j.Write(A_0);
		return;
		IL_7A:
		this.eval_b(A_0);
		this.j.Write(A_0);
	}
	public void eval_c()
	{
		this.eval_g = this.eval_p;
		this.eval_e = this.eval_q;
	}
	public void eval_b(decimal A_0)
	{
		this.eval_h = A_0;
	}
	public void eval_a(int A_0)
	{
		this.eval_r = A_0;
	}
	public int eval_b()
	{
		return this.eval_r;
	}
	public void eval_a(decimal A_0)
	{
		this.eval_i = A_0;
	}
	public void eval_d(string A_0)
	{
		this.eval_o = A_0;
	}
	public void eval_g(string A_0)
	{
		this.eval_p = A_0;
	}
	public void eval_f(string A_0)
	{
		this.eval_q = A_0;
	}
	public bool eval_d()
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			string text4;
			while (true)
			{
				string text = this.eval_a(this.eval_h, this.eval_i, this.eval_o);
				this.eval_g = this.eval_g.Replace("&nbsp;", "");
				int num = this.eval_m - 28;
				string text2 = string.Concat(new string[]
				{
					"<a target='_blank' id='",
					this.eval_e,
					"' href='",
					this.eval_f.eval_au(),
					this.eval_e,
					"'>",
					this.eval_r.ToString(),
					"</a>"
				});
				string text3 = string.Concat(new object[]
				{
					"<td><table cellpadding='0' cellspacing='0' width='",
					num,
					"'><tr><td><font size='1'>",
					text,
					"</font></td><td align='right'><font size='1'>",
					text2,
					"</font></td></tr></table></td>"
				});
				text4 = string.Concat(new string[]
				{
					"<table id='",
					this.eval_e,
					"' width='",
					this.eval_m.ToString(),
					"' border='1' align='left' cellpadding='0' cellspacing='0'><tr><td style=width='28' rowspan='2'>",
					this.eval_g,
					"</td>",
					text3,
					"</tr><tr><td><font size='2' color='"
				});
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					case 0:
						goto IL_23A;
					case 1:
						text4 += "black'>";
						num2 = 5;
						continue;
					case 2:
						if (true)
						{
						}
						if (this.eval_i == 0m)
						{
							num2 = 1;
							continue;
						}
						num2 = 3;
						continue;
					case 3:
						if (this.eval_i < 0m)
						{
							num2 = 6;
							continue;
						}
						text4 += "green'>";
						num2 = 0;
						continue;
					case 4:
						goto IL_1D5;
					case 5:
						goto IL_21E;
					case 6:
						text4 += "red'>";
						num2 = 4;
						continue;
					}
					break;
				}
			}
			IL_1D5:
			IL_21E:
			IL_23A:
			text4 = text4 + this.eval_i.ToString() + "<font></td></tr></table>";
			this.a(text4);
			this.j.Flush();
			return true;
		}
		}
		goto IL_0E;
	}
	public void eval_a(int A_0, decimal A_1, string A_2, string A_3, float A_4)
	{
		while (true)
		{
			this.eval_a = A_4;
			this.eval_d = A_1;
			this.eval_f.eval_cg.eval_be.Text = Math.Round((double)(this.eval_a / (float)A_0), 2).ToString();
			this.eval_f.eval_cg.eval_ba.Text = this.eval_d.ToString("N0");
			this.eval_f.eval_cg.eval_bg.Text = A_2;
			int num = A_2.IndexOf("/");
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 0:
					if (num > 0)
					{
						num2 = 5;
						continue;
					}
					goto IL_E0;
				case 1:
					goto IL_E0;
				case 2:
					return;
				case 3:
					if (num > 0)
					{
						num2 = 4;
						continue;
					}
					return;
				case 4:
					this.eval_c = decimal.Parse(A_3.Substring(0, num));
					num2 = 2;
					continue;
				case 5:
					if (true)
					{
					}
					this.eval_b = decimal.Parse(A_2.Substring(0, num));
					num2 = 1;
					continue;
				}
				break;
				IL_E0:
				this.eval_f.eval_cg.eval_bc.Text = A_3;
				num = A_3.IndexOf("/");
				num2 = 3;
			}
		}
	}
	public static bool eval_a(string A_0, int A_1)
	{
		if (true)
		{
		}
		switch (0)
		{
		case 0:
		{
			IL_16:
			A_1 = 2;
			A_0 += eval_bw.eval_a(0);
			XmlDocument xmlDocument = new XmlDocument();
			string text = "";
			bool result;
			try
			{
				while (true)
				{
					xmlDocument.Load(A_0);
					SignedXml signedXml = new SignedXml(xmlDocument);
					XmlNode xmlNode = xmlDocument.GetElementsByTagName(eval_bw.a(), "http://www.w3.org/2000/09/xmldsig#")[0];
					signedXml.LoadXml((XmlElement)xmlNode);
					int num = 7;
					while (true)
					{
						string text2;
						XmlNode xmlNode2;
						int num2;
						TimeSpan timeSpan;
						switch (num)
						{
						case 0:
							text2 = eval_bw.eval_a(A_1);
							xmlNode2 = xmlDocument.GetElementsByTagName(text2)[0];
							num = 9;
							continue;
						case 1:
							goto IL_162;
						case 2:
							goto IL_167;
						case 3:
							if (num2 > 0)
							{
								num = 4;
								continue;
							}
							goto IL_1E6;
						case 4:
							result = true;
							num = 1;
							continue;
						case 5:
							if (A_1 == 0)
							{
								num = 2;
								continue;
							}
							goto IL_1E6;
						case 6:
							if (timeSpan.Hours > 22)
							{
								num = 10;
								continue;
							}
							goto IL_E4;
						case 7:
							if (signedXml.CheckSignature(global::eval_s.bc))
							{
								num = 0;
								continue;
							}
							goto IL_1E6;
						case 8:
							goto IL_E4;
						case 9:
							if (A_1 != 2)
							{
								num = 11;
								continue;
							}
							goto IL_167;
						case 10:
							num2++;
							num = 8;
							continue;
						case 11:
							num = 5;
							continue;
						case 12:
							goto IL_1F2;
						}
						break;
						IL_E4:
						num = 3;
						continue;
						IL_167:
						text = text2 + " " + xmlNode2.InnerText;
						DateTime d = DateTime.Parse(text);
						DateTime now = DateTime.Now;
						timeSpan = d - now;
						num2 = timeSpan.Days;
						num = 6;
						continue;
						IL_1E6:
						num = 12;
					}
				}
				IL_162:
				return result;
				IL_1F2:
				goto IL_35;
			}
			catch
			{
				goto IL_35;
			}
			return result;
			IL_35:
			MessageBox.Show(A_0 + " " + text);
			File.Delete(A_0);
			return false;
		}
		}
		goto IL_16;
	}
	protected override void Dispose(bool disposing)
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 0:
				this.eval_t.Dispose();
				num = 2;
				continue;
			case 1:
				if (this.eval_t != null)
				{
					num = 0;
					continue;
				}
				goto IL_68;
			case 2:
				goto IL_4C;
			case 3:
				num = 1;
				continue;
			}
			if (!disposing)
			{
				break;
			}
			if (true)
			{
			}
			num = 3;
		}
		IL_4C:
		IL_68:
		base.Dispose(disposing);
	}
	private void eval_a()
	{
		if (true)
		{
		}
		this.l = new WebBrowser();
		base.SuspendLayout();
		this.l.Location = new Point(0, 0);
		this.l.MinimumSize = new Size(20, 20);
		this.l.Name = "web1";
		this.l.TabIndex = 4;
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Size = new Size(745, 154);
		base.Controls.Add(this.l);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
