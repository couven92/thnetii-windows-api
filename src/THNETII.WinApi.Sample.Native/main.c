#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <LM.h>
#include <LMat.h>

void main()
{
	const int size = sizeof(NET_COMPUTER_NAME_TYPE);
	const int value = MAX_PATH;

	void* ptr = NetGetDCName;
}
