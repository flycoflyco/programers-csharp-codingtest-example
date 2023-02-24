using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_CSharp_Codingtest_Example.ExampleSourceCode_Lv0
{
	public class Babbling
	{
		//옹알이

		// 머쓱이는 태어난 지 6개월 된 조카를 돌보고 있습니다.
		// 조카는 아직 "aya", "ye", "woo", "ma" 네 가지 발음을 최대 한 번씩 사용해 조합한(이어 붙인) 발음밖에 하지 못합니다.
		// 문자열 배열 babbling이 매개변수로 주어질 때, 머쓱이의 조카가 발음할 수 있는 단어의 개수를 return하도록 solution 함수를 완성해주세요.
		
		public int solution(string[] babbling)
		{
			int answer = 0;
			string[] canText = { "aya", "ye", "woo", "ma" }; // 발음

			// 주어진 단어 순회 하면서
			foreach (string text in babbling)
			{
				string[] splits = text.Split(canText, StringSplitOptions.None); // 단어 쪼개고

				int temp = 0;
				foreach (string split in splits)
					if (string.IsNullOrEmpty(split))
						temp++;

				if (temp == splits.Length) answer++;
			}
			return answer;
		}
	}
}
