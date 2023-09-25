#include <stdlib.h>
#include <stdio.h>
#include <time.h>

#define MAX 45
int main(){

    srand((unsigned)time(NULL));
    for(int i=0; i<6; i++){
        printf("%d ", 1+rand()%MAX);
    }
    printf("\n");
    return 0;
    // slide 60 ~ 89 코드 짜서 깃허브 업로드. 주석 다 달기 엄청 구체적으로. 다음주 수까지
}