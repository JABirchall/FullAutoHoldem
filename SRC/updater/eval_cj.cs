using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
public class eval_cj : UserControl
{
	private eval_y eval_a;
	private IContainer eval_b;
	public GroupBox eval_c;
	private Label eval_d;
	public TextBox eval_e;
	private Button eval_f;
	private Label eval_g;
	public Button eval_h;
	private Label eval_i;
	public TextBox eval_j;
	public Label eval_k;
	public Button eval_l;
	public eval_cj(eval_y A_0)
	{
		this.eval_a = A_0;
		this.eval_a();
		this.eval_j.TextChanged += new EventHandler(this.eval_a);
		this.eval_k.Visible = false;
		this.eval_l.Visible = false;
		this.eval_h.Click += new EventHandler(this.eval_a.eval_e);
		this.eval_l.Click += new EventHandler(this.eval_a.eval_d);
		this.eval_f.Click += new EventHandler(this.eval_a.eval_c);
	}
	private void eval_a(object A_0, EventArgs A_1)
	{
		if (!this.eval_h.Enabled)
		{
			this.eval_h.Enabled = true;
		}
	}
	protected override void Dispose(bool disposing)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (this.eval_b != null)
				{
					num = 3;
					continue;
				}
				goto IL_68;
			case 2:
				num = 0;
				continue;
			case 3:
				this.eval_b.Dispose();
				num = 4;
				continue;
			case 4:
				goto IL_4C;
			}
			if (true)
			{
			}
			if (!disposing)
			{
				break;
			}
			num = 2;
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
		this.eval_d = new Label();
		this.eval_e = new TextBox();
		this.eval_f = new Button();
		this.eval_g = new Label();
		this.eval_h = new Button();
		this.eval_i = new Label();
		this.eval_j = new TextBox();
		this.eval_k = new Label();
		this.eval_l = new Button();
		this.eval_c.SuspendLayout();
		base.SuspendLayout();
		this.eval_c.Controls.Add(this.eval_d);
		this.eval_c.Controls.Add(this.eval_e);
		this.eval_c.Controls.Add(this.eval_f);
		this.eval_c.Controls.Add(this.eval_g);
		this.eval_c.Controls.Add(this.eval_h);
		this.eval_c.Controls.Add(this.eval_i);
		this.eval_c.Controls.Add(this.eval_j);
		this.eval_c.Location = new Point(6, 41);
		this.eval_c.Name = "grpPurchase";
		this.eval_c.Size = new Size(377, 252);
		this.eval_c.TabIndex = 1;
		this.eval_c.TabStop = false;
		this.eval_c.Text = "Purchase";
		this.eval_d.AutoSize = true;
		this.eval_d.Location = new Point(29, 207);
		this.eval_d.Name = "lblRequestCode";
		this.eval_d.Size = new Size(61, 13);
		this.eval_d.TabIndex = 69;
		this.eval_d.Text = "customer id";
		this.eval_e.BackColor = SystemColors.Control;
		this.eval_e.Location = new Point(105, 204);
		this.eval_e.Name = "txtRequestCode";
		this.eval_e.Size = new Size(180, 20);
		this.eval_e.TabIndex = 68;
		this.eval_f.Location = new Point(123, 115);
		this.eval_f.Name = "butPurchase";
		this.eval_f.Size = new Size(131, 22);
		this.eval_f.TabIndex = 5;
		this.eval_f.Text = "Open Webpage";
		this.eval_f.UseVisualStyleBackColor = true;
		this.eval_g.Location = new Point(7, 20);
		this.eval_g.Name = "lblToPurchase";
		this.eval_g.Size = new Size(279, 70);
		this.eval_g.TabIndex = 66;
		this.eval_g.Text = "To Purchase:\r\n\r\n1. Press 'Open Webpage' button.\r\n2. Add item(s) to PayPal shopping cart, etc.\r\n3. After purchase the unlock key is emailed to you.";
		this.eval_h.Location = new Point(291, 202);
		this.eval_h.Name = "butUnlock";
		this.eval_h.Size = new Size(56, 22);
		this.eval_h.TabIndex = 4;
		this.eval_h.Text = "Unlock";
		this.eval_h.UseVisualStyleBackColor = true;
		this.eval_i.AutoSize = true;
		this.eval_i.Location = new Point(29, 175);
		this.eval_i.Name = "label3";
		this.eval_i.Size = new Size(59, 13);
		this.eval_i.TabIndex = 57;
		this.eval_i.Text = "unlock key";
		this.eval_j.Location = new Point(105, 172);
		this.eval_j.MaxLength = 20;
		this.eval_j.Name = "txtRetailKeyP1";
		this.eval_j.Size = new Size(181, 20);
		this.eval_j.TabIndex = 0;
		this.eval_k.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.eval_k.Location = new Point(106, 13);
		this.eval_k.Name = "lblPromptActivate";
		this.eval_k.Size = new Size(122, 17);
		this.eval_k.TabIndex = 58;
		this.eval_k.Text = "Activate free trial?";
		this.eval_l.Location = new Point(234, 10);
		this.eval_l.Name = "butActivate";
		this.eval_l.Size = new Size(66, 22);
		this.eval_l.TabIndex = 0;
		this.eval_l.Text = "Activate";
		this.eval_l.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(this.eval_c);
		base.Controls.Add(this.eval_k);
		base.Controls.Add(this.eval_l);
		base.Name = "ActivateTab";
		base.Size = new Size(407, 313);
		this.eval_c.ResumeLayout(false);
		this.eval_c.PerformLayout();
		base.ResumeLayout(false);
	}
}
