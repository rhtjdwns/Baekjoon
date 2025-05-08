#include <iostream>
#include <stack>

using namespace std;

int main()
{
	string vps;
	int T;

	int count = 0;
	string result[100];

	cin >> T;

	for (int i = 0; i < T; ++i)
	{
		stack<char> st;

		cin >> vps;

		for (int j = 0; j < vps.size(); ++j)
		{
			if (st.empty())
			{
				st.push(vps[j]);
			}
			else
			{
				if (st.top() == '(' && vps[j] == ')')
				{
					st.pop();
				}
				else
				{
					st.push(vps[j]);
				}
			}
		}

		if (st.empty())
		{
			result[count++] = "YES";
		}
		else
		{
			result[count++] = "NO";
		}

	}

	for (int i = 0; i < count; ++i)
	{
		cout << result[i] << '\n';
	}

	return 0;
}