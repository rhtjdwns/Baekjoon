#pragma once
#include "queue.h"
#include "stack.h"

class BFS
{
	stack<int> m_stack;
	queue m_queue;

	int sNode;
	int tNode;
public:
	BFS(int sn, int tn) : sNode(sn), tNode(tn) { }
	~BFS() { }
	bool pathFinding();
	void draw();
};

