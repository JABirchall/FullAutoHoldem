using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
internal class eval_bt
{
	private static ResourceManager eval_a;
	private static CultureInfo eval_b;
	internal eval_bt()
	{
	}
	internal static ResourceManager eval_b()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				ResourceManager resourceManager = new ResourceManager("eval_bt", typeof(eval_bt).Assembly);
				eval_bt.eval_a = resourceManager;
				num = 2;
				continue;
			}
			case 2:
				goto IL_63;
			}
			if (true)
			{
			}
			if (!object.ReferenceEquals(eval_bt.eval_a, null))
			{
				break;
			}
			num = 1;
		}
		IL_63:
		return eval_bt.eval_a;
	}
	internal static CultureInfo eval_a()
	{
		return eval_bt.eval_b;
	}
	internal static void eval_a(CultureInfo A_0)
	{
		eval_bt.eval_b = A_0;
	}
}
