#include <stdio.h>

int add(int a, int b)
{
    return a+b;
}
int main()
{
    int a=-1;

    if (a > 0){
        printf("양수");
    }else if (a < 0){
        printf("음수");
    }else {
        printf("zero");
    }

    if (a > 0){
        printf("양수");
    } if (a < 0){
        printf("음수");
    } if (a == 0) {
        printf("zero");
    }
    
    
    return 0;
}