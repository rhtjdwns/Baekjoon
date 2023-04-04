#include <iostream>

using namespace std;

int main()
{
	string st;
	char word[16][5];
	int longLength = 0;
	int interval[5];

	for (int i = 0; i < 5; ++i)
	{
		// 글자 입력
		cin >> st;
		if (longLength < st.length())
			longLength = st.length();
		for (int j = 0; j < st.length(); ++j)
		{
			word[j][i] = st[j];
		}

		// 각 글자 수를 대입
		interval[i] = st.length();
	}

	// 가장 긴 글자보다 길이가 짧다면 나머지 빈 공간에 \n을 대입
	for (int i = 0; i < 5; ++i)
	{
		for (int j = interval[i]; j < longLength; ++j)
		{
			word[j][i] = '\n';
		}
	}

	// 세로로 출력
	for (int i = 0; i < longLength; ++i)
	{
		for (int j = 0; j < 5; ++j)
		{
			if (word[i][j] == '\n')
				continue;

			cout << word[i][j];
		}
	}
}