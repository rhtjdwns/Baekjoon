#include <iostream>
#include <vector>

using namespace std;

struct node
{
    char left;
    char right;
};

vector<node> nodes(26);

void PreOrder(char node)
{
    if (node == '.')
    {
        return;
    }

    cout << node;
    PreOrder(nodes[node - 'A'].left);
    PreOrder(nodes[node - 'A'].right);
}

void MiddleOrder(char node)
{
    if (node == '.')
    {
        return;
    }

    MiddleOrder(nodes[node - 'A'].left);
    cout << node;
    MiddleOrder(nodes[node - 'A'].right);
}

void PostOrder(char node)
{
    if (node == '.')
    {
        return;
    }

    PostOrder(nodes[node - 'A'].left);
    PostOrder(nodes[node - 'A'].right);
    cout << node;
}

int main()
{
    int n;
    char l, r, st;

    cin >> n;

    for (int i = 0; i < n; ++i)
    {
        cin >> st >> l >> r;
        nodes[st - 'A'].left = l;
        nodes[st - 'A'].right = r;
    }

    PreOrder('A');
    cout << '\n';
    MiddleOrder('A');
    cout << '\n';
    PostOrder('A');
    
    return 0;
}