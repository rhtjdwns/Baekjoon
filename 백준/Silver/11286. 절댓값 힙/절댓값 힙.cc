#include<iostream>
#include<queue>
#include<cmath>

using namespace std;

struct Circul
{
	bool operator()(int a, int b)
	{
		if (abs(a) == abs(b))
			return a > b;
		else
			return abs(a) > abs(b);
	}
};

int main()
{
	priority_queue<int, vector<int>, Circul> pQueue;
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