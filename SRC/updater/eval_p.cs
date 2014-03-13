using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
public class eval_p : UserControl
{
	private const string eval_a = "Update complete";
	private int eval_b;
	private int eval_c;
	private eval_ap.eval_b eval_d = default(eval_ap.eval_b);
	private BackgroundWorker eval_e;
	public static ArrayList eval_f = new ArrayList();
	public static ArrayList eval_g = new ArrayList();
	private eval_y eval_h;
	private ListView eval_i;
	private ListView eval_j;
	private IContainer eval_k;
	public GroupBox eval_l;
	private Button eval_m;
	public GroupBox eval_n;
	public Button eval_o;
	public Button eval_p;
	public Button eval_q;
	private Label eval_r;
	public TextBox eval_s;
	private Label eval_t;
	public Button eval_u;
	private Label eval_v;
	public TextBox eval_w;
	public eval_p(eval_y A_0)
	{
		this.eval_h = A_0;
		this.eval_a();
		this.eval_u.Visible = false;
		this.eval_t.TextChanged += new EventHandler(this.eval_g);
		this.eval_i = new ListView();
		this.eval_i.View = View.Details;
		this.eval_i.Columns.Add("part", 80, HorizontalAlignment.Left);
		this.eval_i.Columns.Add("current", 89, HorizontalAlignment.Left);
		this.eval_i.Columns.Add("latest", 89, HorizontalAlignment.Left);
		this.eval_i.Columns.Add("expires", 70, HorizontalAlignment.Left);
		this.eval_i.Columns.Add("license", 58, HorizontalAlignment.Left);
		this.eval_i.SetBounds(5, 15, this.eval_n.Width - 16 - this.eval_o.Width, this.eval_n.ClientSize.Height - 20);
		this.eval_i.FullRowSelect = true;
		this.eval_i.MultiSelect = true;
		this.eval_i.HideSelection = false;
		this.eval_n.Controls.Add(this.eval_i);
		this.eval_j = new ListView();
		this.eval_j.View = View.Details;
		this.eval_j.FullRowSelect = true;
		this.eval_j.Columns.Add("part", 80, HorizontalAlignment.Left);
		this.eval_j.Columns.Add("price", 52, HorizontalAlignment.Left);
		this.eval_j.Columns.Add("info", 200, HorizontalAlignment.Left);
		this.eval_j.Columns.Add("current", 88, HorizontalAlignment.Left);
		this.eval_j.SetBounds(5, 15, this.eval_l.Width - 16 - this.eval_o.Width, this.eval_l.ClientSize.Height - 50);
		this.eval_l.Controls.Add(this.eval_j);
		this.eval_a(true);
		this.eval_j.SelectedIndexChanged += new EventHandler(this.eval_e);
		this.eval_q.Enabled = false;
		this.eval_s.TextChanged += new EventHandler(this.eval_g);
		this.eval_s.Enabled = false;
	}
	public void eval_a(bool A_0)
	{
		while (true)
		{
			this.eval_i.Items.Clear();
			int num = 0;
			int num2 = 3;
			while (true)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_101;
				case 2:
				{
					int num3;
					if (num3 >= global::eval_p.eval_g.Count)
					{
						num2 = 10;
						continue;
					}
					this.eval_h.eval_c((string)global::eval_p.eval_g[num3]);
					num3++;
					num2 = 4;
					continue;
				}
				case 3:
					goto IL_93;
				case 4:
					goto IL_101;
				case 5:
					if (num >= global::eval_p.eval_f.Count)
					{
						num2 = 6;
						continue;
					}
					this.eval_i.Items.Add((ListViewItem)global::eval_p.eval_f[num]);
					num++;
					num2 = 9;
					continue;
				case 6:
					num2 = 8;
					continue;
				case 7:
				{
					if (true)
					{
					}
					int num3 = 0;
					num2 = 1;
					continue;
				}
				case 8:
					if (A_0)
					{
						num2 = 7;
						continue;
					}
					return;
				case 9:
					goto IL_93;
				case 10:
					global::eval_p.eval_g.Clear();
					num2 = 0;
					continue;
				}
				break;
				IL_93:
				num2 = 5;
				continue;
				IL_101:
				num2 = 2;
			}
		}
	}
	private void eval_g(object A_0, EventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (this.eval_j.SelectedIndices.Count > 0)
				{
					num = 2;
					continue;
				}
				return;
			case 2:
				this.eval_q.Enabled = true;
				num = 3;
				continue;
			case 3:
				return;
			case 4:
				num = 1;
				continue;
			}
			if (true)
			{
			}
			if (this.eval_q.Enabled)
			{
				break;
			}
			num = 4;
		}
	}
	public static string eval_a(eval_r.eval_a A_0)
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			string result;
			while (true)
			{
				string[] array = A_0.n.Split(new char[]
				{
					','
				});
				string text = "";
				result = "";
				int num = 0;
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					case 0:
						if (num >= array.Length)
						{
							num2 = 7;
							continue;
						}
						num2 = 11;
						continue;
					case 1:
					{
						string[] array2 = new string[]
						{
							null,
							null,
							null,
							null,
							A_0.eval_a
						};
						array2[3] = A_0.eval_b.Substring(0, 10);
						array2[0] = array[num];
						array2[1] = global::eval_r.eval_b(array[num], "", ref text);
						array2[2] = "?";
						ListViewItem value = new ListViewItem(array2);
						global::eval_p.eval_f.Add(value);
						num2 = 9;
						continue;
					}
					case 2:
						goto IL_139;
					case 3:
						if (num == 0)
						{
							num2 = 6;
							continue;
						}
						goto IL_187;
					case 4:
						goto IL_139;
					case 5:
						goto IL_187;
					case 6:
					{
						string[] array2;
						result = array2[0];
						num2 = 8;
						continue;
					}
					case 7:
						return result;
					case 8:
						goto IL_187;
					case 9:
						if (text == "")
						{
							num2 = 10;
							continue;
						}
						global::eval_p.eval_g.Add(text);
						num2 = 5;
						continue;
					case 10:
						num2 = 3;
						continue;
					case 11:
						if (array[num].Length > 0)
						{
							num2 = 1;
							continue;
						}
						goto IL_187;
					}
					break;
					IL_139:
					num2 = 0;
					continue;
					IL_187:
					num++;
					if (true)
					{
					}
					num2 = 4;
				}
			}
			return result;
		}
		}
		goto IL_0E;
	}
	public static bool eval_f()
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			string a;
			while (true)
			{
				global::eval_p.eval_f.Clear();
				eval_r.eval_a eval_a = null;
				string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
				a = "";
				global::eval_p.eval_g.Clear();
				int num = 0;
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					case 0:
						if (num >= files.Length)
						{
							if (true)
							{
							}
							num2 = 3;
							continue;
						}
						try
						{
							while (true)
							{
								string fileName = Path.GetFileName(files[num]);
								num2 = 1;
								while (true)
								{
									switch (num2)
									{
									case 0:
										goto IL_27E;
									case 1:
										if (fileName.Length > "lic.xml".Length)
										{
											num2 = 11;
											continue;
										}
										goto IL_27E;
									case 2:
									{
										eval_a = null;
										string text = global::eval_r.eval_a(fileName, eval_y.eval_p, ref eval_a);
										num2 = 14;
										continue;
									}
									case 3:
									{
										if (eval_a.eval_a != "install")
										{
											num2 = 13;
											continue;
										}
										int num3 = int.Parse(eval_a.eval_i);
										num2 = 9;
										continue;
									}
									case 4:
										global::eval_p.eval_a(eval_a);
										num2 = 7;
										continue;
									case 5:
									{
										int num3;
										if (num3 > 0)
										{
											num2 = 4;
											continue;
										}
										global::eval_p.eval_g.Add(eval_a.eval_a + " expired " + eval_a.eval_b);
										num2 = 0;
										continue;
									}
									case 6:
										goto IL_27E;
									case 7:
										goto IL_27E;
									case 8:
										goto IL_28A;
									case 9:
										goto IL_1F1;
									case 10:
									{
										int num3 = 0;
										num2 = 3;
										continue;
									}
									case 11:
										num2 = 12;
										continue;
									case 12:
										if (fileName.Substring(fileName.Length - "lic.xml".Length, "lic.xml".Length) == "lic.xml")
										{
											num2 = 2;
											continue;
										}
										goto IL_27E;
									case 13:
									{
										int num3 = global::eval_r.eval_a(eval_a.eval_b);
										num2 = 15;
										continue;
									}
									case 14:
									{
										string text;
										if (text == "true")
										{
											num2 = 10;
											continue;
										}
										global::eval_p.eval_g.Add(fileName + " " + text);
										num2 = 6;
										continue;
									}
									case 15:
										goto IL_1F1;
									}
									break;
									IL_1F1:
									num2 = 5;
									continue;
									IL_27E:
									num2 = 8;
								}
							}
							IL_28A:
							goto IL_65;
						}
						catch (Exception ex)
						{
							global::eval_p.eval_g.Add(ex.Message);
							goto IL_65;
						}
						goto IL_2A8;
						IL_65:
						num++;
						num2 = 1;
						continue;
					case 1:
						goto IL_2A8;
					case 2:
						goto IL_2A8;
					case 3:
						goto IL_2D2;
					}
					break;
					IL_2A8:
					num2 = 0;
				}
			}
			IL_2D2:
			return a == "";
		}
		}
		goto IL_0E;
	}
	public bool eval_a(ref bool A_0)
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			bool flag2;
			while (true)
			{
				A_0 = false;
				bool flag = true;
				string a_ = "trial";
				flag2 = false;
				int num = 33;
				while (true)
				{
					string arg_7CC_0;
					ListViewItem listViewItem;
					string text2;
					int num4;
					int num5;
					string[] array9;
					switch (num)
					{
					case 0:
						arg_7CC_0 = this.eval_h.o.eval_k;
						goto IL_7CC;
					case 1:
					{
						string[] array;
						this.eval_i.Items[listViewItem.Index].SubItems[2].Text = array[0];
						string text = this.eval_i.Items[listViewItem.Index].SubItems[1].Text;
						num = 48;
						continue;
					}
					case 2:
						goto IL_880;
					case 3:
						this.eval_o.Enabled = false;
						num = 9;
						continue;
					case 4:
						goto IL_66F;
					case 5:
						if (!this.eval_p.Enabled)
						{
							num = 14;
							continue;
						}
						this.eval_h.eval_c("updates available");
						num = 53;
						continue;
					case 6:
						goto IL_69C;
					case 7:
					{
						string[] array3;
						string[] array2 = array3[array3.Length - 3].Split(new char[]
						{
							'&'
						});
						num = 37;
						continue;
					}
					case 8:
						goto IL_5C8;
					case 9:
						goto IL_251;
					case 10:
					{
						int num2 = 0;
						num = 50;
						continue;
					}
					case 11:
						goto IL_18E;
					case 12:
					{
						if (text2.Contains("Error"))
						{
							num = 65;
							continue;
						}
						this.eval_j.Items.Clear();
						string[] array3 = text2.Split(new char[]
						{
							'#'
						});
						num = 40;
						continue;
					}
					case 13:
					{
						if (this.eval_h.eval_a)
						{
							num = 58;
							continue;
						}
						string[] array4;
						string[] array5;
						string[] array6;
						eval_ap.eval_a(array4[0], array5[0], array6[0]);
						num = 21;
						continue;
					}
					case 14:
						num = 27;
						continue;
					case 15:
						goto IL_5C8;
					case 16:
					{
						string[] array4;
						if (array4.Length >= 2)
						{
							num = 35;
							continue;
						}
						goto IL_18E;
					}
					case 17:
						goto IL_48F;
					case 18:
					{
						string[] array7;
						if (array7.Length >= 2)
						{
							num = 63;
							continue;
						}
						goto IL_66F;
					}
					case 19:
						goto IL_367;
					case 20:
					{
						string[] array8;
						listViewItem = this.eval_i.FindItemWithText(array8[0]);
						string[] array = array8[1].Split(new char[]
						{
							':'
						});
						num = 61;
						continue;
					}
					case 21:
						goto IL_18E;
					case 22:
					{
						int num2;
						if (num2 >= this.eval_i.Items.Count)
						{
							num = 15;
							continue;
						}
						string text3 = this.eval_i.Items[num2].SubItems[0].Text;
						int num3 = text3.IndexOf(".dll");
						num = 57;
						continue;
					}
					case 23:
						if (!(this.eval_h.o.eval_a != "trial"))
						{
							num = 56;
							continue;
						}
						num = 0;
						continue;
					case 24:
					{
						string[] array3;
						if (array3[array3.Length - 2].Length > 1)
						{
							num = 10;
							continue;
						}
						goto IL_5C8;
					}
					case 25:
						goto IL_323;
					case 26:
						if (this.eval_j.Items.Count > 0)
						{
							num = 59;
							continue;
						}
						goto IL_323;
					case 27:
						if (!flag2)
						{
							num = 47;
							continue;
						}
						return flag2;
					case 28:
						goto IL_367;
					case 29:
					{
						string[] array3;
						string text3;
						if (array3[array3.Length - 2].Contains(text3))
						{
							num = 60;
							continue;
						}
						int num2;
						num2++;
						num = 49;
						continue;
					}
					case 30:
						goto IL_323;
					case 31:
						goto IL_4ED;
					case 32:
					{
						string[] array3;
						if (num4 >= array3.Length - 3)
						{
							num = 7;
							continue;
						}
						string[] array8 = array3[num4].Split(new char[]
						{
							'='
						});
						num = 64;
						continue;
					}
					case 33:
						if (this.eval_h.o != null)
						{
							num = 45;
							continue;
						}
						goto IL_880;
					case 34:
					{
						string[] array;
						if (array.Length > 1)
						{
							num = 52;
							continue;
						}
						goto IL_48F;
					}
					case 35:
					{
						string[] array4;
						string[] array5 = array4[1].Split(new char[]
						{
							':'
						});
						string[] array6 = array5[1].Split(new char[]
						{
							';'
						});
						num = 13;
						continue;
					}
					case 36:
						return flag2;
					case 37:
					{
						string[] array2;
						if (array2.Length > 0)
						{
							num = 46;
							continue;
						}
						goto IL_4ED;
					}
					case 38:
						if (flag)
						{
							num = 3;
							continue;
						}
						goto IL_251;
					case 39:
						goto IL_69C;
					case 40:
					{
						string[] array3;
						if (array3.Length >= 2)
						{
							num = 62;
							continue;
						}
						flag = false;
						this.eval_h.eval_c(text2);
						num = 55;
						continue;
					}
					case 41:
					{
						int num3;
						string text3 = text3.Substring(0, num3);
						num = 42;
						continue;
					}
					case 42:
						goto IL_15C;
					case 43:
					{
						string[] array2;
						if (num5 >= array2.Length)
						{
							num = 31;
							continue;
						}
						string[] array4 = array2[num5].Split(new char[]
						{
							'='
						});
						num = 16;
						continue;
					}
					case 44:
						arg_7CC_0 = "trial";
						goto IL_7CC;
					case 45:
						num = 23;
						continue;
					case 46:
						eval_ap.eval_a();
						num5 = 0;
						num = 6;
						continue;
					case 47:
						this.eval_h.eval_c("all up-to-date");
						num = 36;
						continue;
					case 48:
					{
						string[] array;
						string text;
						if (text.CompareTo(array[0]) < 0)
						{
							num = 51;
							continue;
						}
						goto IL_48F;
					}
					case 49:
						goto IL_75F;
					case 50:
						goto IL_75F;
					case 51:
						this.eval_p.Enabled = true;
						this.eval_i.Items[listViewItem.Index].EnsureVisible();
						this.eval_i.Items[listViewItem.Index].Selected = true;
						num = 17;
						continue;
					case 52:
					{
						string[] array;
						string[] array7 = array[1].Split(new char[]
						{
							';'
						});
						string[] array8;
						array9 = new string[]
						{
							array8[0],
							null,
							null,
							array[0]
						};
						num = 18;
						continue;
					}
					case 53:
						return flag2;
					case 54:
						goto IL_48F;
					case 55:
						goto IL_323;
					case 56:
						num = 44;
						continue;
					case 57:
					{
						int num3;
						if (num3 > 0)
						{
							num = 41;
							continue;
						}
						goto IL_15C;
					}
					case 58:
					{
						if (true)
						{
						}
						this.eval_h.eval_c("local server");
						string[] array5;
						string[] array6;
						eval_ap.eval_a(this.eval_h.eval_b, array5[0], array6[0]);
						num = 11;
						continue;
					}
					case 59:
						this.eval_t.Text = "select plugin";
						this.eval_s.Enabled = true;
						num = 30;
						continue;
					case 60:
						A_0 = true;
						num = 8;
						continue;
					case 61:
						if (listViewItem != null)
						{
							num = 1;
							continue;
						}
						num = 34;
						continue;
					case 62:
					{
						string[] array3;
						string arg_3D6_0 = array3[array3.Length - 1];
						num4 = 0;
						num = 28;
						continue;
					}
					case 63:
					{
						string[] array7;
						array9[2] = array7[0];
						array9[1] = array7[1];
						num = 4;
						continue;
					}
					case 64:
					{
						string[] array8;
						if (array8.Length >= 2)
						{
							num = 20;
							continue;
						}
						goto IL_48F;
					}
					case 65:
						flag = false;
						this.eval_h.eval_c(text2);
						num = 25;
						continue;
					}
					break;
					IL_15C:
					num = 29;
					continue;
					IL_18E:
					num5++;
					num = 39;
					continue;
					IL_251:
					num = 5;
					continue;
					IL_323:
					num = 38;
					continue;
					IL_367:
					num = 32;
					continue;
					IL_48F:
					num4++;
					num = 19;
					continue;
					IL_4ED:
					num = 24;
					continue;
					IL_5C8:
					num = 26;
					continue;
					IL_66F:
					listViewItem = new ListViewItem(array9);
					this.eval_j.Items.Add(listViewItem);
					num = 54;
					continue;
					IL_69C:
					num = 43;
					continue;
					IL_75F:
					num = 22;
					continue;
					IL_7CC:
					a_ = arg_7CC_0;
					num = 2;
					continue;
					IL_880:
					text2 = global::eval_q.eval_a(this.eval_h.eval_h, a_, this.eval_h.o.eval_l);
					num = 12;
				}
			}
			return flag2;
		}
		}
		goto IL_0E;
	}
	private void eval_f(object A_0, EventArgs A_1)
	{
		while (true)
		{
			bool flag = false;
			this.eval_h.eval_c("contacting server...");
			bool flag2 = this.eval_a(ref flag);
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num = 6;
						continue;
					}
					num = 14;
					continue;
				case 1:
					this.eval_a(true);
					num = 7;
					continue;
				case 2:
					if (this.eval_a(ref flag))
					{
						num = 8;
						continue;
					}
					return;
				case 3:
					if (global::eval_p.eval_f())
					{
						num = 10;
						continue;
					}
					goto IL_125;
				case 4:
					num = 12;
					continue;
				case 5:
					num = 3;
					continue;
				case 6:
					num = 11;
					continue;
				case 7:
					goto IL_14B;
				case 8:
					goto IL_16B;
				case 9:
					goto IL_149;
				case 10:
					this.eval_a(true);
					num = 13;
					continue;
				case 11:
					if (this.eval_h.eval_e())
					{
						num = 4;
						continue;
					}
					return;
				case 12:
					if (global::eval_p.eval_f())
					{
						num = 1;
						continue;
					}
					goto IL_14B;
				case 13:
					goto IL_125;
				case 14:
					if (flag2)
					{
						num = 5;
						continue;
					}
					return;
				}
				break;
				IL_125:
				this.eval_h.eval_c("check again now...");
				this.eval_a(ref flag);
				num = 9;
				continue;
				IL_14B:
				num = 2;
			}
		}
		IL_149:
		return;
		IL_16B:
		if (true)
		{
		}
		this.eval_g();
	}
	private void eval_e(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 0:
				this.eval_t.Text = this.eval_j.Items[this.eval_j.SelectedIndices[0]].SubItems[0].Text;
				num = 2;
				continue;
			case 2:
				return;
			}
			if (true)
			{
			}
			if (this.eval_j.SelectedIndices.Count <= 0)
			{
				break;
			}
			num = 0;
		}
	}
	public bool eval_g()
	{
		while (true)
		{
			this.eval_i.SelectedItems.Clear();
			int num = 3;
			while (true)
			{
				DialogResult dialogResult;
				switch (num)
				{
				case 0:
					goto IL_60;
				case 1:
					goto IL_81;
				case 2:
					if (dialogResult == DialogResult.OK)
					{
						num = 4;
						continue;
					}
					return true;
				case 3:
					if (!Directory.Exists(eval_y.eval_f))
					{
						num = 5;
						continue;
					}
					goto IL_81;
				case 4:
					global::eval_p.eval_g.Clear();
					num = 0;
					continue;
				case 5:
					Directory.CreateDirectory(eval_y.eval_f);
					num = 1;
					continue;
				}
				break;
				IL_81:
				dialogResult = this.eval_h.eval_e("Get Updates");
				num = 2;
			}
		}
		IL_60:
		try
		{
			this.eval_a(0, true);
			goto IL_77;
		}
		catch (Exception ex)
		{
			this.eval_h.eval_c(ex.Message);
			goto IL_77;
		}
		return true;
		IL_77:
		if (true)
		{
		}
		return false;
	}
	private void eval_a(int A_0, bool A_1)
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			string text3;
			string text4;
			while (true)
			{
				string text = this.eval_i.Items[A_0].SubItems[1].Text;
				string text2 = this.eval_i.Items[A_0].SubItems[2].Text;
				int num = 18;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 0:
						goto IL_EF;
					case 1:
						if (text3 == "FAUtils.dll")
						{
							num = 3;
							continue;
						}
						goto IL_223;
					case 2:
						goto IL_F4;
					case 3:
						goto IL_D5;
					case 4:
						this.eval_i.Items[A_0].EnsureVisible();
						this.eval_i.Items[A_0].Selected = true;
						this.eval_i.Refresh();
						text3 = "";
						num = 13;
						continue;
					case 5:
						this.eval_h.eval_c("backup " + text3);
						File.Copy(text3, eval_y.eval_f + "\\" + text3, true);
						num = 9;
						continue;
					case 6:
						goto IL_172;
					case 7:
						if (A_0 < this.eval_i.Items.Count)
						{
							num = 6;
							continue;
						}
						goto IL_359;
					case 8:
						if (File.Exists(text3))
						{
							num = 5;
							continue;
						}
						goto IL_1C7;
					case 9:
						goto IL_1C7;
					case 10:
						num2 = 0;
						num = 17;
						continue;
					case 11:
						if (num2 >= this.eval_i.Items.Count)
						{
							if (true)
							{
							}
							num = 19;
							continue;
						}
						text3 = this.eval_i.Items[num2].SubItems[0].Text;
						num = 8;
						continue;
					case 12:
						num = 16;
						continue;
					case 13:
						if (A_1)
						{
							num = 12;
							continue;
						}
						goto IL_252;
					case 14:
						if (!(text3 == "Updater.exe"))
						{
							num = 15;
							continue;
						}
						goto IL_D5;
					case 15:
						num = 1;
						continue;
					case 16:
						if (A_0 == 0)
						{
							num = 10;
							continue;
						}
						goto IL_252;
					case 17:
						goto IL_F4;
					case 18:
						if (text.CompareTo(text2) < 0)
						{
							num = 4;
							continue;
						}
						A_0++;
						num = 7;
						continue;
					case 19:
						goto IL_252;
					}
					break;
					IL_D5:
					text4 += "2";
					num = 0;
					continue;
					IL_F4:
					num = 11;
					continue;
					IL_1C7:
					num2++;
					num = 2;
					continue;
					IL_252:
					text3 = this.eval_i.Items[A_0].SubItems[0].Text;
					this.eval_h.eval_c("getting new " + text3);
					text4 = text3;
					num = 14;
				}
			}
			IL_EF:
			goto IL_223;
			IL_172:
			this.eval_a(A_0, true);
			return;
			IL_223:
			this.eval_a(text3, eval_ap.eval_b[this.eval_c], eval_ap.eval_c[this.eval_c], eval_ap.eval_d[this.eval_c], text4, A_0);
			return;
			IL_359:
			this.eval_c();
			return;
		}
		}
		goto IL_0E;
	}
	private void eval_d(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.eval_u.Visible = true;
		this.eval_u.Enabled = true;
		this.Refresh();
		this.eval_g();
	}
	private void eval_c(object A_0, EventArgs A_1)
	{
		switch (0)
		{
		case 0:
			IL_0E:
			if (true)
			{
			}
			while (true)
			{
				this.eval_q.Enabled = false;
				string text = this.eval_s.Text;
				string text2 = this.eval_j.SelectedItems[0].SubItems[0].Text;
				int num = text2.IndexOf(".");
				int num2 = 3;
				while (true)
				{
					switch (num2)
					{
					case 0:
						text2 = text2.Substring(0, num);
						num2 = 4;
						continue;
					case 1:
						return;
					case 2:
						if (this.eval_h.eval_a(text2, text))
						{
							num2 = 7;
							continue;
						}
						return;
					case 3:
						if (num > 0)
						{
							num2 = 0;
							continue;
						}
						goto IL_D3;
					case 4:
						goto IL_D3;
					case 5:
					{
						bool flag;
						if (this.eval_a(ref flag))
						{
							num2 = 6;
							continue;
						}
						return;
					}
					case 6:
						this.eval_g();
						num2 = 1;
						continue;
					case 7:
					{
						global::eval_p.eval_f();
						this.eval_a(false);
						bool flag = false;
						num2 = 5;
						continue;
					}
					}
					break;
					IL_D3:
					num2 = 2;
				}
			}
			return;
		}
		goto IL_0E;
	}
	private void eval_b(object A_0, EventArgs A_1)
	{
		this.eval_h.eval_a(this.eval_w.Text);
	}
	public void eval_a(string A_0, string A_1, string A_2, string A_3, string A_4, int A_5)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 0:
				this.eval_d();
				num = 2;
				continue;
			case 2:
				goto IL_44;
			}
			if (true)
			{
			}
			if (this.eval_e != null)
			{
				break;
			}
			num = 0;
		}
		IL_44:
		this.eval_d.eval_a = A_0;
		this.eval_d.eval_b = A_1;
		this.eval_d.eval_c = A_2;
		this.eval_d.eval_d = A_3;
		this.eval_d.eval_e = A_4;
		this.eval_d.eval_f = A_5;
		this.eval_e.RunWorkerAsync(this.eval_d);
	}
	private void eval_a(object A_0, RunWorkerCompletedEventArgs A_1)
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			int num = 8;
			string a;
			int index;
			while (true)
			{
				switch (num)
				{
				case 0:
					goto IL_64;
				case 1:
					if (eval_ap.eval_b[this.eval_c + 1] != "")
					{
						num = 9;
						continue;
					}
					goto IL_117;
				case 2:
					goto IL_13F;
				case 3:
					goto IL_1FB;
				case 4:
				{
					if (A_1.Cancelled)
					{
						num = 11;
						continue;
					}
					eval_ap.eval_a eval_a = (eval_ap.eval_a)A_1.Result;
					a = eval_a.a;
					num = 10;
					continue;
				}
				case 5:
					if (a.Contains("227"))
					{
						num = 2;
						continue;
					}
					goto IL_26F;
				case 6:
					num = 1;
					continue;
				case 7:
					if (this.eval_c + 1 < 3)
					{
						num = 6;
						continue;
					}
					goto IL_117;
				case 9:
					goto IL_18A;
				case 10:
				{
					eval_ap.eval_a eval_a;
					if (eval_a.a.Length == 0)
					{
						num = 3;
						continue;
					}
					this.eval_h.eval_c(this.eval_d.eval_a + Environment.NewLine + a);
					index = global::eval_p.eval_g.Add(a);
					if (true)
					{
					}
					num = 7;
					continue;
				}
				case 11:
					goto IL_112;
				}
				if (A_1.Error != null)
				{
					num = 0;
					continue;
				}
				num = 4;
				continue;
				IL_117:
				num = 5;
			}
			IL_64:
			this.eval_h.eval_c(A_1.Error.Message);
			return;
			IL_112:
			this.eval_h.eval_c("Canceled");
			this.eval_b();
			return;
			IL_13F:
			global::eval_p.eval_g.RemoveAt(index);
			this.eval_h.eval_c("switching passive mode");
			eval_ap.eval_e = false;
			this.eval_a(this.eval_b, false);
			return;
			IL_18A:
			this.eval_c++;
			this.eval_h.eval_c("trying next server...");
			this.eval_a(this.eval_b, false);
			return;
			IL_1FB:
			this.eval_h.eval_f("done.");
			string text = global::eval_r.eval_b(this.eval_d.eval_a, "", ref a);
			this.eval_i.Items[this.eval_d.eval_f].SubItems[1].Text = text;
			this.eval_e();
			return;
			IL_26F:
			this.eval_b();
			return;
		}
		}
		goto IL_0E;
	}
	private void eval_e()
	{
		this.eval_b = this.eval_d.eval_f + 1;
		if (this.eval_b < this.eval_i.Items.Count)
		{
			if (true)
			{
			}
			this.eval_a(this.eval_b, true);
			return;
		}
		this.eval_c();
	}
	private void eval_a(object A_0, ProgressChangedEventArgs A_1)
	{
		this.eval_h.eval_f(".");
	}
	private void eval_d()
	{
		if (true)
		{
		}
		this.eval_e = new BackgroundWorker();
		this.eval_e.WorkerReportsProgress = true;
		this.eval_e.WorkerSupportsCancellation = true;
		this.eval_e.DoWork += new DoWorkEventHandler(this.eval_a);
		this.eval_e.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.eval_a);
		this.eval_e.ProgressChanged += new ProgressChangedEventHandler(this.eval_a);
	}
	private void eval_a(object A_0, DoWorkEventArgs A_1)
	{
		if (true)
		{
		}
		BackgroundWorker a_ = A_0 as BackgroundWorker;
		eval_ap.eval_b eval_b = (eval_ap.eval_b)A_1.Argument;
		A_1.Result = eval_ap.eval_a(eval_b.eval_a, eval_b.eval_b, eval_b.eval_c, eval_b.eval_d, eval_b.eval_e, a_, A_1);
	}
	private void eval_a(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 0:
				this.eval_e.CancelAsync();
				num = 2;
				continue;
			case 2:
				goto IL_41;
			}
			if (this.eval_e == null)
			{
				goto IL_4B;
			}
			num = 0;
		}
		IL_41:
		if (true)
		{
		}
		IL_4B:
		this.eval_u.Enabled = false;
	}
	public int eval_a(string A_0)
	{
		int result;
		while (true)
		{
			result = -1;
			int num = 0;
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					goto IL_92;
				case 2:
					if (num >= this.eval_i.Items.Count)
					{
						num2 = 6;
						continue;
					}
					num2 = 3;
					continue;
				case 3:
					if (A_0 == this.eval_i.Items[num].SubItems[4].Text)
					{
						num2 = 5;
						continue;
					}
					num++;
					if (true)
					{
					}
					num2 = 1;
					continue;
				case 4:
					goto IL_92;
				case 5:
					result = num;
					num2 = 0;
					continue;
				case 6:
					return result;
				}
				break;
				IL_92:
				num2 = 2;
			}
		}
		return result;
	}
	private void eval_c()
	{
		while (true)
		{
			this.eval_p.Enabled = false;
			this.eval_u.Visible = false;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (global::eval_p.eval_g.Count > 0)
					{
						num = 5;
						continue;
					}
					goto IL_E4;
				case 1:
					return;
				case 2:
				{
					int num2;
					if (num2 >= global::eval_p.eval_g.Count)
					{
						num = 1;
						continue;
					}
					this.eval_h.eval_c((string)global::eval_p.eval_g[num2]);
					num2++;
					num = 4;
					continue;
				}
				case 3:
					goto IL_5A;
				case 4:
					goto IL_5A;
				case 5:
				{
					this.eval_h.eval_c("Update complete with " + global::eval_p.eval_g.Count.ToString() + " error(s):");
					int num2 = 0;
					num = 3;
					continue;
				}
				}
				break;
				IL_5A:
				num = 2;
			}
		}
		return;
		IL_E4:
		if (true)
		{
		}
		this.eval_h.eval_c("Update complete");
		this.eval_h.eval_d("Update complete");
	}
	private void eval_b()
	{
		int num = 2;
		while (true)
		{
			string fileName;
			int num2;
			switch (num)
			{
			case 0:
			{
				string text;
				if (text != fileName)
				{
					num = 8;
					continue;
				}
				goto IL_FA;
			}
			case 1:
				return;
			case 3:
			{
				string text;
				this.eval_h.eval_c("restoring " + text);
				File.Copy(eval_y.eval_f + "\\" + text, text, true);
				num = 7;
				continue;
			}
			case 4:
				if (true)
				{
				}
				File.Delete("Updater.exe2");
				num = 6;
				continue;
			case 5:
			{
				string text;
				if (File.Exists(eval_y.eval_f + "\\" + text))
				{
					num = 15;
					continue;
				}
				goto IL_FA;
			}
			case 6:
				goto IL_D0;
			case 7:
				goto IL_FA;
			case 8:
				num = 13;
				continue;
			case 9:
				goto IL_14A;
			case 10:
				goto IL_17B;
			case 11:
				if (File.Exists("FAUtils.dll2"))
				{
					num = 16;
					continue;
				}
				goto IL_17B;
			case 12:
				goto IL_14A;
			case 13:
			{
				string text;
				if (text != "FAUtils.dll")
				{
					num = 3;
					continue;
				}
				goto IL_FA;
			}
			case 14:
			{
				if (num2 >= this.eval_i.Items.Count)
				{
					num = 1;
					continue;
				}
				string text = this.eval_i.Items[num2].SubItems[0].Text;
				num = 5;
				continue;
			}
			case 15:
				num = 0;
				continue;
			case 16:
				File.Delete("FAUtils.dll2");
				num = 10;
				continue;
			}
			if (File.Exists("Updater.exe2"))
			{
				num = 4;
				continue;
			}
			IL_D0:
			num = 11;
			continue;
			IL_FA:
			num2++;
			num = 9;
			continue;
			IL_14A:
			num = 14;
			continue;
			IL_17B:
			fileName = Path.GetFileName(Application.ExecutablePath);
			num2 = 0;
			num = 12;
		}
	}
	protected override void Dispose(bool disposing)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (this.eval_k != null)
				{
					num = 4;
					continue;
				}
				goto IL_68;
			case 1:
				goto IL_44;
			case 3:
				num = 0;
				continue;
			case 4:
				this.eval_k.Dispose();
				num = 1;
				continue;
			}
			if (!disposing)
			{
				goto IL_68;
			}
			num = 3;
		}
		IL_44:
		if (true)
		{
		}
		IL_68:
		base.Dispose(disposing);
	}
	private void eval_a()
	{
		if (true)
		{
		}
		this.eval_l = new GroupBox();
		this.eval_w = new TextBox();
		this.eval_v = new Label();
		this.eval_t = new Label();
		this.eval_q = new Button();
		this.eval_r = new Label();
		this.eval_s = new TextBox();
		this.eval_m = new Button();
		this.eval_n = new GroupBox();
		this.eval_u = new Button();
		this.eval_p = new Button();
		this.eval_o = new Button();
		this.eval_l.SuspendLayout();
		this.eval_n.SuspendLayout();
		base.SuspendLayout();
		this.eval_l.Controls.Add(this.eval_w);
		this.eval_l.Controls.Add(this.eval_v);
		this.eval_l.Controls.Add(this.eval_t);
		this.eval_l.Controls.Add(this.eval_q);
		this.eval_l.Controls.Add(this.eval_r);
		this.eval_l.Controls.Add(this.eval_s);
		this.eval_l.Controls.Add(this.eval_m);
		this.eval_l.Location = new Point(2, 154);
		this.eval_l.Name = "grpAvailable";
		this.eval_l.Size = new Size(481, 152);
		this.eval_l.TabIndex = 0;
		this.eval_l.TabStop = false;
		this.eval_l.Text = "Components available for purchase";
		this.eval_w.Location = new Point(54, 125);
		this.eval_w.Name = "txtRequestCode";
		this.eval_w.ReadOnly = true;
		this.eval_w.Size = new Size(154, 20);
		this.eval_w.TabIndex = 72;
		this.eval_v.AutoSize = true;
		this.eval_v.Location = new Point(14, 129);
		this.eval_v.Name = "lblCustId2";
		this.eval_v.Size = new Size(38, 13);
		this.eval_v.TabIndex = 71;
		this.eval_v.Text = "cust id";
		this.eval_t.BorderStyle = BorderStyle.FixedSingle;
		this.eval_t.Location = new Point(214, 125);
		this.eval_t.Name = "lblPlugin";
		this.eval_t.Size = new Size(72, 19);
		this.eval_t.TabIndex = 0;
		this.eval_q.Location = new Point(416, 73);
		this.eval_q.Name = "butUnlock";
		this.eval_q.Size = new Size(59, 22);
		this.eval_q.TabIndex = 5;
		this.eval_q.Text = "Unlock";
		this.eval_q.UseVisualStyleBackColor = true;
		this.eval_q.Click += new EventHandler(this.eval_c);
		this.eval_r.AutoSize = true;
		this.eval_r.Location = new Point(415, 109);
		this.eval_r.Name = "label3";
		this.eval_r.Size = new Size(59, 13);
		this.eval_r.TabIndex = 7;
		this.eval_r.Text = "unlock key";
		this.eval_s.Location = new Point(292, 124);
		this.eval_s.MaxLength = 16;
		this.eval_s.Name = "txtRetailKeyP1";
		this.eval_s.Size = new Size(182, 20);
		this.eval_s.TabIndex = 1;
		this.eval_m.Location = new Point(416, 19);
		this.eval_m.Name = "butWebpage";
		this.eval_m.Size = new Size(59, 47);
		this.eval_m.TabIndex = 6;
		this.eval_m.Text = "go to\r\nwebpage";
		this.eval_m.UseVisualStyleBackColor = true;
		this.eval_m.Click += new EventHandler(this.eval_b);
		this.eval_n.Controls.Add(this.eval_u);
		this.eval_n.Controls.Add(this.eval_p);
		this.eval_n.Controls.Add(this.eval_o);
		this.eval_n.Location = new Point(2, 1);
		this.eval_n.Name = "grpUpdate";
		this.eval_n.Size = new Size(481, 148);
		this.eval_n.TabIndex = 0;
		this.eval_n.TabStop = false;
		this.eval_n.Text = "Check for Updates";
		this.eval_u.Location = new Point(416, 14);
		this.eval_u.Name = "butCancel";
		this.eval_u.Size = new Size(59, 22);
		this.eval_u.TabIndex = 72;
		this.eval_u.Text = "&Cancel";
		this.eval_u.UseVisualStyleBackColor = true;
		this.eval_u.Click += new EventHandler(this.eval_a);
		this.eval_p.Enabled = false;
		this.eval_p.Location = new Point(416, 68);
		this.eval_p.Name = "butGetUpdates";
		this.eval_p.Size = new Size(59, 22);
		this.eval_p.TabIndex = 1;
		this.eval_p.Text = "&Get";
		this.eval_p.UseVisualStyleBackColor = true;
		this.eval_p.Click += new EventHandler(this.eval_d);
		this.eval_o.Location = new Point(416, 42);
		this.eval_o.Name = "butCheckNow";
		this.eval_o.Size = new Size(59, 22);
		this.eval_o.TabIndex = 0;
		this.eval_o.Text = "C&heck";
		this.eval_o.UseVisualStyleBackColor = true;
		this.eval_o.Click += new EventHandler(this.eval_f);
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(this.eval_n);
		base.Controls.Add(this.eval_l);
		base.Name = "UpdateTab";
		base.Size = new Size(486, 311);
		this.eval_l.ResumeLayout(false);
		this.eval_l.PerformLayout();
		this.eval_n.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
