#include <stdio.h> 
int max(int x, int y);


int main(){

    int a, b;
    printf("정수 2개를 입력하시오 : \n");
    scanf("%d %d", &a, &b);

    printf("더 큰 값은 %d입니다.\n", max(a,b));
    return 0;
}

int max(int x, int y){
    return x > y ? x : y ;
}
