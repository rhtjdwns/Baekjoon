#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	int N, first, last, result = 1;
	vector<pair<int, int>> timeVec;

	cin >> N;

	for (int i = 0; i < N; ++i)
	{
		cin >> first >> last;
		timeVec.push_back({last, first});
	}

	sort(timeVec.begin(), timeVec.end());

	int count = 0;

	for (int i = 1; i < N; ++i)
	{
		if (timeVec[count].first <= timeVec[i].second)
		{
			count = i;
			result++;
		}
	}

	std::cout << result;

	return 0;
}