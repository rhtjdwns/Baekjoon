#include <iostream>
#include <algorithm>
#include <map>

using namespace std;

map<string, int> stringMap;
string hearNames;
string seeNames[500000];
string result[500000];

int main()
{
	int N, M;
	int count = 0;

	cin >> N >> M;
	for (int i = 0; i < N; ++i)
	{
		cin >> hearNames;
		stringMap.insert({ hearNames, i });
	}

	for (int i = 0; i < M; ++i)
	{
		cin >> seeNames[i];
		if (stringMap.find(seeNames[i]) != stringMap.end())
		{
			result[count++] = seeNames[i];
		}
	}
	
	cout << count << '\n';
	sort(result, result + count);
	for (int i = 0; i < count; ++i)
	{
		cout << result[i] << '\n';
	}
}