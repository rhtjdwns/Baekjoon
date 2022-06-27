#include <iostream>
#include <vector>
#include <algorithm>
#include <set>
#include <math.h>

using namespace std;

typedef struct point {
	int x, y;
	bool operator<(const struct point& p) const {
		if (y == p.y) return x < p.x;
		else return y < p.y;
	}
} Point;
bool cmpX(Point left, Point right)
{
	return left.x < right.x;
}

int dist(Point start, Point end)
{
	return (start.x - end.x)*(start.x - end.x)+(start.y - end.y)*(start.y - end.y);
}

int main()
{
	int a = 0, st = 0;

	cin >> a;
	// 배열 공간 할당 (a 만큼)
	vector<Point> points(a);
	for (int i = 0; i < a; ++i)
	{
		// 각 배열마다 x, y값 넣어주기
		cin >> points[i].x >> points[i].y;
	}
	// x 값들 오름차순으로 정렬
	sort(points.begin(), points.end(), cmpX);
	// 배열의 첫번째와 두번째 주소값을 넣어줌
	set<Point> cand = { points[0], points[1] };
	// 배열의 첫번째와 두번째의 거리
	int mindist = dist(points[0], points[1]);

	// 배열의 세번째와의 거리
	for (int i = 2; i < a; ++i)
	{
		// 배열의 세번째 요소부터 쭉 넣어줌 (i)
		Point cur = points[i];
		// 초기 값 st = 0 i = 2
		while (st < i)
		{
			// 초기(0)부터 시작 하는 배열을 할당 (st)
			Point p = points[st];
			// x 값의 차 (초기값 2, 0)
			int xDif = cur.x - p.x;
			// x 값의 제곱이 최소기준값(제곱)보다 크면
			if (xDif * xDif > mindist)
			{
				// p 값(초기값 0의 주소) 삭제 및 초기값 증가 (0 -> 1)
				cand.erase(p);
				++st;
			}
			else
			{
				// 아니면 while문 벗어나기
				break;
			}
		}
		// 배열의 첫번째와 두번째 거리 
		int d = (int)sqrt((double)mindist) + 1;
		
		Point lowBound = { -100000, cur.y - d };
		Point upBound = { 100000, cur.y + d };
		
		// lowBound의 값의 이상을 탐색
		auto lower = cand.lower_bound(lowBound);
		// upBound의 값을 탐색하여 그 값의 +1 초가된값을 줌.
		auto upper = cand.upper_bound(upBound);
		// it에 lower를 대입 upper의 값이 될때까지 증가함
		for (auto it = lower; it != upper; ++it)
		{
			// cur와 it의 거리를 비교하여 그 거리가 min보다 작으면 min은 그 거리가 됨.
			int e = dist(cur, *it);
			if (e < mindist) mindist = e;
		}
		cand.insert(cur);
	}

	cout << mindist;
}