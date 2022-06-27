#include <iostream>

using namespace std;

int main()
{
	int count, num;
	int* weight, * height;
	int* sort;
	cin >> count;
	weight = new int[count];
	height = new int[count];
	sort = new int[count];
	for (int i = 0; i < count; ++i)
	{
		cin >> weight[i] >> height[i];

		while (weight[i] < 10 || weight[i] > 200 && height[i] < 10 || height[i] > 200)
		{
			cin >> weight[i] >> height[i];
		}
		sort[i] = 1;
	}
	for (int i = 0; i < count; ++i)
	{
		for (int j = 0; j < count; ++j)
		{
			if (weight[i] < weight[j] && height[i] < height[j])
				sort[i] += 1;
		}
	}
	for (int i = 0; i < count; ++i)
		cout << sort[i] << " ";
	return 0;
}