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
		// temp[i]�� �̿��Ͽ� temp[i] ���� �������� ������ �����Ƿ�
		for (int j = temp[i]; j <= b; ++j)
		{
			// ex : 1�� ¥���� �̿��Ͽ� 10���� ����°�� DP[10] = DP[10 - 1] = 1
			// ���� temp[i]������ j���� ����� ���ؼ��� j - temp[i]���� ����� 
			// ����� �� ��ŭ ������� �Ѵ�.
			coin[j] += coin[j - temp[i]];
		}
	}

	cout << coin[b];
	return 0;
}

