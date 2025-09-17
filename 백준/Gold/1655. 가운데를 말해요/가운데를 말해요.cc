#include<iostream>
#include<queue>
#include<vector>
#include<cmath>

using namespace std;

int main()
{
	priority_queue<int, vector<int>, greater<int>> minQueue;
	priority_queue<int> maxQueue;
	queue<int> results;

	int N, M;

	cin >> N;

	for (int i = 0; i < N; ++i)
	{
		cin >> M;

		if (minQueue.size() == maxQueue.size())
		{
			maxQueue.push(M);
		}
		else if (minQueue.size() + 1 == maxQueue.size())
		{
			minQueue.push(M);
		}

		if (!minQueue.empty() && maxQueue.top() > minQueue.top())
		{
			int temp = maxQueue.top();
			int temp2 = minQueue.top();
			maxQueue.pop();
			minQueue.pop();
			maxQueue.push(temp2);
			minQueue.push(temp);
		}

		results.push(maxQueue.top());
	}

	int size = results.size();
	for (int i = 0; i < size; ++i)
	{
		cout << results.front() << "\n";
		results.pop();
	}
}