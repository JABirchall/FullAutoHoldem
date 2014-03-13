using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
public class eval_m : UserControl
{
	private eval_y eval_a;
	private IContainer eval_b;
	private GroupBox eval_c;
	private ListView eval_d;
	private Button eval_e;
	private Label eval_f;
	private TextBox eval_g;
	public eval_m(eval_y A_0)
	{
		this.eval_a = A_0;
		this.eval_a();
		string text = "data\\Player.xml";
		string text2 = this.eval_a.eval_l + "\\data\\";
		if (File.Exists(text))
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(text);
				XmlNode xmlNode = xmlDocument.GetElementsByTagName("plyrDbName")[0];
				string text3 = xmlNode.InnerText;
				text3 = Path.GetDirectoryName(text3);
				if (text3 != null && text3.Length > 1)
				{
					text2 = text3;
				}
			}
			catch
			{
			}
		}
		this.eval_g.Text = text2;
		this.eval_a(text2);
	}
	protected void eval_b()
	{
		if (true)
		{
		}
		this.eval_d.HideSelection = false;
		this.eval_d.Clear();
		this.eval_d.Columns.Add("name", 111, HorizontalAlignment.Left);
		this.eval_d.Columns.Add("old size", 72, HorizontalAlignment.Left);
		this.eval_d.Columns.Add("new size", 72, HorizontalAlignment.Left);
	}
	protected string eval_b(string A_0)
	{
		if (true)
		{
		}
		string[] array = A_0.Split(new char[]
		{
			'\\'
		});
		int num = array.Length;
		return array[num - 1];
	}
	public void eval_a(string A_0)
	{
		switch (0)
		{
		case 0:
			IL_0E:
			while (true)
			{
				string[] array = new string[3];
				this.eval_b();
				bool flag = false;
				int num = 1;
				while (true)
				{
					switch (num)
					{
					case 0:
						if (flag)
						{
							num = 4;
							continue;
						}
						return;
					case 1:
						if (!Directory.Exists(A_0))
						{
							num = 6;
							continue;
						}
						flag = true;
						num = 5;
						continue;
					case 2:
						return;
					case 3:
						if (this.eval_d.Items.Count > 0)
						{
							num = 7;
							continue;
						}
						return;
					case 4:
						try
						{
							while (true)
							{
								string[] files = Directory.GetFiles(A_0, "*.mdb");
								string[] array2 = files;
								int num2 = 0;
								num = 3;
								while (true)
								{
									switch (num)
									{
									case 0:
										num = 1;
										continue;
									case 1:
										goto IL_1EB;
									case 2:
									{
										if (num2 >= array2.Length)
										{
											num = 0;
											continue;
										}
										string text = array2[num2];
										string text2 = text;
										FileInfo fileInfo = new FileInfo(text2);
										long arg_17E_0 = fileInfo.Length;
										array[0] = this.eval_b(text2);
										FileInfo fileInfo2 = new FileInfo(text2);
										array[1] = fileInfo2.Length.ToString();
										array[2] = "?";
										ListViewItem value = new ListViewItem(array, 0);
										this.eval_d.Items.Add(value);
										num2++;
										num = 4;
										continue;
									}
									case 3:
										goto IL_149;
									case 4:
										goto IL_149;
									}
									break;
									IL_149:
									num = 2;
								}
							}
							IL_1EB:
							goto IL_76;
						}
						catch (IOException ex)
						{
							MessageBox.Show("Error: Drive not ready or directory does not exist." + ex.Message);
							goto IL_76;
						}
						catch (UnauthorizedAccessException ex2)
						{
							MessageBox.Show("Error: Drive or directory access denided." + ex2.Message);
							goto IL_76;
						}
						catch (Exception arg)
						{
							MessageBox.Show("Error: " + arg);
							goto IL_76;
						}
						goto IL_245;
						IL_76:
						num = 3;
						continue;
					case 5:
						goto IL_245;
					case 6:
						MessageBox.Show("Required data directory " + A_0 + " does not exist.\nPlease repair.");
						num = 8;
						continue;
					case 7:
						this.eval_d.Items[0].Selected = true;
						this.eval_d.Items[0].Focused = true;
						num = 2;
						continue;
					case 8:
						goto IL_245;
					}
					break;
					IL_245:
					if (true)
					{
					}
					num = 0;
				}
			}
			return;
		}
		goto IL_0E;
	}
	private void eval_a(object A_0, EventArgs A_1)
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			int num = 9;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					goto IL_1E6;
				case 1:
				{
					DialogResult dialogResult = this.eval_a.eval_e("Tools");
					num = 7;
					continue;
				}
				case 2:
					return;
				case 3:
					num = 4;
					continue;
				case 4:
					if (this.eval_d.SelectedItems[0].Text.Length > 0)
					{
						num = 1;
						continue;
					}
					return;
				case 5:
				{
					string text = "data\\" + this.eval_d.SelectedItems[0].SubItems[0].Text;
					string a_ = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + text + ";";
					this.eval_a.eval_c("backup " + text);
					File.Copy(text, eval_y.eval_f + "\\" + this.eval_d.SelectedItems[0].SubItems[0].Text, true);
					this.eval_a.eval_c("compact " + text);
					eval_ar.eval_a(a_, text);
					this.eval_a.eval_c("done");
					FileInfo fileInfo = new FileInfo(text);
					this.eval_d.SelectedItems[0].SubItems[2].Text = fileInfo.Length.ToString();
					num = 2;
					continue;
				}
				case 6:
					Directory.CreateDirectory(eval_y.eval_f);
					num = 0;
					continue;
				case 7:
				{
					DialogResult dialogResult;
					if (dialogResult == DialogResult.OK)
					{
						num = 5;
						continue;
					}
					return;
				}
				case 8:
					if (this.eval_d.SelectedIndices.Count > 0)
					{
						num = 3;
						continue;
					}
					return;
				}
				if (!Directory.Exists(eval_y.eval_f))
				{
					num = 6;
					continue;
				}
				IL_1E6:
				num = 8;
			}
			return;
		}
		}
		goto IL_0E;
	}
	protected override void Dispose(bool disposing)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				num = 2;
				continue;
			case 2:
				if (this.eval_b != null)
				{
					num = 4;
					continue;
				}
				goto IL_68;
			case 3:
				goto IL_4C;
			case 4:
				this.eval_b.Dispose();
				num = 3;
				continue;
			}
			if (true)
			{
			}
			if (!disposing)
			{
				break;
			}
			num = 1;
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
		this.eval_c = new GroupBox();
		this.eval_e = new Button();
		this.eval_d = new ListView();
		this.eval_f = new Label();
		this.eval_g = new TextBox();
		this.eval_c.SuspendLayout();
		base.SuspendLayout();
		this.eval_c.Controls.Add(this.eval_g);
		this.eval_c.Controls.Add(this.eval_f);
		this.eval_c.Controls.Add(this.eval_e);
		this.eval_c.Controls.Add(this.eval_d);
		this.eval_c.Location = new Point(3, 3);
		this.eval_c.Name = "grpDbTools";
		this.eval_c.Size = new Size(414, 270);
		this.eval_c.TabIndex = 6;
		this.eval_c.TabStop = false;
		this.eval_c.Text = "DataBase";
		this.eval_e.Location = new Point(15, 54);
		this.eval_e.Name = "butCompact";
		this.eval_e.Size = new Size(99, 23);
		this.eval_e.TabIndex = 15;
		this.eval_e.Text = "compact/repair";
		this.eval_e.UseVisualStyleBackColor = true;
		this.eval_e.Click += new EventHandler(this.eval_a);
		this.eval_d.FullRowSelect = true;
		this.eval_d.Location = new Point(129, 54);
		this.eval_d.Name = "lstDbFiles";
		this.eval_d.Size = new Size(261, 103);
		this.eval_d.TabIndex = 14;
		this.eval_d.UseCompatibleStateImageBehavior = false;
		this.eval_d.View = View.Details;
		this.eval_f.AutoSize = true;
		this.eval_f.Location = new Point(72, 27);
		this.eval_f.Name = "lblDataDir";
		this.eval_f.Size = new Size(42, 13);
		this.eval_f.TabIndex = 16;
		this.eval_f.Text = "data dir";
		this.eval_g.Location = new Point(129, 24);
		this.eval_g.Name = "txtDataDir";
		this.eval_g.ReadOnly = true;
		this.eval_g.Size = new Size(261, 20);
		this.eval_g.TabIndex = 17;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(this.eval_c);
		base.Name = "ToolsTab";
		base.Size = new Size(436, 299);
		this.eval_c.ResumeLayout(false);
		this.eval_c.PerformLayout();
		base.ResumeLayout(false);
	}
}
