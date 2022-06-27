#include "BFS.h"
#include <memory>
#include <iostream>
using namespace std;

const int MAXNODE = 9;
int city[MAXNODE][MAXNODE] = {
	//	 a	b  c  d  e  f  g  h  i
		{0, 1, 0, 0, 0, 0, 1, 0, 0}, // a
		{0, 0, 1, 0, 1, 0, 0, 0, 0}, // b
		{0, 0, 0, 1, 0, 0, 0, 0, 0}, // c
		{0, 1, 0, 0, 0, 0, 0, 0, 0}, // d
		{0, 0, 0, 0, 0, 1, 1, 0, 0}, // e
		{0, 0, 0, 0, 0, 0, 0, 0, 0}, // f
		{0, 0, 0, 0, 0, 0, 0, 1, 0}, // g
		{0, 0, 0, 0, 0, 0, 0, 0, 0}, // h
		{0, 0, 0, 0, 0, 0, 0, 1, 0}  // i
};

enum { UNVISIT, VISIT };
char cityName[9] = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };

bool BFS::pathFinding()
{
	bool visitinfo[MAXNODE];
	int parent[MAXNODE];
	bool bFound = false;

	memset(visitinfo, UNVISIT, sizeof(visitinfo));
	memset(parent, -1, sizeof(parent));

	m_queue.enQueue(sNode);
	visitinfo[sNode] = true;
	parent[sNode] = sNode;

	while (!m_queue.isEmpty())
	{
		int front = m_queue.getFront();
		m_queue.deQueue();
		if (front == tNode)
		{
			bFound = true;
			break;
		}
		for (int i = 0; i < MAXNODE; ++i)
		{
			// front 노드와 인접해 있고 아직 방문하지 않은 노드이면
			if (city[front][i] && visitinfo[i] == UNVISIT) 
			{
				m_queue.enQueue(i);
				visitinfo[i] = VISIT;
				parent[i] = front;
			}
		}
	}
	if (bFound)
	{
		int curNode = tNode;
		m_stack.push(curNode);
		do
		{
			curNode = parent[curNode];
			m_stack.push(curNode);
		} while (curNode != sNode);
	}

	return bFound;
}

void BFS::draw()
{
	while (!m_stack.isEmpty())
	{
		cout << cityName[m_stack.pop()] << "->";
	}
	cout << endl;
}
