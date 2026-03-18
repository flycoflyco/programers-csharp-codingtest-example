using System;

namespace ConsoleApp1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string A = Console.ReadLine();
			string B = Console.ReadLine();

			Console.WriteLine(AddSigned(A, B));       // A + B
			Console.WriteLine(SubSigned(A, B));       // A - B
			Console.WriteLine(MulSigned(A, B));       // A * B
		}

		// ==========================
		// 부호 포함 덧셈
		// ==========================
		public static string AddSigned(string s1, string s2)
		{
			bool neg1 = s1.StartsWith("-");
			bool neg2 = s2.StartsWith("-");

			if (neg1) s1 = s1.Substring(1);
			if (neg2) s2 = s2.Substring(1);

			string result;

			if (neg1 == neg2)
			{
				result = Add(s1, s2);
				if (result == "0") return "0";
				return neg1 ? "-" + result : result;
			}
			else
			{
				if (IsGreater(s1, s2))
				{
					result = Subtract(s1, s2);
					if (result == "0") return "0";
					return neg1 ? "-" + result : result;
				}
				else
				{
					result = Subtract(s2, s1);
					if (result == "0") return "0";
					return neg2 ? "-" + result : result;
				}
			}
		}

		// ==========================
		// 부호 포함 뺄셈 (A - B)
		// ==========================
		public static string SubSigned(string A, string B)
		{
			// A - B = A + (-B)
			if (B.StartsWith("-"))
				return AddSigned(A, B.Substring(1));
			else
				return AddSigned(A, "-" + B);
		}

		// ==========================
		// 부호 포함 곱셈
		// ==========================
		public static string MulSigned(string s1, string s2)
		{
			bool neg1 = s1.StartsWith("-");
			bool neg2 = s2.StartsWith("-");

			if (neg1) s1 = s1.Substring(1);
			if (neg2) s2 = s2.Substring(1);

			string result = Multiply(s1, s2);

			if (result == "0") return "0";

			return (neg1 ^ neg2) ? "-" + result : result;
		}

		// ==========================
		// 덧셈
		// ==========================
		public static string Add(string a, string b)
		{
			int i = a.Length - 1;
			int j = b.Length - 1;
			int carry = 0;
			string result = "";

			while (i >= 0 || j >= 0 || carry > 0)
			{
				int digitA = (i >= 0) ? a[i] - '0' : 0;
				int digitB = (j >= 0) ? b[j] - '0' : 0;

				int sum = digitA + digitB + carry;
				carry = sum / 10;

				result = (sum % 10) + result;

				i--;
				j--;
			}

			return result;
		}

		// ==========================
		// 뺄셈 (a >= b)
		// ==========================
		public static string Subtract(string a, string b)
		{
			int i = a.Length - 1;
			int j = b.Length - 1;
			int borrow = 0;
			string result = "";

			while (i >= 0)
			{
				int digitA = a[i] - '0';
				int digitB = (j >= 0) ? b[j] - '0' : 0;

				int diff = digitA - digitB - borrow;

				if (diff < 0)
				{
					diff += 10;
					borrow = 1;
				}
				else
				{
					borrow = 0;
				}

				result = diff + result;

				i--;
				j--;
			}

			result = result.TrimStart('0');
			return result == "" ? "0" : result;
		}

		// ==========================
		// 곱셈
		// ==========================
		public static string Multiply(string a, string b)
		{
			int[] result = new int[a.Length + b.Length];

			for (int i = a.Length - 1; i >= 0; i--)
			{
				for (int j = b.Length - 1; j >= 0; j--)
				{
					int mul = (a[i] - '0') * (b[j] - '0');
					int sum = mul + result[i + j + 1];

					result[i + j + 1] = sum % 10;
					result[i + j] += sum / 10;
				}
			}

			string res = string.Join("", result).TrimStart('0');
			return res == "" ? "0" : res;
		}

		// ==========================
		// 크기 비교
		// ==========================
		public static bool IsGreater(string a, string b)
		{
			if (a.Length != b.Length)
				return a.Length > b.Length;

			return string.Compare(a, b) > 0;
		}
	}
}