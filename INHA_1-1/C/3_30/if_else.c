#include <stdio.h>

int main(){
    int num=0;

    printf("정수를 입력하시오: ");
    scanf("%d", &num);

    if(num % 2 == 0){
        printf("입력된 정수는 짝수입니다.\n");
    } else{
        printf("입력된 정수는 홀수입니다.\n");
    }

    return 0;
}