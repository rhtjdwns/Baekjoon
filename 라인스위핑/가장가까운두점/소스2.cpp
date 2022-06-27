//#include <iostream>
//#include <algorithm>
//#include <cmath>
//#include <map>
//#include <vector>
//#include <limits.h>
//using namespace std;
//#define INF INT_MAX
//typedef long long ll;
//// �������� �䱸�ϴ� �Ÿ��� �Ÿ��� �����̱� ������ sqrt�� ������� �ʾҽ��ϴ�.
//ll getDist(pair<int, int> a, pair<int, int> b)
//{
//	int x1 = a.first;
//	int y1 = a.second;
//	int x2 = b.first;
//	int y2 = b.second;
//	return (x2 - x1) * (ll)(x2 - x1) + (y2 - y1) * (ll)(y2 - y1);
//}
//vector<pair<int, int>> vec;
//map<pair<int, int>, int> m;
//int main()
//{
//	ios::sync_with_stdio(false); cin.tie(0); cout.tie(0);
//	int n; cin >> n;
//	for (int i = 0; i < n; i++)
//	{
//		int x, y;
//		cin >> x >> y;
//		vec.push_back({ x,y });
//	}
//	// x�� ������ �ϴ� ���� ?
//	// x�� ������ ���� x������ ���̸����� �ִ밪 �ĺ����� ���� ������ ���� ��ų �� �ִ�.
//	sort(vec.begin(), vec.end());
//	// {y,x}���� insert�� ����?
//	// dx�� ���� if������ x����� �Ÿ��� ó�� �Ͽ���,
//	// map�� �����մ� �����߿��� y������ lower_bound, upper_bound�� �ϱ� �����̴�.
//	// = 0 ���� ����?
//	// � ���̵� ũ�� ��������� , INF���� �۰�, -INF���� Ŀ���Ѵ�.( lower_bound, upper_bound�� ���� )
//	m[{vec[0].second, vec[0].first}] = 0;
//	m[{vec[1].second, vec[1].first}] = 0;
//	ll ans = getDist(vec[0], vec[1]);
//	// pos = 0 ����, i = 2 ������ ����?
//	// ���ǻ� ù��°���� �ι�°���� (x�� ���� ���� ) �� �������� ��Ҵ�.
//	// ���� �ڵ��� for���� �����´�� ������ ��Ҵٰ� ���� �ȴ�.
//	/*
//	for(int i = 0 ; i < 2; i ++){
//	...
//	}
//	*/
//	int pos = 0;
//	for (int i = 2; i < n; i++) {
//		// pos���� i-1������ i��°���� �񱳸� �Ѵ�.
//		while (pos < i) {
//			// x�ణ�� �Ÿ� ����
//			int dx = vec[i].first - vec[pos].first;
//			// pos( i �� �������� ���� map �ִ� ���� ���� �� ) �� i��° ������ x�� �Ÿ���
//			// �� �۴ٸ� pos���� ������ �ĺ��� ���Ե� �� �ִ�.
//			if (dx * dx <= ans) break;
//			// pos(i �� �������� ���� map �ִ� ���� ���� ��) �� i��° ������ x�� �Ÿ���
//			// �� ũ�ٸ� pos���� ���̻� �� ���� ans���� ������ ���Ѵ�.( �ĺ����� ���ܵȴ� )
//			m.erase({ vec[pos].second,vec[pos].first });
//			pos++;
//		}
//		// getDist �� sqrt�� ���� ��ȯ��������...
//		ll dis = sqrt(ans);
//		// map�� �����ִ� �����߿���
//		// ���� ans���� �۾� �� �� �ִ� �ĺ� ������ Ȯ�� �ϱ����� left, right�� ã��
//		auto left = m.lower_bound({ vec[i].second - dis, -INF });
//		auto right = m.upper_bound({ vec[i].second + dis, INF });
//		// ans ����
//		for (auto l = left; l != right; l++) {
//			ans = min(ans, getDist({ l->first.second,l->first.first }, vec[i]));
//		}
//		// i��°���� �翬�� �ڿ� Ȯ���Ұ� �������� �ĺ� ���� �ȴ�.
//		m[{vec[i].second, vec[i].first}] = 0;
//	}
//	cout << ans << "\n";
//	return 0;
//}
