#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	int a = 0;
	int* num;
	vector<int> vec;

	cin >> a;
	num = new int[a];

	for (int i = 0; i < a; ++i)
	{
		cin >> num[i];
	}

	for (int i = 0; i < a; ++i)
	{
		if (i == 0)
		{
			vec.push_back(num[i]);
			continue;
		}

		if (num[i] > vec.back())
			vec.push_back(num[i]);
		else if (num[i] <= vec.back())
		{
			auto temp = lower_bound(vec.begin(), vec.end(), num[i]);
			*temp = num[i];
		}
	}

	cout << (int)vec.size();
	return 0;
}