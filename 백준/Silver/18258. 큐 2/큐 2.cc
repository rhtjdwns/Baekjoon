#include <iostream>
#include <queue>

using namespace std;

int result[2000000];

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);

	int N;
	int count = 0;
	queue<int> intQueue;
	string command;

	cin >> N;
	for (int i = 0; i < N; ++i)
	{
		cin >> command;
		if (command == "push")
		{
			int input;
			cin >> input;
			intQueue.push(input);
		}
		else if (command == "pop")
		{
			if (intQueue.empty())
			{
				result[count++] = -1;
			}
			else
			{
				result[count++] = intQueue.front();
				intQueue.pop();
			}
		}
		else if (command == "size")
		{
			result[count++] = intQueue.size();
		}
		else if (command == "empty")
		{
			if (intQueue.empty())
			{
				result[count++] = 1;
			}
			else
			{
				result[count++] = 0;
			}
		}
		else if (command == "front")
		{
			if (intQueue.empty())
			{
				result[count++] = -1;
			}
			else
			{
				result[count++] = intQueue.front();
			}
		}
		else if (command == "back")
		{
			if (intQueue.empty())
			{
				result[count++] = -1;
			}
			else
			{
				result[count++] = intQueue.back();
			}
		}
	}

	for (int i = 0; i < count; ++i)
	{
		cout << result[i] << '\n';
	}
}