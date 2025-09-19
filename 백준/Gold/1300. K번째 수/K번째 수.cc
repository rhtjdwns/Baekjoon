#include<iostream>
#include<queue>
#include<string>
#include<algorithm>

using namespace std;

int arr[1000000];

int main()
{
	int N, k;
	int left = 1, right = 0, mid = 0;
	int res = 0;
	int count = 0;

	cin >> N >> k;

	right = k;

	while (left <= right)
	{
		int cnt = 0;
		mid = (left + right) / 2;

		for (int i = 1; i <= N; ++i)
		{
			cnt += min(N, mid / i);
		}

		if (cnt >= k)
		{
			res = mid;
			right = mid - 1;
		}
		else
		{
			left = mid + 1;
		}
	}

	cout << res;

	return 0;
}