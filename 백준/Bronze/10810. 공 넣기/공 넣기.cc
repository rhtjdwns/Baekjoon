#include <iostream>

using namespace std;

int main()
{
	int N, M;
	int i, j, k;
	int* ball;

	cin >> N >> M;

	ball = new int[N];

	for (int a = 0; a < N; ++a)
		ball[a] = 0;

	for (int a = 0; a < M; ++a)
	{
		cin >> i >> j >> k;
		for (int b = i - 1; b < j; ++b)
		{
			ball[b] = k;
		}
	}

	for (int a = 0; a < N; ++a)
	{
		cout << ball[a] << " ";
	}
}