using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
public class eval_cd : UserControl
{
	private eval_by eval_a;
	private string eval_b = "data\\OutOpts.xml";
	private IContainer eval_c;
	public ComboBox eval_d;
	private Label eval_e;
	public CheckBox eval_f;
	public CheckBox eval_g;
	public eval_cd(eval_by A_0)
	{
		this.eval_a = A_0;
		this.eval_a();
		BetConfig betConfig;
		if (File.Exists(this.eval_b))
		{
			StreamReader streamReader = new StreamReader(this.eval_b);
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(BetConfig));
			betConfig = (BetConfig)xmlSerializer.Deserialize(streamReader.BaseStream);
			streamReader.Close();
			this.eval_g.Checked = betConfig.PairOnBnotMine;
			this.eval_f.Checked = betConfig.DropLowOvers;
		}
		else
		{
			betConfig = new BetConfig();
			betConfig.MinFlushCard = '2';
		}
		if (this.eval_d.Items.Contains(betConfig.MinFlushCard.ToString()))
		{
			this.eval_d.Text = betConfig.MinFlushCard.ToString();
		}
		else
		{
			this.eval_d.Text = "2";
		}
		base.Enter += new EventHandler(this.eval_b);
		base.Leave += new EventHandler(this.eval_a);
	}
	private void eval_b(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.eval_g.CheckedChanged += new EventHandler(this.eval_c);
		this.eval_f.CheckedChanged += new EventHandler(this.eval_c);
		this.eval_d.SelectedIndexChanged += new EventHandler(this.eval_c);
	}
	private void eval_a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		this.eval_g.CheckedChanged -= new EventHandler(this.eval_c);
		this.eval_f.CheckedChanged -= new EventHandler(this.eval_c);
		this.eval_d.SelectedIndexChanged -= new EventHandler(this.eval_c);
	}
	public void eval_c(object A_0, EventArgs A_1)
	{
		this.eval_b();
	}
	public void eval_b()
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			BetConfig betConfig;
			char minFlushCard;
			while (true)
			{
				betConfig = new BetConfig();
				betConfig.DropLowOvers = this.eval_f.Checked;
				betConfig.PairOnBnotMine = this.eval_g.Checked;
				int num = 1;
				while (true)
				{
					switch (num)
					{
					case 0:
						minFlushCard = '2';
						if (true)
						{
						}
						num = 3;
						continue;
					case 1:
						if (this.eval_d.Text.Length == 0)
						{
							num = 0;
							continue;
						}
						minFlushCard = this.eval_d.Text[0];
						num = 2;
						continue;
					case 2:
						goto IL_90;
					case 3:
						goto IL_A9;
					}
					break;
				}
			}
			IL_90:
			IL_A9:
			betConfig.MinFlushCard = minFlushCard;
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(BetConfig));
			StreamWriter streamWriter = new StreamWriter(this.eval_b, false);
			xmlSerializer.Serialize(streamWriter.BaseStream, betConfig);
			streamWriter.Close();
			return;
		}
		}
		goto IL_0E;
	}
	protected override void Dispose(bool disposing)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 0:
				goto IL_44;
			case 1:
				if (this.eval_c != null)
				{
					if (true)
					{
					}
					num = 2;
					continue;
				}
				goto IL_68;
			case 2:
				this.eval_c.Dispose();
				num = 0;
				continue;
			case 4:
				num = 1;
				continue;
			}
			if (!disposing)
			{
				break;
			}
			num = 4;
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
		this.eval_d = new ComboBox();
		this.eval_e = new Label();
		this.eval_f = new CheckBox();
		this.eval_g = new CheckBox();
		base.SuspendLayout();
		this.eval_d.FormattingEnabled = true;
		this.eval_d.Items.AddRange(new object[]
		{
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"T",
			"J",
			"Q",
			"K",
			"A"
		});
		this.eval_d.Location = new Point(160, 4);
		this.eval_d.Name = "cboFlushCall";
		this.eval_d.Size = new Size(39, 21);
		this.eval_d.TabIndex = 0;
		this.eval_e.AutoSize = true;
		this.eval_e.Location = new Point(-1, 2);
		this.eval_e.Name = "lblFlushCall2";
		this.eval_e.Size = new Size(158, 26);
		this.eval_e.TabIndex = 1;
		this.eval_e.Text = "flush draw, drop outs in calc-call\r\nif my only flush card less than";
		this.eval_f.AutoSize = true;
		this.eval_f.Location = new Point(1, 32);
		this.eval_f.Name = "chkDropOCOuts";
		this.eval_f.Size = new Size(182, 30);
		this.eval_f.TabIndex = 2;
		this.eval_f.Text = "inside draw, drop outs in calc-call\r\nfor overcards less than A,K";
		this.eval_f.UseVisualStyleBackColor = true;
		this.eval_g.AutoSize = true;
		this.eval_g.Location = new Point(1, 66);
		this.eval_g.Name = "chkNotMyPair";
		this.eval_g.Size = new Size(175, 17);
		this.eval_g.TabIndex = 3;
		this.eval_g.Text = "don't call pair on board my 2pair";
		this.eval_g.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(this.eval_g);
		base.Controls.Add(this.eval_f);
		base.Controls.Add(this.eval_e);
		base.Controls.Add(this.eval_d);
		base.Margin = new Padding(0);
		base.Name = "OutsOpts";
		base.Size = new Size(207, 105);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
