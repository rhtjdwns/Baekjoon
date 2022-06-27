#include <iostream>
#include <vector>
#include <queue>

#define INF 999999999
using namespace std;

int main()
{
	int v, e, start;
	int x, y, z;

	cin >> v >> e >> start;

	vector<pair<int, int>> vec[20001];
	vector<int> vect(v + 1, INF);
	priority_queue<pair<int, int>> qu;

	for (int i = 0; i < e; ++i)
	{
		cin >> x >> y >> z;
		vec[x].push_back(make_pair(y, z));
	}

	qu.push(make_pair(0, start));
	vect[start] = 0;

	while (!qu.empty())
	{
		pair<int, int> current = qu.top();
		// 현재 거리
		int curDi = -current.first;
		// 현재 순서
		int curIn = current.second;
		qu.pop();

		if (curDi > vect[curIn])
			continue;

		for (int i = 0; i < vec[curIn].size(); ++i)
		{
			// 다음 거리
			int nextDi = vec[curIn][i].second;
			// 다음 순서
			int nextIn = vec[curIn][i].first;
			if (nextDi + curDi < vect[nextIn])
			{
				vect[nextIn] = nextDi + curDi;
				qu.push(make_pair(-vect[nextIn], nextIn));
			}
		}
	}
	for (int i = 1; i < v + 1; ++i)
	{
		if (vect[i] == INF)
			cout << "INF" << "\n";
		else
			cout << vect[i] << "\n";
	}

	return 0;
}