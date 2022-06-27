//#include <iostream>
//
//using namespace std;
//
//int main()
//{
//	int textCase = 1;
//	string numCase1;
//	string numCase2;
//	int count = 0;
//	int oneCount = 0;
//	int oneCount2 = 0;
//	int* temp;
//
//	cin >> textCase;
//	if (textCase < 1 || textCase > 50)
//		return 0;
//	temp = new int[textCase];
//
//	for (int i = 0; i < textCase; ++i)
//	{
//		cin >> numCase1 >> numCase2;
//
//		for (int j = 0; j < numCase1.length(); ++j)
//		{
//			if (numCase1[j] != numCase2[j])
//				count++;
//
//			if (numCase1[j] == '1')
//				oneCount++;
//			if (numCase2[j] == '1')
//				oneCount2++;
//		}
//		temp[i] = oneCount - oneCount2;
//
//		if (temp[i] < 0)
//			temp[i] = -temp[i];
//
//		temp[i] = (count + temp[i]) / 2;
//
//		oneCount = 0, oneCount2 = 0;
//		count = 0;
//	}
//
//	for (int i = 0; i < textCase; ++i)
//	{
//		cout << temp[i] << endl;
//	}
//}
