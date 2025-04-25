#include <iostream>
#include <stack>

using namespace std;

int main()
{
	stack<int> intStack;
	int K;
	int command;
	int result = 0;

	cin >> K;
	for (int i = 0; i < K; ++i)
	{
		cin >> command;
		command == 0 ? intStack.pop() : intStack.push(command);
	}

	command = intStack.size();
	for (int i = 0; i < command; ++i)
	{
		result += intStack.top();
		intStack.pop();
	}

	cout << result << '\n';

	return 0;
}