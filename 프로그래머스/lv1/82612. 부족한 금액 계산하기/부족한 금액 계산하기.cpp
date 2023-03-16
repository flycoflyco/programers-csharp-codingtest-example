using namespace std;

long long solution(int price, int money, int count)
{
			long result = 0;
			long needMoney = 0;
			for ( long i = 1; i <= count; i++)
			{
				needMoney = needMoney + (price * i);
			}

			if ( (money - needMoney) > 0)
				result = 0;
			else
				result = needMoney - money;

			return result;
}