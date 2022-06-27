#include <iostream>

using namespace std;

int main()
{
	string a, b;
	int T, one, zero;
	int* temp;

	cin >> T;
	temp = new int[T];
	for (int i = 0; i < T; ++i)
	{
		cin >> a >> b;
		one = zero = 0;
		for (int j = 0; j < a.length(); ++j)
		{
			if (a[j] != b[j])
				if (a[j] == '1') ++one;
				else ++zero;
		}
		if (one > zero) temp[i] = one;
		else if (one < zero) temp[i] = zero;
		else temp[i] = one;
	}

	for (int i = 0; i < T; ++i)
		cout << temp[i] << endl;
}