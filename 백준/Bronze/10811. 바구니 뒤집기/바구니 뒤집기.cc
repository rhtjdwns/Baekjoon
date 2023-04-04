#include <iostream>

using namespace std;

int main()
{
	int N, M;
	int i, j;
	int* basket;

	cin >> N >> M;

	basket = new int[N + 1];
	for (int a = 1; a <= N; ++a)
	{
		basket[a] = a;
	}

	for (int a = 0; a < M; ++a)
	{
		cin >> i >> j;

		while (i < j)
		{
			int temp = basket[i];
			basket[i++] = basket[j];
			basket[j--] = temp;
		}
	}

	for (int a = 1; a < N + 1; ++a)
	{
		cout << basket[a] << " ";
	}
}