using System;
using System.Drawing;
using System.Globalization;
public class eval_v : eval_ci
{
	public bool eval_b(Bitmap A_0)
	{
		return eval_bk.eval_d(A_0);
	}
	public string eval_a(out decimal A_0, out decimal A_1, Bitmap A_2, out bool A_3)
	{
		switch (0)
		{
		case 0:
		{
			IL_0E:
			string result;
			while (true)
			{
				result = "";
				A_0 = 0m;
				A_1 = 0m;
				A_3 = false;
				bool flag = eval_bk.eval_c(A_2);
				int num = 1;
				while (true)
				{
					switch (num)
					{
					case 0:
					{
						string text;
						if (text.Length == 0)
						{
							num = 13;
							continue;
						}
						try
						{
							A_0 = decimal.Parse(text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowCurrencySymbol);
							result = "Call";
							goto IL_202;
						}
						catch
						{
							eval_s.eval_a(A_2, "cal1" + text);
							goto IL_202;
						}
						goto Block_7;
					}
					case 1:
					{
						if (flag)
						{
							num = 4;
							continue;
						}
						string text = eval_bk.eval_a(A_2, 1);
						num = 0;
						continue;
					}
					case 2:
					{
						string text2;
						if (text2.Length > 0)
						{
							num = 6;
							continue;
						}
						return result;
					}
					case 3:
					{
						string text3 = eval_bk.eval_a(A_2, 2);
						num = 10;
						continue;
					}
					case 4:
						goto IL_1EE;
					case 5:
						return result;
					case 6:
						goto IL_1C5;
					case 7:
						try
						{
							string text3;
							A_0 = decimal.Parse(text3, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowCurrencySymbol);
							goto IL_95;
						}
						catch
						{
							string text3;
							eval_s.eval_a(A_2, "nr2" + text3);
							result = "Error";
							goto IL_95;
						}
						goto IL_D9;
						IL_95:
						result = "Call";
						num = 9;
						continue;
					case 8:
						goto IL_202;
					case 9:
						return result;
					case 10:
					{
						string text3;
						if (text3.Length > 0)
						{
							num = 7;
							continue;
						}
						result = "Error";
						num = 5;
						continue;
					}
					case 11:
					{
						if (A_3)
						{
							num = 3;
							continue;
						}
						string text2 = eval_bk.eval_a(A_2, 2);
						num = 2;
						continue;
					}
					case 12:
						goto IL_202;
					case 13:
						goto IL_D9;
					}
					break;
					IL_D9:
					if (true)
					{
					}
					A_3 = true;
					num = 12;
					continue;
					IL_1EE:
					result = "Check";
					num = 8;
					continue;
					Block_7:
					try
					{
						IL_1C5:
						string text2;
						A_1 = decimal.Parse(text2, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowCurrencySymbol);
						return result;
					}
					catch
					{
						string text2;
						eval_s.eval_a(A_2, "ra2" + text2);
						return result;
					}
					goto IL_1EE;
					IL_202:
					num = 11;
				}
			}
			return result;
		}
		}
		goto IL_0E;
	}
	public decimal eval_c(Bitmap A_0)
	{
		decimal result = 0m;
		string text = eval_bk.eval_a(A_0, 2);
		if (text.Length > 1)
		{
			try
			{
				result = decimal.Parse(text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowCurrencySymbol);
			}
			catch
			{
				eval_s.eval_a(A_0, "vrr" + text);
			}
		}
		if (true)
		{
		}
		return result;
	}
	public decimal eval_a(Bitmap A_0)
	{
		decimal result = 0m;
		string text = eval_bk.eval_a(A_0, 1);
		if (text.Length > 1)
		{
			try
			{
				result = decimal.Parse(text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowCurrencySymbol);
			}
			catch
			{
				eval_s.eval_a(A_0, "vcr" + text);
			}
		}
		if (true)
		{
		}
		return result;
	}
}
