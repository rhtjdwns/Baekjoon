#include<iostream>
#include<queue>
#include<string>
#include<map>

using namespace std;

int main()
{
	priority_queue<int, vector<int>, greater<int>> minQueue;
	priority_queue<int> maxQueue;
	map<int, int> intMap;
	queue<string> results;

	int T, k, n;
	char l;

	cin >> T;

	for (int i = 0; i < T; ++i)
	{
		intMap.clear();
		while (!minQueue.empty())
		{
			minQueue.pop();
		}
		while (!maxQueue.empty())
		{
			maxQueue.pop();
		}

		cin >> k;

		for (int j = 0; j < k; ++j)
		{
			cin >> l >> n;

			if (l == 'I')
			{
				minQueue.push(n);
				maxQueue.push(n);
				if (intMap.count(n) == 0)
				{
					intMap[n] = 1;
				}
				else
				{
					intMap[n]++;
				}
			}
			else
			{
				if (n == 1)
				{
					while (!maxQueue.empty() && intMap[maxQueue.top()] == 0)
					{
						maxQueue.pop();
					}
					if (maxQueue.empty()) continue;

					intMap[maxQueue.top()]--;
					maxQueue.pop();
				}
				else if (n == -1)
				{
					while (!minQueue.empty() && intMap[minQueue.top()] == 0)
					{
						minQueue.pop();
					}
					if (minQueue.empty()) continue;

					intMap[minQueue.top()]--;
					minQueue.pop();
				}
			}
		}

		while (!maxQueue.empty() && intMap[maxQueue.top()] == 0)
		{
			maxQueue.pop();
		}
		while (!minQueue.empty() && intMap[minQueue.top()] == 0)
		{
			minQueue.pop();
		}

		if (maxQueue.empty())
		{
			results.push("EMPTY");
		}
		else
		{
			int max = NULL, min = NULL;
			max = maxQueue.top();
			min = minQueue.top();

			string result = to_string(max) + " " + to_string(min);
			results.push(result);
		}
	}

	int size = results.size();
	for (int i = 0; i < size; ++i)
	{
		string st = results.front();
		results.pop();
		cout << st << "\n";
	}

	return 0;
}