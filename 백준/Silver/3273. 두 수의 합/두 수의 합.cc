#include<iostream>
#include<algorithm>

using namespace std;

int arr[100000];

int main()
{
	int n, x;
	int left = 0, right = 0;
	int count = 0;
	int sum = 0;

	cin >> n;

	for (int i = 0; i < n; ++i)
	{
		cin >> arr[i];
	}

	cin >> x;
	sort(arr, arr + n);
	right = n - 1;

	while (left < right)
	{
		sum = arr[left] + arr[right];
		if (sum == x)
		{
			count++;
			left++;
			right--;
		}
		else if (sum < x)
		{
			left++;
		}
		else
		{
			right--;
		}
	}

	std::cout << count;
}