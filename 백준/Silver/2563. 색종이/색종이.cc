#include <iostream>

using namespace std;

int main()
{
	bool paper[101][101] = {0,};
	int N;
	int a, b;
	int count = 0;

	cin >> N;
	for (int i = 0; i < N; ++i)
	{
		cin >> a >> b;
		for (int j = a; j < a + 10; ++j)
			for (int k = b; k < b + 10; ++k)
				paper[k][j] = true;
	}

	for (int i = 1; i <= 100; ++i)
	{
		for (int j = 1; j <= 100; ++j)
		{
			if (paper[i][j])
				count++;
		}
	}

	cout << count;

	return 0;
}