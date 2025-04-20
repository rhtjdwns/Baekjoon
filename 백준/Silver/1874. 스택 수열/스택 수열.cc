#include <iostream>
#include <stack>
#include <vector>

using namespace std;

// "반드시 오름차순을 지키도록 한다"조건때문에 count가 입력받은 수보다 크다는 것은 해당수열을 만들수 없다는 것을 의미.
int main()
{
	int n, m, count = 1;
	stack<int> intStack;
	vector<char> resultVec;

	cin >> n;

	for (int i = 0; i < n; ++i)
	{
		cin >> m;

		if (!intStack.empty() && intStack.top() == m)
		{
			resultVec.push_back('-');
			intStack.pop();
		}
		else if (count <= m)
		{
			while (count <= m)
			{
				resultVec.push_back('+');
				intStack.push(count++);
			}

			resultVec.push_back('-');
			intStack.pop();
		}
		else if (!intStack.empty() && intStack.top() > m)
		{
			cout << "NO";
			return 0;
		}
	}

	for (int i = 0; i < resultVec.size(); ++i)
	{
		cout << resultVec[i] << '\n';
	}

	return 0;
}