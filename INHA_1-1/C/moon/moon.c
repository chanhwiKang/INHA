#include <stdio.h>

int main(void){
    double weight = 0;

    printf("몸무게를 입력하세요: \n");
    scanf("%lf", &weight);

    printf("딜에서의 몸무기는 %.2lf입니다. \n", weight * 0.17);
    return 0;
}