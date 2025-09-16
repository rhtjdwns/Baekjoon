#include<iostream>
#include<string>
#include<algorithm>
#include<queue>

using namespace std;

int main()
{
	priority_queue<int> pQueue;
	queue<int> results;
	int N, M;

	cin >> N;

	for (int i = 0; i < N; ++i)
	{
		cin >> M;
		if (M == 0)
		{
			if (pQueue.size() == 0)
			{
				results.push(0);
			}
			else
			{
				results.push(pQueue.top());
				pQueue.pop();
			}
		}
		else
		{
			pQueue.push(M);
		}
	}

	int size = results.size();
	for (int i = 0; i < size; ++i)
	{
		cout << results.front() << "\n";
		results.pop();
	}
}