using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
public class eval_ce : Form
{
	private RadioButton[] eval_a;
	private eval_n b;
	private IContainer eval_c;
	private Label eval_d;
	private Button e;
	public eval_ce(string[] A_0, eval_n A_1)
	{
		this.b = A_1;
		this.eval_a();
		this.eval_a = new RadioButton[A_0.Length - 1];
		if (A_0.Length > 1)
		{
			int i = 1;
			int num = 0;
			int num2 = this.eval_d.Bounds.Bottom + 30;
			while (i < A_0.Length)
			{
				this.eval_a[num] = new RadioButton();
				this.eval_a[num].Text = A_0[i];
				this.eval_a[num].Size = new Size(200, 20);
				this.eval_a[num].SetBounds(20, num2 + num * this.eval_a[num].Size.Height + 2, 0, 0, BoundsSpecified.Location);
				base.Controls.Add(this.eval_a[num]);
				num++;
				i++;
			}
		}
		if (this.eval_a.Length > 0)
		{
			this.eval_a[0].Checked = true;
		}
	}
	private void eval_a(object A_0, EventArgs A_1)
	{
		while (true)
		{
			int num = 0;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				case 0:
					goto IL_79;
				case 1:
					if (true)
					{
					}
					goto IL_A5;
				case 2:
					goto IL_A5;
				case 3:
				{
					int num3;
					if (num3 > 0)
					{
						num2 = 4;
						continue;
					}
					this.b.eval_a = this.eval_a[num].Text;
					num2 = 7;
					continue;
				}
				case 4:
				{
					int num3;
					this.b.eval_a = this.eval_a[num].Text.Substring(0, num3);
					num2 = 0;
					continue;
				}
				case 5:
					if (num >= this.eval_a.Length)
					{
						num2 = 9;
						continue;
					}
					num2 = 6;
					continue;
				case 6:
					if (this.eval_a[num].Checked)
					{
						num2 = 8;
						continue;
					}
					num++;
					num2 = 1;
					continue;
				case 7:
					goto IL_122;
				case 8:
				{
					int num3 = this.eval_a[num].Text.IndexOf(" ");
					num2 = 3;
					continue;
				}
				case 9:
					goto IL_C6;
				}
				break;
				IL_A5:
				num2 = 5;
			}
		}
		IL_79:
		IL_C6:
		IL_122:
		base.Close();
	}
	protected override void eval_a(bool A_0)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				this.eval_c.Dispose();
				num = 4;
				continue;
			case 2:
				if (this.eval_c != null)
				{
					num = 1;
					continue;
				}
				goto IL_68;
			case 3:
				num = 2;
				continue;
			case 4:
				goto IL_4C;
			}
			if (true)
			{
			}
			if (!A_0)
			{
				break;
			}
			num = 3;
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
		this.eval_d = new Label();
		this.e = new Button();
		base.SuspendLayout();
		this.eval_d.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.eval_d.Location = new Point(27, 9);
		this.eval_d.Name = "lblTitle";
		this.eval_d.Size = new Size(230, 36);
		this.eval_d.TabIndex = 2;
		this.eval_d.Text = "Choose poker website for the included site decode dll.";
		this.e.Location = new Point(103, 229);
		this.e.Name = "butOK";
		this.e.Size = new Size(79, 32);
		this.e.TabIndex = 3;
		this.e.Text = "OK";
		this.e.UseVisualStyleBackColor = true;
		this.e.Click += new EventHandler(this.eval_a);
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(284, 264);
		base.ControlBox = false;
		base.Controls.Add(this.e);
		base.Controls.Add(this.eval_d);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "ChooseDecode";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Choose Site Decoder";
		base.TopMost = true;
		base.ResumeLayout(false);
	}
}
