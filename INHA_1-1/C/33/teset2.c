#include <stdio.h>

int main(){
    int a, b;
    int result;

    printf("3자리 수 두개를 입력: ");
    scanf("%d %d", &a, &b);

    result=b%10;
    printf("%d\n", a*result);
    result=b/10%10;
    printf("%d\n", a*result);
    result=b/100;
    printf("%d\n", a*result);
    printf("%d\n", a*b);

  
    return 0;
}
