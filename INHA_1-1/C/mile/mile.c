#include <stdio.h>

int main(void){
    double mile = 0;

    printf("마일을 입력하세요 : \n");
    scanf("%lf", &mile);

    printf("%0.1lf 마일은 %0.2lf 미터입니다 \n", mile, 1609 * mile);

    return 0;
}