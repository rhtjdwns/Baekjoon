#include <iostream>
#include <queue>

using namespace std;

int main()
{
	queue<int> intQueue;
	int N;

	cin >> N;

	for (int i = 1; i <= N; ++i)
	{
		intQueue.push(i);
	}

	while (intQueue.size() != 1)
	{
		intQueue.pop();

		if (intQueue.size() == 1)
		{
			break;
		}

		intQueue.push(intQueue.front());
		intQueue.pop();
	}

	cout << intQueue.front();
}