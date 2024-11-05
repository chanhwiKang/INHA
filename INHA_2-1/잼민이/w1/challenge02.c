#include <stdio.h> 

int main(){
    float su;
    
    printf("소수 6까지 실수 입력\n");
    scanf("%f", &su);

    printf("소수 둘째 자리까지 출력: %.2f\n", su);
    printf("소수 둘째 자리까지 출력: %06.1f\n", su);
    return 0;
}