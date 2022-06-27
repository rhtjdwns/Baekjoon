#include <iostream>
#include <algorithm>

using namespace std;

void Search(int* a,int b, int n)
{
	int mid;
	int	start = 0;
	int end = n;


	// �������� ������ ������ �ʾҴٸ� �ݺ�
	while (start < end)
	{
		mid = (start + end) / 2;
		if (b == a[mid])
		{
			// ã������ ���� �����Ѵٸ�
			cout << "1" << endl;
			return;
		}
		else
		{
			// ���۰� �Ǵ� ������ ���� ���� ���Ͽ� ��ġ�� ����
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
	// ã������ ���� �������� �ʴ´ٸ�
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

	// �������� ����
	sort(a, a + n);
	for (int i = 0; i < m; ++i)
	{
		cin >> b;
		Search(a, b, n);
	}

	return 0;
}