#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

#define MAX 20

int main()
{
	string name;
	double score[MAX];
	string grade[51];

	int scoreSum = 0;
	double majorScore = 0;

	for (int i = 0; i < MAX; ++i)
	{
		name = "";
		cin >> name >> score[i] >> grade[i];

		if (grade[i] == "P")
		{
			continue;
		}

		scoreSum += score[i];

		if (grade[i] == "A+")
		{
			majorScore += score[i] * 4.5;
		}
		else if (grade[i] == "A0")
		{
			majorScore += score[i] * 4;
		}
		else if (grade[i] == "B+")
		{
			majorScore += score[i] * 3.5;
		}
		else if (grade[i] == "B0")
		{
			majorScore += score[i] * 3;
		}
		else if (grade[i] == "C+")
		{
			majorScore += score[i] * 2.5;
		}
		else if (grade[i] == "C0")
		{
			majorScore += score[i] * 2;
		}
		else if (grade[i] == "D+")
		{
			majorScore += score[i] * 1.5;
		}
		else if (grade[i] == "D0")
		{
			majorScore += score[i] * 1;
		}
		else if (grade[i] == "F")
		{
			majorScore += score[i] * 0;
		}
	}

	cout << majorScore / scoreSum;

	return 0;
}