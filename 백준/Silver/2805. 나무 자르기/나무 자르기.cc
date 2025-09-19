#include<iostream>
#include<queue>
#include<string>
#include<algorithm>

using namespace std;

int arr[1000001];

int main()
{
	long long N, M;
	long long max = 0;

	cin >> N >> M;
	for (int i = 0; i < N; ++i)
	{
		cin >> arr[i];
	}

	sort(arr, arr + N);
	long long low = 0;
	long long high = arr[N - 1];

	while (low <= high)
	{
		long long sum = 0;
		long long cut = (low + high) / 2;

		for (int i = 0; i < N; ++i)
		{
			if (arr[i] - cut > 0) sum += arr[i] - cut;
		}

		if (sum >= M)
		{
			max = cut;
			low = cut + 1;
		}
		else
		{
			high = cut - 1;
		}
	}

	cout << max;

	return 0;
}