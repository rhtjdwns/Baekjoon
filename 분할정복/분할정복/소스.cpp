#include <iostream>
using namespace std;

int max(int arr[], int low, int high);

int main()
{
	int arr[] = { 6, 2, 9, 8, 1, 4, 17, 5 }; 
	max(arr, 0, 7);
}

int max(int arr[], int low, int high) 
{ 
	int m, left, right; m = (low + high) / 2; 
	if (low == high) return arr[low]; left = max(arr, low, m); 
	right = max(arr, m + 1, high); 
	return (left > right) ? left : right; 
}

