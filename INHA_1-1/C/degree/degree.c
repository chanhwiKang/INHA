#include <stdio.h>

int main(void){
    double f = 0;
    double c = 0;

    printf("화씨값을 입력하시오: \n");
    scanf("%lf", &f);

    c = (f - 32) * 5 / 9;
    printf("섭씨값은 %.2lf 입니다 \n", c);

}