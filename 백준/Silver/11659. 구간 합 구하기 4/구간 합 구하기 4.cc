#include <iostream>

using namespace std;

int nums[100000];
int results[100000];
int dp[100000];

int main()
{
	ios_base::sync_with_stdio(false);
	cout.tie(NULL);
	cin.tie(NULL);

	int N, M;
	int num;

	cin >> N >> M;
	for (int i = 0; i < N; ++i)
	{
		cin >> num;
		nums[i] = num;
		if (i == 0)
		{
			dp[i] = num;
		}
		else
		{
			dp[i] = dp[i - 1] + num;
		}
	}

	for (int i = 0; i < M; ++i)
	{
		int a, b;
		cin >> a >> b;

		results[i] = dp[b - 1] - dp[a - 2];
	}

	for (int i = 0; i < M; ++i)
	{
		cout << results[i] << '\n';
	}

	return 0;
}