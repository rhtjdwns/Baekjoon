#include <iostream>

using namespace std;

int main()
{
	int X, N, a, b;
	int result = 0;

	cin >> X >> N;

	for (int i = 0; i < N; ++i)
	{
		cin >> a >> b;

		result += a * b;
	}

	cout << (result == X ? "Yes" : "No");

	return 0;
}