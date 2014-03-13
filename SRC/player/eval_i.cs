using System;
using System.Drawing;
public class eval_i
{
	private static eval_k eval_a;
	private static eval_k eval_b;
	public void eval_a(int A_0)
	{
		while (true)
		{
			eval_i.eval_a = eval_a6.l.eval_i();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 0:
					eval_i.eval_b = eval_a6.l.eval_j();
					num = 1;
					continue;
				case 1:
					return;
				case 2:
					if (true)
					{
					}
					if (A_0 == 6)
					{
						num = 4;
						continue;
					}
					num = 3;
					continue;
				case 3:
					if (A_0 == 9)
					{
						num = 0;
						continue;
					}
					return;
				case 4:
					goto IL_47;
				}
				break;
			}
		}
		IL_47:
		eval_i.eval_b = eval_a6.l.eval_k();
	}
	public decimal eval_a(Bitmap A_0, decimal A_1)
	{
		while (true)
		{
			decimal num = eval_be.eval_a(A_0, eval_i.eval_a);
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				case 0:
					if (true)
					{
					}
					num2 = 7;
					continue;
				case 1:
					return A_1;
				case 2:
					if (num < 0m)
					{
						num2 = 1;
						continue;
					}
					return num;
				case 3:
					num = eval_be.eval_a(A_0, eval_i.eval_b);
					num2 = 5;
					continue;
				case 4:
					if (num < 0m)
					{
						num2 = 0;
						continue;
					}
					return num;
				case 5:
					if (num < A_1)
					{
						num2 = 6;
						continue;
					}
					goto IL_5F;
				case 6:
					return A_1;
				case 7:
					if (eval_i.eval_b != null)
					{
						num2 = 3;
						continue;
					}
					goto IL_5F;
				}
				break;
				IL_5F:
				num2 = 2;
			}
		}
		return A_1;
	}
}
