#include <iostream>
#include <vector>
#include <queue>

using namespace std;

#define MAX 100001

int ans[MAX];
bool visit[MAX];
vector<int> graph[MAX];

void bfs()
{
    queue<int> q;
    visit[1] = true;
    q.push(1);

    while (!q.empty())
    {
        int parent = q.front();
        q.pop();

        for (int i = 0; i < graph[parent].size(); ++i)
        {
            int child = graph[parent][i];
            if (!visit[child])
            {
                ans[child] = parent;
                visit[child] = true;
                q.push(child);
            }
        }
    }
    
}

int main()
{
    int N;
    cin >> N;

    for (int i = 0; i < N; ++i)
    {
        int u, v;
        cin >> u >> v;
        graph[u].push_back(v);
        graph[v].push_back(u);
    }

    bfs();

    for (int i = 2; i <= N; ++i)
    {
        cout << ans[i] << "\n";
    }

    return 0;
}