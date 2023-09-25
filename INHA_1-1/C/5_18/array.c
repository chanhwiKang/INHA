#include <stdio.h> 
#include <stdlib.h>
#include <time.h>

int main(){

    int arr[5];

    srand((unsigned)time(NULL));
    for(int i=0;i<5;i++){
        arr[i] = rand() % 100;
    }

    for(int i=0;i<5;i++){
        printf("scores[%d]=%d\n", i, arr[i]);
    }

    return 0;
}