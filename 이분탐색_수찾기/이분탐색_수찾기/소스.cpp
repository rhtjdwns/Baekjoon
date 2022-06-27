#include <iostream>
#include <algorithm>

using namespace std;

void Search(int* a,int b, int n)
{
	int mid;
	int	start = 0;
	int end = n;


	// 시작점과 끝점이 만나지 않았다면 반복
	while (start < end)
	{
		mid = (start + end) / 2;
		if (b == a[mid])
		{
			// 찾으려는 수가 존재한다면
			cout << "1" << endl;
			return;
		}
		else
		{
			// 시작값 또는 끝값을 현재 값과 비교하여 위치를 조정
			if (b > a[mid])
			{
				start = mid + 1;
			}
			else if (b < a[mid])
			{
				end = mid - 1;
			}
		}
	}
	// 찾으려는 수가 존재하지 않는다면
	cout << "0" << endl;
	return;
}

int main()
{
	int n, m, b;
	int* a;

	cin >> n;
	a = new int[n];
	for (int i = 0; i < n; ++i)
	{
		cin >> a[i];
	}
	cin >> m;

	// 오름차순 정렬
	sort(a, a + n);
	for (int i = 0; i < m; ++i)
	{
		cin >> b;
		Search(a, b, n);
	}

	return 0;
}