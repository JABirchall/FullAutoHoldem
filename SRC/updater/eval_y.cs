using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
public class eval_y : Form
{
	public bool eval_a;
	public string eval_b = "192.168.254.2";
	private string eval_c = "";
	private TabPage eval_d;
	private TabPage eval_e;
	public static string eval_f;
	private static string eval_g;
	public bool eval_h;
	private eval_bu eval_i;
	private static string eval_j;
	public static RegistryKey eval_k;
	public string eval_l = "";
	public string eval_m = "";
	private string[] n;
	public eval_r.eval_a o;
	public static string eval_p;
	private eval_cj eval_q;
	private eval_p eval_r;
	private eval_m eval_s;
	private string eval_t = "";
	private IContainer eval_u;
	private TabControl eval_v;
	public eval_y(string[] A_0)
	{
		this.n = A_0;
		eval_y.eval_p = eval_b7.eval_a(ref this.eval_t, this);
		this.eval_a();
		base.Load += new EventHandler(this.eval_b);
	}
	private void d()
	{
		while (true)
		{
			if (true)
			{
			}
			this.eval_i = new eval_bu();
			this.eval_i.BorderStyle = BorderStyle.Fixed3D;
			base.Controls.Add(this.eval_i);
			this.eval_i.Location = new Point(2, 5);
			this.eval_i.Size = new Size(base.Width - 13, 77);
			this.eval_i.b();
			this.eval_q = new eval_cj(this);
			TabPage tabPage = new TabPage("Activate");
			tabPage.Controls.Add(this.eval_q);
			this.eval_v.TabPages.Add(tabPage);
			this.eval_r = new eval_p(this);
			this.eval_d = new TabPage("Update");
			this.eval_d.Controls.Add(this.eval_r);
			this.eval_v.TabPages.Add(this.eval_d);
			this.eval_s = new eval_m(this);
			this.eval_e = new TabPage("Tools");
			this.eval_e.Controls.Add(this.eval_s);
			this.eval_v.TabPages.Add(this.eval_e);
			this.eval_q.eval_e.Text = global::eval_r.eval_b();
			this.eval_r.eval_w.Text = this.eval_q.eval_e.Text;
			this.eval_a = global::eval_q.eval_a("fullautoholdem.99k.org");
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 0:
					this.eval_c("local server");
					global::eval_q.eval_d[0] = "http://" + this.eval_b;
					eval_y.eval_g = global::eval_q.eval_d[0] + "/php/buynow.php";
					num = 2;
					continue;
				case 1:
					if (this.eval_a)
					{
						num = 0;
						continue;
					}
					return;
				case 2:
					return;
				}
				break;
			}
		}
	}
	private void eval_b(object A_0, EventArgs A_1)
	{
		int num = 20;
		while (true)
		{
			switch (num)
			{
			case 0:
				num = 29;
				continue;
			case 1:
			{
				int num2 = 0;
				num = 15;
				continue;
			}
			case 2:
			{
				this.eval_c("trial expires:" + this.o.eval_b);
				int num2;
				this.eval_c("days left: " + num2.ToString());
				num = 42;
				continue;
			}
			case 3:
				goto IL_586;
			case 4:
				goto IL_386;
			case 5:
				if (this.o.eval_a == "install")
				{
					num = 13;
					continue;
				}
				this.eval_q.eval_c.Top = 3;
				num = 26;
				continue;
			case 6:
				num = 24;
				continue;
			case 7:
				num = 10;
				continue;
			case 8:
				if (this.eval_t == "true")
				{
					num = 35;
					continue;
				}
				goto IL_3B3;
			case 9:
			{
				int num2 = global::eval_r.eval_a(this.o.eval_b);
				num = 11;
				continue;
			}
			case 10:
				if (this.eval_c == this.o.eval_f)
				{
					num = 6;
					continue;
				}
				goto IL_5B5;
			case 11:
				goto IL_586;
			case 12:
				this.eval_c("license type: retail");
				num = 22;
				continue;
			case 13:
				goto IL_68E;
			case 14:
				MessageBox.Show("Wrong start args.");
				base.Close();
				Application.Exit();
				num = 23;
				continue;
			case 15:
			{
				if (this.o.eval_i != "-1")
				{
					num = 25;
					continue;
				}
				int num2 = 1;
				num = 3;
				continue;
			}
			case 16:
				goto IL_65E;
			case 17:
				goto IL_328;
			case 18:
				goto IL_586;
			case 19:
				MessageBox.Show("Must be run from main program.");
				base.Close();
				Application.Exit();
				num = 40;
				continue;
			case 21:
				if (this.n[0] == "runCheck")
				{
					num = 0;
					continue;
				}
				goto IL_5B5;
			case 22:
				goto IL_65E;
			case 23:
				goto IL_5F0;
			case 24:
			{
				int num2;
				if (num2 > 0)
				{
					num = 41;
					continue;
				}
				goto IL_5B5;
			}
			case 25:
				num = 28;
				continue;
			case 26:
				if (this.eval_c != this.o.eval_f)
				{
					num = 33;
					continue;
				}
				num = 36;
				continue;
			case 27:
				goto IL_5B5;
			case 28:
			{
				if (this.o.eval_a != "install")
				{
					num = 9;
					continue;
				}
				int num2 = 1;
				num = 18;
				continue;
			}
			case 29:
				if (this.o.eval_a != "install")
				{
					num = 7;
					continue;
				}
				goto IL_5B5;
			case 30:
				if (this.eval_t == "true")
				{
					num = 1;
					continue;
				}
				this.d();
				this.eval_v.TabPages.RemoveAt(1);
				this.eval_v.TabPages.RemoveAt(1);
				this.eval_c(this.eval_t);
				this.eval_c("Program must be activated");
				this.eval_q.eval_h.Enabled = false;
				this.eval_c();
				num = 17;
				continue;
			case 31:
				if (!global::eval_p.eval_f())
				{
					num = 38;
					continue;
				}
				goto IL_3B3;
			case 32:
				goto IL_2C2;
			case 33:
				goto IL_526;
			case 34:
				if (this.eval_t != "")
				{
					num = 39;
					continue;
				}
				this.eval_t = global::eval_r.eval_a("FAHoldemlic.xml", eval_y.eval_p, ref this.o);
				num = 8;
				continue;
			case 35:
				num = 31;
				continue;
			case 36:
				if (this.o.eval_i != "-1")
				{
					num = 2;
					continue;
				}
				goto IL_6B5;
			case 37:
				if (this.eval_l == "")
				{
					num = 19;
					continue;
				}
				Directory.SetCurrentDirectory(this.eval_l);
				num = 4;
				continue;
			case 38:
				this.eval_t = "Error checking plugins";
				num = 43;
				continue;
			case 39:
				goto IL_3B1;
			case 40:
				goto IL_386;
			case 41:
				eval_y.eval_p = eval_y.eval_p.Trim();
				base.Close();
				Application.Exit();
				num = 27;
				continue;
			case 42:
			{
				if (true)
				{
				}
				int num2;
				if (num2 <= 0)
				{
					num = 32;
					continue;
				}
				return;
			}
			case 43:
				goto IL_3B3;
			case 44:
				if (this.o.eval_i == "-1")
				{
					num = 12;
					continue;
				}
				this.eval_c("license type: " + this.o.eval_a + " trial");
				num = 16;
				continue;
			}
			if (this.n.Length <= 0)
			{
				num = 14;
				continue;
			}
			goto IL_5F0;
			IL_386:
			num = 34;
			continue;
			IL_3B3:
			this.eval_c = global::eval_r.eval_b();
			num = 30;
			continue;
			IL_586:
			num = 21;
			continue;
			IL_5B5:
			this.d();
			num = 44;
			continue;
			IL_5F0:
			this.eval_l = (string)eval_y.eval_k.GetValue("RunDir", "");
			this.eval_m = (string)eval_y.eval_k.GetValue("RunName", "");
			num = 37;
			continue;
			IL_65E:
			num = 5;
		}
		IL_2C2:
		this.eval_c("Trial expired.");
		this.eval_v.TabPages.RemoveAt(1);
		this.eval_v.TabPages.RemoveAt(1);
		return;
		IL_328:
		return;
		IL_3B1:
		MessageBox.Show(this.eval_t, "load pub key");
		return;
		IL_526:
		this.eval_c("Program was not activated for this computer.");
		this.eval_c("Program must be reinstalled");
		return;
		IL_68E:
		this.eval_c("free trial length: " + this.o.eval_i + " days");
		this.eval_c();
		return;
		IL_6B5:
		this.eval_c("valid purchase thank you.");
		this.eval_q.eval_c.Visible = false;
		this.eval_v.TabPages.RemoveAt(0);
	}
	private void eval_c()
	{
		if (true)
		{
		}
		this.eval_c("Full Auto Holdem requires internet activation.");
		this.eval_c("No personal info will be sent.");
		this.eval_q.eval_k.Text = "Activate free trial?";
		this.eval_q.eval_k.Visible = true;
		this.eval_q.eval_l.Visible = true;
	}
	private void eval_a(object A_0, EventArgs A_1)
	{
		base.Close();
		Application.Exit();
	}
	public void eval_d(object A_0, EventArgs A_1)
	{
		while (true)
		{
			this.eval_e("Activate");
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 0:
					goto IL_82;
				case 1:
				{
					global::eval_r.eval_a("FAHoldemlic.xml", ref this.o);
					global::eval_p.eval_f();
					this.eval_r.eval_a(false);
					bool flag = false;
					bool flag2 = true;
					num = 5;
					continue;
				}
				case 2:
					num = 8;
					continue;
				case 3:
					goto IL_103;
				case 4:
					this.eval_d("Success");
					num = 3;
					continue;
				case 5:
				{
					bool flag;
					if (this.eval_r.eval_a(ref flag))
					{
						num = 9;
						continue;
					}
					goto IL_82;
				}
				case 6:
					if (this.eval_b())
					{
						num = 1;
						continue;
					}
					return;
				case 7:
				{
					bool flag2;
					if (flag2)
					{
						num = 2;
						continue;
					}
					return;
				}
				case 8:
					if (this.n[0] == "runCheck")
					{
						num = 4;
						continue;
					}
					return;
				case 9:
				{
					bool flag2 = this.eval_r.eval_g();
					num = 0;
					continue;
				}
				}
				break;
				IL_82:
				num = 7;
			}
		}
		IL_103:
		if (true)
		{
		}
	}
	public void eval_c(string A_0)
	{
		this.eval_i.eval_c(A_0);
	}
	public void eval_f(string A_0)
	{
		this.eval_i.b(A_0);
	}
	public void eval_a(string A_0)
	{
		Console.WriteLine("");
		Process.Start(eval_y.eval_g + "?requestCode=" + A_0);
	}
	public void eval_c(object A_0, EventArgs A_1)
	{
		this.eval_a(this.eval_q.eval_e.Text);
	}
	public bool eval_a(string A_0, string A_1)
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			bool result;
			while (true)
			{
				string a_ = "";
				result = false;
				int num = 19;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 0:
					{
						string[] array;
						if (array.Length > 1)
						{
							num = 2;
							continue;
						}
						goto IL_23B;
					}
					case 1:
					{
						string[] array2;
						if (!array2[num2].Contains("Choose"))
						{
							num = 14;
							continue;
						}
						string[] array = array2[num2].Split(new char[]
						{
							','
						});
						if (true)
						{
						}
						num = 0;
						continue;
					}
					case 2:
					{
						eval_n eval_n = new eval_n();
						string[] array;
						eval_ce eval_ce = new eval_ce(array, eval_n);
						eval_ce.ShowDialog();
						this.Refresh();
						string text = eval_n.eval_a;
						num = 4;
						continue;
					}
					case 3:
						goto IL_10E;
					case 4:
						goto IL_23B;
					case 5:
						num2 = 0;
						num = 6;
						continue;
					case 6:
						goto IL_19A;
					case 7:
						goto IL_23B;
					case 8:
						num = 18;
						continue;
					case 9:
						return result;
					case 10:
					{
						result = true;
						string text2 = global::eval_q.eval_a(false, A_1, a_, this.eval_c);
						string[] array2 = text2.Split(new char[]
						{
							'#'
						});
						num = 11;
						continue;
					}
					case 11:
					{
						string[] array2;
						if (array2.Length > 1)
						{
							num = 5;
							continue;
						}
						return result;
					}
					case 12:
					{
						string[] array2;
						if (num2 >= array2.Length - 1)
						{
							num = 9;
							continue;
						}
						string text = "";
						num = 1;
						continue;
					}
					case 13:
					{
						string text;
						if (this.eval_a(text, A_1, ref a_))
						{
							num = 3;
							continue;
						}
						return result;
					}
					case 14:
					{
						string[] array2;
						string text = array2[num2];
						num = 7;
						continue;
					}
					case 15:
						goto IL_19A;
					case 16:
						num = 13;
						continue;
					case 17:
					{
						string text;
						if (text != "")
						{
							num = 8;
							continue;
						}
						goto IL_10E;
					}
					case 18:
					{
						string text;
						if (text != "FAHoldem")
						{
							num = 16;
							continue;
						}
						goto IL_10E;
					}
					case 19:
						if (this.eval_a(A_0, A_1, ref a_))
						{
							num = 10;
							continue;
						}
						return result;
					}
					break;
					IL_10E:
					num2++;
					num = 15;
					continue;
					IL_19A:
					num = 12;
					continue;
					IL_23B:
					num = 17;
				}
			}
			return result;
		}
		}
		goto IL_0E;
	}
	public bool eval_a(string A_0, string A_1, ref string A_2)
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			bool flag;
			while (true)
			{
				A_2 = "";
				string text = "";
				flag = false;
				string text2 = "";
				int num = 17;
				while (true)
				{
					string text3;
					string text4;
					string arg_393_0;
					string arg_32B_0;
					XmlDocument xmlDocument;
					switch (num)
					{
					case 0:
						if (text3 == "true")
						{
							num = 10;
							continue;
						}
						flag = true;
						text2 = "license corrupt!";
						num = 28;
						continue;
					case 1:
						text4 = A_0 + "lic.xml";
						this.eval_c("requesting license: " + text4 + " from server...");
						num = 3;
						continue;
					case 2:
					{
						string innerText;
						if (text3.Contains(innerText))
						{
							num = 9;
							continue;
						}
						flag = true;
						text2 = "invalid request.";
						num = 15;
						continue;
					}
					case 3:
						if (this.o == null)
						{
							num = 4;
							continue;
						}
						num = 29;
						continue;
					case 4:
						num = 5;
						continue;
					case 5:
						arg_393_0 = "";
						goto IL_393;
					case 6:
						goto IL_14A;
					case 7:
						goto IL_14A;
					case 8:
						if (text3.Substring(0, 5) != "Error")
						{
							num = 13;
							continue;
						}
						flag = true;
						text2 = eval_y.eval_j;
						num = 23;
						continue;
					case 9:
						this.eval_c("valid request");
						num = 8;
						continue;
					case 10:
						goto IL_45E;
					case 11:
						goto IL_26F;
					case 12:
						goto IL_14A;
					case 13:
						try
						{
							global::eval_r.eval_a(text3, text4);
							goto IL_4ED;
						}
						catch (Exception ex)
						{
							text3 = "Error " + ex.Message;
							goto IL_4ED;
						}
						goto IL_45E;
						IL_4ED:
						num = 32;
						continue;
					case 14:
						if (text3.Substring(0, 5) != "Error")
						{
							num = 21;
							continue;
						}
						goto IL_DD;
					case 15:
						goto IL_14A;
					case 16:
						this.eval_c("Thank you for your purchase!" + Environment.NewLine + "Good Luck!");
						this.eval_q.eval_h.Enabled = false;
						num = 11;
						continue;
					case 17:
						if (A_1.Length == 16)
						{
							num = 1;
							continue;
						}
						text2 = "Unlock code is wrong number of characters.";
						this.eval_c(text2);
						MessageBox.Show(text2, "Failure", MessageBoxButtons.OK);
						flag = true;
						num = 20;
						continue;
					case 18:
						num = 14;
						continue;
					case 19:
						if (!flag)
						{
							num = 16;
							continue;
						}
						this.eval_q.eval_h.Enabled = false;
						this.eval_c(text3);
						MessageBox.Show(text2 + Environment.NewLine + text3, "Failure", MessageBoxButtons.OK);
						if (true)
						{
						}
						num = 25;
						continue;
					case 20:
						goto IL_29C;
					case 21:
						text3 = global::eval_r.eval_a(text4, eval_y.eval_p, ref this.o);
						num = 0;
						continue;
					case 22:
						if (text3.Substring(0, 5) != "Error")
						{
							num = 27;
							continue;
						}
						flag = true;
						text2 = eval_y.eval_j;
						num = 6;
						continue;
					case 23:
						goto IL_14A;
					case 24:
						arg_32B_0 = "";
						goto IL_32B;
					case 25:
						goto IL_1E2;
					case 26:
						num = 24;
						continue;
					case 27:
					{
						XmlNode xmlNode = xmlDocument.GetElementsByTagName("compId")[0];
						string innerText = xmlNode.InnerText;
						num = 2;
						continue;
					}
					case 28:
						goto IL_14A;
					case 29:
						arg_393_0 = this.o.eval_e;
						goto IL_393;
					case 30:
						if (this.o == null)
						{
							num = 26;
							continue;
						}
						num = 31;
						continue;
					case 31:
						arg_32B_0 = this.o.eval_m;
						goto IL_32B;
					case 32:
						if (text3.Length > 5)
						{
							num = 18;
							continue;
						}
						goto IL_DD;
					}
					break;
					IL_DD:
					flag = true;
					text2 = "invalid response from server";
					num = 7;
					continue;
					IL_14A:
					num = 19;
					continue;
					IL_32B:
					string a_ = arg_32B_0;
					string a_2;
					xmlDocument = eval_b7.eval_a(text4, a_2, A_1, ref text, A_0, a_, this.eval_q.eval_e.Text);
					text3 = global::eval_q.eval_b(xmlDocument.OuterXml, false, "");
					num = 22;
					continue;
					IL_393:
					a_2 = arg_393_0;
					num = 30;
					continue;
					IL_45E:
					A_2 = this.o.eval_l;
					this.eval_c("verified " + this.o.eval_a);
					this.eval_c("retail expires:" + this.o.eval_b);
					this.eval_c("days left: " + global::eval_r.eval_a(this.o.eval_b));
					num = 12;
				}
			}
			IL_1E2:
			IL_26F:
			IL_29C:
			return !flag;
		}
		}
		goto IL_0E;
	}
	public void eval_e(object A_0, EventArgs A_1)
	{
		while (true)
		{
			string text = this.eval_q.eval_j.Text;
			text = text.Replace(" ", "");
			text = text.Trim();
			int num = 2;
			while (true)
			{
				bool flag;
				switch (num)
				{
				case 0:
					this.eval_r.eval_a(false);
					num = 9;
					continue;
				case 1:
					if (this.eval_v.TabPages.Count == 1)
					{
						num = 8;
						continue;
					}
					goto IL_B4;
				case 2:
					if (this.eval_a("FAHoldem", text))
					{
						num = 3;
						continue;
					}
					return;
				case 3:
					num = 1;
					continue;
				case 4:
					this.eval_r.eval_g();
					num = 7;
					continue;
				case 5:
					if (global::eval_p.eval_f())
					{
						num = 0;
						continue;
					}
					goto IL_80;
				case 6:
					goto IL_B4;
				case 7:
					return;
				case 8:
					this.eval_v.TabPages.Add(this.eval_d);
					this.eval_v.TabPages.Add(this.eval_e);
					num = 6;
					continue;
				case 9:
					goto IL_80;
				case 10:
					if (this.eval_r.eval_a(ref flag))
					{
						num = 4;
						continue;
					}
					return;
				}
				break;
				IL_80:
				flag = false;
				if (true)
				{
				}
				num = 10;
				continue;
				IL_B4:
				num = 5;
			}
		}
	}
	public bool eval_e()
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			bool result;
			while (true)
			{
				result = false;
				int num = 16;
				while (true)
				{
					string arg_1B2_0;
					string[] array2;
					int num2;
					switch (num)
					{
					case 0:
						arg_1B2_0 = this.o.eval_k;
						goto IL_1B2;
					case 1:
						arg_1B2_0 = "trial";
						goto IL_1B2;
					case 2:
					{
						eval_n eval_n = new eval_n();
						string[] array;
						eval_ce eval_ce = new eval_ce(array, eval_n);
						eval_ce.ShowDialog();
						this.Refresh();
						num = 6;
						continue;
					}
					case 3:
						goto IL_111;
					case 4:
						goto IL_178;
					case 5:
					{
						if (!array2[num2].Contains("Choose"))
						{
							num = 15;
							continue;
						}
						string[] array = array2[num2].Split(new char[]
						{
							','
						});
						num = 9;
						continue;
					}
					case 6:
					{
						eval_n eval_n;
						if (eval_n.eval_a != "")
						{
							num = 17;
							continue;
						}
						goto IL_111;
					}
					case 7:
						if (array2.Length > 1)
						{
							num = 13;
							continue;
						}
						return result;
					case 8:
						goto IL_111;
					case 9:
					{
						string[] array;
						if (array.Length > 1)
						{
							num = 2;
							continue;
						}
						goto IL_111;
					}
					case 10:
						goto IL_154;
					case 11:
						num = 1;
						continue;
					case 12:
						if (num2 >= array2.Length - 1)
						{
							num = 4;
							continue;
						}
						num = 5;
						continue;
					case 13:
						num2 = 0;
						num = 10;
						continue;
					case 14:
						goto IL_154;
					case 15:
						this.eval_b(array2[num2]);
						num = 8;
						continue;
					case 16:
						if (!(this.o.eval_a != "trial"))
						{
							num = 11;
							continue;
						}
						num = 0;
						continue;
					case 17:
					{
						eval_n eval_n;
						result = this.eval_b(eval_n.eval_a);
						num = 3;
						continue;
					}
					}
					break;
					IL_111:
					num2++;
					num = 14;
					continue;
					IL_154:
					num = 12;
					continue;
					IL_1B2:
					string a_ = arg_1B2_0;
					string text = global::eval_q.eval_a(false, a_, this.o.eval_l, this.o.eval_f);
					array2 = text.Split(new char[]
					{
						'#'
					});
					num = 7;
				}
			}
			IL_178:
			if (true)
			{
			}
			return result;
		}
		}
		goto IL_0E;
	}
	private bool eval_b()
	{
		bool result;
		while (true)
		{
			result = false;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					if (this.eval_b("FAHoldem"))
					{
						num = 4;
						continue;
					}
					num = 2;
					continue;
				case 1:
					return result;
				case 2:
					if (this.eval_v.TabPages.Count > 1)
					{
						num = 3;
						continue;
					}
					return result;
				case 3:
					this.eval_v.TabPages.RemoveAt(1);
					this.eval_v.TabPages.RemoveAt(1);
					num = 1;
					continue;
				case 4:
					result = true;
					this.eval_e();
					num = 5;
					continue;
				case 5:
					return result;
				}
				break;
			}
		}
		return result;
	}
	public bool eval_b(string A_0)
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			bool result;
			while (true)
			{
				result = false;
				string text = "";
				bool flag = false;
				string text2 = "";
				this.eval_q.eval_l.Enabled = false;
				this.eval_c("contacting server...");
				int num = 22;
				while (true)
				{
					string arg_594_0;
					string arg_2BC_0;
					XmlDocument xmlDocument;
					string text3;
					string text4;
					string a_;
					switch (num)
					{
					case 0:
						if (this.o == null)
						{
							num = 13;
							continue;
						}
						num = 37;
						continue;
					case 1:
						goto IL_3E3;
					case 2:
						goto IL_3E3;
					case 3:
						arg_594_0 = this.o.eval_e;
						goto IL_594;
					case 4:
						arg_2BC_0 = "";
						goto IL_2BC;
					case 5:
					{
						XmlNode xmlNode = xmlDocument.GetElementsByTagName("compId")[0];
						string innerText = xmlNode.InnerText;
						num = 8;
						continue;
					}
					case 6:
						result = true;
						this.eval_c("Free trial is now enabled." + Environment.NewLine + "Good Luck!");
						this.eval_q.eval_l.Enabled = false;
						this.eval_q.eval_k.Enabled = false;
						num = 11;
						continue;
					case 7:
						goto IL_281;
					case 8:
					{
						string innerText;
						if (text3.Contains(innerText))
						{
							num = 26;
							continue;
						}
						flag = true;
						text2 = "invalid request.";
						num = 36;
						continue;
					}
					case 9:
						goto IL_3E3;
					case 10:
						goto IL_3E3;
					case 11:
						return result;
					case 12:
					{
						this.eval_c("verified " + this.o.eval_a);
						this.eval_c("trial expires:" + this.o.eval_b);
						int num2 = global::eval_r.eval_a(this.o.eval_b);
						this.eval_c("days left: " + num2.ToString());
						num = 20;
						continue;
					}
					case 13:
						num = 4;
						continue;
					case 14:
						num = 25;
						continue;
					case 15:
						if (text3 == "true")
						{
							num = 12;
							continue;
						}
						flag = true;
						text2 = "license corrupt!";
						num = 10;
						continue;
					case 16:
						text3 = global::eval_r.eval_a(text4, eval_y.eval_p, ref this.o);
						num = 15;
						continue;
					case 17:
						num = 35;
						continue;
					case 18:
						if (true)
						{
						}
						goto IL_3E3;
					case 19:
						if (this.eval_q.eval_j.Text != "")
						{
							num = 27;
							continue;
						}
						goto IL_281;
					case 20:
					{
						int num2;
						if (num2 <= 0)
						{
							num = 21;
							continue;
						}
						goto IL_3E3;
					}
					case 21:
						flag = true;
						text3 = "";
						text2 = "Trial expired.";
						num = 18;
						continue;
					case 22:
						if (this.o == null)
						{
							num = 14;
							continue;
						}
						num = 3;
						continue;
					case 23:
						if (text3.Substring(0, 5) != "Error")
						{
							num = 16;
							continue;
						}
						flag = true;
						text2 = "invalid response from server";
						num = 2;
						continue;
					case 24:
						goto IL_3E3;
					case 25:
						arg_594_0 = "";
						goto IL_594;
					case 26:
						this.eval_c("valid request");
						num = 29;
						continue;
					case 27:
						a_ = this.eval_q.eval_j.Text;
						this.eval_c("same address in httpd.conf for vhost, activate.php SignXml");
						num = 7;
						continue;
					case 28:
						if (text3.Length > 0)
						{
							num = 33;
							continue;
						}
						flag = true;
						text2 = "no response";
						num = 1;
						continue;
					case 29:
						if (text3.Substring(0, 5) != "Error")
						{
							num = 30;
							continue;
						}
						flag = true;
						text2 = eval_y.eval_j;
						num = 24;
						continue;
					case 30:
						try
						{
							global::eval_r.eval_a(text3, text4);
							goto IL_103;
						}
						catch (Exception ex)
						{
							text3 = "Error " + ex.Message + Environment.NewLine + text3;
							goto IL_103;
						}
						goto IL_3E3;
						IL_103:
						num = 23;
						continue;
					case 31:
						if (!flag)
						{
							num = 6;
							continue;
						}
						this.eval_c(string.Concat(new string[]
						{
							text3,
							Environment.NewLine,
							text2,
							Environment.NewLine,
							"Failed to activate."
						}));
						num = 34;
						continue;
					case 32:
						if (text3.Length > 5)
						{
							num = 17;
							continue;
						}
						goto IL_321;
					case 33:
						flag = true;
						text2 = eval_y.eval_j;
						num = 9;
						continue;
					case 34:
						return result;
					case 35:
						if (text3.Substring(0, 5) != "Error")
						{
							num = 5;
							continue;
						}
						goto IL_321;
					case 36:
						goto IL_3E3;
					case 37:
						arg_2BC_0 = this.o.eval_m;
						goto IL_2BC;
					}
					break;
					IL_281:
					text3 = global::eval_q.eval_b(xmlDocument.OuterXml, false, a_);
					num = 32;
					continue;
					IL_2BC:
					string a_2 = arg_2BC_0;
					text4 = A_0 + "lic.xml";
					string a_3;
					xmlDocument = eval_b7.eval_a(a_3, ref text, a_2, "email", A_0);
					a_ = "";
					num = 19;
					continue;
					IL_321:
					num = 28;
					continue;
					IL_3E3:
					num = 31;
					continue;
					IL_594:
					a_3 = arg_594_0;
					num = 0;
				}
			}
			return result;
		}
		}
		goto IL_0E;
	}
	public DialogResult eval_e(string A_0)
	{
		DialogResult dialogResult;
		while (true)
		{
			if (true)
			{
			}
			dialogResult = DialogResult.OK;
			Process[] processesByName = Process.GetProcessesByName(this.eval_m);
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 0:
					goto IL_178;
				case 1:
					goto IL_165;
				case 2:
					if (processesByName.Length > 0)
					{
						num = 9;
						continue;
					}
					goto IL_165;
				case 3:
					if (processesByName.Length > 0)
					{
						num = 12;
						continue;
					}
					return dialogResult;
				case 4:
					goto IL_141;
				case 5:
					return dialogResult;
				case 6:
					if (dialogResult == DialogResult.OK)
					{
						num = 11;
						continue;
					}
					goto IL_165;
				case 7:
					goto IL_141;
				case 8:
					Thread.Sleep(1000);
					processesByName = Process.GetProcessesByName(this.eval_m);
					num = 2;
					continue;
				case 9:
					MessageBox.Show("Main program could not be closed." + Environment.NewLine + "Restart to finish updates.", A_0, MessageBoxButtons.OK);
					dialogResult = DialogResult.Cancel;
					num = 1;
					continue;
				case 10:
				{
					int num2;
					if (num2 >= processesByName.Length)
					{
						num = 8;
						continue;
					}
					processesByName[num2].CloseMainWindow();
					num2++;
					num = 4;
					continue;
				}
				case 11:
				{
					int num2 = 0;
					num = 7;
					continue;
				}
				case 12:
					num = 14;
					continue;
				case 13:
					dialogResult = MessageBox.Show("Main program will now be closed", A_0, MessageBoxButtons.OKCancel);
					num = 0;
					continue;
				case 14:
					if (this.n[0] != "runCheck")
					{
						num = 13;
						continue;
					}
					Console.WriteLine("closeApp");
					Thread.Sleep(500);
					num = 15;
					continue;
				case 15:
					goto IL_178;
				}
				break;
				IL_141:
				num = 10;
				continue;
				IL_165:
				this.Refresh();
				num = 5;
				continue;
				IL_178:
				num = 6;
			}
		}
		return dialogResult;
	}
	public void eval_d(string A_0)
	{
		while (true)
		{
			DialogResult dialogResult = MessageBox.Show("Run Main program now?", A_0, MessageBoxButtons.YesNo);
			if (true)
			{
			}
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (dialogResult == DialogResult.Yes)
					{
						num = 1;
						continue;
					}
					return;
				case 1:
					new Process
					{
						StartInfo = new ProcessStartInfo
						{
							UseShellExecute = true,
							FileName = this.eval_m + ".exe"
						}
					}.Start();
					base.Close();
					Application.Exit();
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}
	protected override void eval_a(bool A_0)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (this.eval_u != null)
				{
					num = 1;
					continue;
				}
				goto IL_68;
			case 1:
				this.eval_u.Dispose();
				num = 2;
				continue;
			case 2:
				goto IL_4C;
			case 4:
				num = 0;
				continue;
			}
			if (true)
			{
			}
			if (!A_0)
			{
				break;
			}
			num = 4;
		}
		IL_4C:
		IL_68:
		base.Dispose(A_0);
	}
	private void eval_a()
	{
		if (true)
		{
		}
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(eval_y));
		this.eval_v = new TabControl();
		base.SuspendLayout();
		this.eval_v.Alignment = TabAlignment.Bottom;
		this.eval_v.Location = new Point(2, 85);
		this.eval_v.Name = "tabMain";
		this.eval_v.SelectedIndex = 0;
		this.eval_v.Size = new Size(491, 337);
		this.eval_v.TabIndex = 57;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(494, 422);
		base.Controls.Add(this.eval_v);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Updater";
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Updater";
		base.ResumeLayout(false);
	}
	static eval_y()
	{
		// Note: this type is marked as 'beforefieldinit'.
		if (true)
		{
		}
		eval_y.eval_f = "bak";
		eval_y.eval_g = "http://fullautoholdem.com/buynow.php";
		eval_y.eval_j = "Possible connection error.";
		eval_y.eval_k = Registry.CurrentUser.CreateSubKey(global::eval_r.eval_c);
		eval_y.eval_p = "";
	}
}
