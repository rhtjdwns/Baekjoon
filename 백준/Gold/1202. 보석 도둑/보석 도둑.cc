#include <iostream>
#include <vector>
#include <queue>
#include <algorithm>

using namespace std;

int bagArr[300000];

int main()
{
	int N, K;
	int weight, price;
	long long result = 0;
	vector<pair<int, int>> jewelVec;
	priority_queue<int> pq;

	cin >> N >> K;

	for (int i = 0; i < N; ++i)
	{
		cin >> weight >> price;
		jewelVec.push_back(make_pair(weight, price));
	}

	for (int i = 0; i < K; ++i)
	{
		cin >> bagArr[i];
	}

	sort(jewelVec.begin(), jewelVec.end());
	sort(bagArr, bagArr + K);

	int j = 0;
	for (int i = 0; i < K; ++i)
	{
		while (j < N && bagArr[i] >= jewelVec[j].first)
		{
			pq.push(jewelVec[j].second);
			j++;
		}

		if (!pq.empty())
		{
			result += pq.top();
			pq.pop();
		}
	}

	std::cout << result << '\n';

	return 0;
}