#include <stdio.h>

int main(void){
    double high = 0;
    double under = 0;

    scanf("%lf %lf", &high, &under);
    printf("삼각형의 밑변 : %.0f \n", under);
    printf("삼각형의 높이 : %.0f \n", high);
    printf("삼각형의 넓이 : %.2f \n", high * under / 2);

    return 0;
}