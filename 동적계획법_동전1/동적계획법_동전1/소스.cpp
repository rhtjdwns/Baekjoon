#include <iostream>

using namespace std;

int main()
{
	int coin[10001] = { 0 };
	int* temp;
	int a = 0, b = 0, count = 0;

	cin >> a >> b;
	temp = new int[a];

	for (int i = 0; i < a; ++i)
		cin >> temp[i];

	coin[0] = 1;
	for (int i = 0; i < a; ++i)
	{
		// temp[i]를 이용하여 temp[i] 보다 작은수를 만들어낼순 없으므로
		for (int j = temp[i]; j <= b; ++j)
		{
			// ex : 1원 짜리를 이용하여 10원을 만드는경우 DP[10] = DP[10 - 1] = 1
			// 내가 temp[i]원으로 j원을 만들기 위해서는 j - temp[i]원을 만드는 
			// 경우의 수 만큼 더해줘야 한다.
			coin[j] += coin[j - temp[i]];
		}
	}

	cout << coin[b];
	return 0;
}

