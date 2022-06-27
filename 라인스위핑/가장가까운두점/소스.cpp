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
	// �迭 ���� �Ҵ� (a ��ŭ)
	vector<Point> points(a);
	for (int i = 0; i < a; ++i)
	{
		// �� �迭���� x, y�� �־��ֱ�
		cin >> points[i].x >> points[i].y;
	}
	// x ���� ������������ ����
	sort(points.begin(), points.end(), cmpX);
	// �迭�� ù��°�� �ι�° �ּҰ��� �־���
	set<Point> cand = { points[0], points[1] };
	// �迭�� ù��°�� �ι�°�� �Ÿ�
	int mindist = dist(points[0], points[1]);

	// �迭�� ����°���� �Ÿ�
	for (int i = 2; i < a; ++i)
	{
		// �迭�� ����° ��Һ��� �� �־��� (i)
		Point cur = points[i];
		// �ʱ� �� st = 0 i = 2
		while (st < i)
		{
			// �ʱ�(0)���� ���� �ϴ� �迭�� �Ҵ� (st)
			Point p = points[st];
			// x ���� �� (�ʱⰪ 2, 0)
			int xDif = cur.x - p.x;
			// x ���� ������ �ּұ��ذ�(����)���� ũ��
			if (xDif * xDif > mindist)
			{
				// p ��(�ʱⰪ 0�� �ּ�) ���� �� �ʱⰪ ���� (0 -> 1)
				cand.erase(p);
				++st;
			}
			else
			{
				// �ƴϸ� while�� �����
				break;
			}
		}
		// �迭�� ù��°�� �ι�° �Ÿ� 
		int d = (int)sqrt((double)mindist) + 1;
		
		Point lowBound = { -100000, cur.y - d };
		Point upBound = { 100000, cur.y + d };
		
		// lowBound�� ���� �̻��� Ž��
		auto lower = cand.lower_bound(lowBound);
		// upBound�� ���� Ž���Ͽ� �� ���� +1 �ʰ��Ȱ��� ��.
		auto upper = cand.upper_bound(upBound);
		// it�� lower�� ���� upper�� ���� �ɶ����� ������
		for (auto it = lower; it != upper; ++it)
		{
			// cur�� it�� �Ÿ��� ���Ͽ� �� �Ÿ��� min���� ������ min�� �� �Ÿ��� ��.
			int e = dist(cur, *it);
			if (e < mindist) mindist = e;
		}
		cand.insert(cur);
	}

	cout << mindist;
}