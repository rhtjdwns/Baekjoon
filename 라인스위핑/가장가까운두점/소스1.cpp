//#define _CRT_SECURE_NO_WARNINGS
//#include<cstdio>
//#include<vector>
//#include<algorithm>
//#include<set>
//#include<cmath>
//#include<stdio.h>
//using namespace std;
//
//typedef struct point {
//	int x, y;
//	bool operator<(const struct point& p) const {
//		if (y == p.y) return x < p.x;
//		else return y < p.y;
//	}
//} POINT;
//
//bool comp(POINT a, POINT b) {
//	return a.x < b.x;
//}
//
//int dist(POINT a, POINT b) {
//	return (a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y);
//}
//
//int main()
//{
//	int n;
//	scanf("%d", &n);
//
//	vector<POINT> v(n);
//	for (int i = 0; i < n; i++) {
//		int x, y;
//		scanf("%d %d", &v[i].x, &v[i].y);
//	}
//	sort(v.begin(), v.end(), comp);
//
//	set<POINT> cand = { v[0], v[1] };
//	int mdist = dist(v[0], v[1]);
//	int st = 0;
//	for (int i = 2; i < n; i++) {
//		POINT cur = v[i];
//		while (st < i) {
//			POINT p = v[st];
//			int xDif = cur.x - p.x;
//			if (xDif * xDif > mdist) {
//				cand.erase(p);
//				st++;
//			}
//			else {
//				break;
//			}
//		}
//		int d = (int)sqrt((double)mdist) + 1;
//
//		POINT lowBound = { -100000, cur.y - d };
//		POINT upBound = { 100000, cur.y + d };
//
//		auto lower = cand.lower_bound(lowBound);
//		auto upper = cand.upper_bound(upBound);
//		for (auto it = lower; it != upper; it++) {
//			int d = dist(cur, *it);
//			if (d < mdist) mdist = d;
//		}
//		cand.insert(cur);
//	};
//
//	printf("%d", mdist);
//}
