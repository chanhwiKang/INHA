#include <stdio.h>

int main(void)
{
    double money = 0;

    printf("연봉을 입력해(단위 : 만원)) \n");
    scanf("%lf", &money);
    
    money = 100000 / money;

    printf("10억을 모으는데 걸리는 시간 (단위 : %0.2lf년)) \n", money);
    
    return 0;
}