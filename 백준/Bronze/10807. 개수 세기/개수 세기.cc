#include <iostream>

using namespace std;

int main()
{
	int N, v;
	int n[100];
	int result = 0;

	cin >> N;

	for (int i = 0; i < N; ++i)
	{
		cin >> n[i];
	}

	cin >> v;

	for (int i = 0; i < N; ++i)
	{
		if (v == n[i]) result++;
	}

	cout << result;

	return 0;
}