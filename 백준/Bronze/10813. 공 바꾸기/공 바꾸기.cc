#include <iostream>

using namespace std;

#define MAX 100

int main()
{
	int N, M;
	int arr[MAX];

	cin >> N >> M;

	for (int i = 0; i < N; ++i)
	{
		arr[i] = i + 1;
	}

	for (int k = 0; k < M; ++k)
	{
		int i, j;

		cin >> i >> j;

		int temp = arr[i - 1];
		arr[i - 1] = arr[j - 1];
		arr[j - 1] = temp;
	}

	for (int i = 0; i < N; ++i)
	{
		cout << arr[i] << " ";
	}

	return 0;
}