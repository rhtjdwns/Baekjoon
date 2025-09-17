#include<iostream>
#include<queue>
#include<cmath>

using namespace std;

int main()
{
	priority_queue<int, vector<int>, greater<int>> pQueue;
	int results = 0;
	int N, M;

	cin >> N;

	for (int i = 0; i < N; ++i)
	{
		cin >> M;
		pQueue.push(M);
	}

	while (pQueue.size() > 1)
	{
		int oCard, tCard, temp;
		oCard = pQueue.top();
		pQueue.pop();
		tCard = pQueue.top();
		pQueue.pop();

		temp = oCard + tCard;
		results += temp;
		pQueue.push(temp);
	}

	cout << results;
}