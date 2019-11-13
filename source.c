#include<stdio.h>

int main(void)
{
	int Count = 0;
	int A, B = 0;
	int i = 0;

	scanf_s("%d", &Count);

	for (i = 0; i < Count; i++)
	{
		scanf_s("%d %d", &A, &B);
		printf("%d \n", A + B);
	}
}