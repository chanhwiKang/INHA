#include <stdio.h>

int main(void){
    double x = 0;

    printf("실수를 입력하시오: \n");
    scanf("%lf", &x);

    x = (3 * x * x) + (7 * x) + 11;
    printf("다항식의 값은 %.2lf\n", x);
}