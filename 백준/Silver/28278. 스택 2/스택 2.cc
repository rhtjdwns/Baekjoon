#include <iostream>
#include <stack>

using namespace std;

int result[1000000];

int main()
{
	stack<int> intStack;
	int N;
	int commandNum;
	int inputNum;
	int count = 0;

	cin >> N;

	for (int i = 0; i < N; ++i)
	{
		cin >> commandNum;

		switch (commandNum)
		{
		case 1:
			cin >> inputNum;
			intStack.push(inputNum);
			break;
		case 2:
			if (intStack.empty())
			{
				result[count++] = -1;
			}
			else
			{
				result[count++] = intStack.top();
				intStack.pop();
			}
			break;
		case 3:
			result[count++] = intStack.size();
			break;
		case 4:
			result[count++] = (intStack.empty() ? 1 : 0);
			break;
		case 5:
			if (intStack.empty())
			{
				result[count++] = -1;
			}
			else
			{
				result[count++] = intStack.top();
			}
			break;
		}
	}

	for (int i = 0; i < count; ++i)
	{
		cout << result[i] << '\n';
	}

	return 0;
}