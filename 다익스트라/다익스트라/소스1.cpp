//#include <iostream>
//#include <queue>
//#include <vector>
//
//using namespace std;
//
//#define INF 999999999
//int main()
//{
//	int v, e, start;
//
//	cin >> v >> e;
//	cin >> start;
//
//	vector<pair<int, int>> vec[20001];
//
//	for (int i = 0; i < e; i++)
//	{
//		int a, b, c;
//		cin >> a >> b >> c;
//		pair<int, int> temp = make_pair(b, c);
//		vec[a].push_back(temp);
//	}
//	
//	vector<int> temp(v + 1, INF);
//	priority_queue<pair<int, int>> qu;
//	qu.push(make_pair(0, start));
//	temp[start] = 0;
//
//	while (!qu.empty())
//	{
//		pair<int, int> st = qu.top();
//		int curDir = st.first;
//		int curInx = st.second;
//		qu.pop();
//
//		if (curDir > temp[curInx])
//			continue;
//
//		for (int i = 0; i < vec[curInx].size(); ++i)
//		{
//			int nextDir = vec[curInx][i].first;
//			int nextInx = vec[curInx][i].second;
//			if (curDir + nextDir < temp[nextDir])
//		}
//	}
//
//	return 0;
//}