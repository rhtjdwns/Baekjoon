#include<iostream>

using namespace std;

int arr[10000];

int main()
{
	int N, M;
	int left = 0, right = 0;
	int sum, count = 0;

	cin >> N;
	cin >> M;

	for (int i = 0; i < N; ++i)
	{
		cin >> arr[i];
	}

	sum = arr[0];

	while (right < N)
	{
		if (sum == M)
		{
			count++;
			sum += arr[++right];
		}
		else if (sum < M)
		{
			sum += arr[++right];
		}
		else
		{
			sum -= arr[left++];
		}
	}

	cout << count;

	return 0;
}