#include <stdio.h>

int main(){
    char c;
    int i;
    float f;

    c = 10000; //내림 변환
    i = 1.23456 + 10; //내림 변환
    f = 10 + 20; //올림 변환
    printf("c = %d, i = %d, f = %f\n", c, i, f); //c = 16, i = 11, f = 30.000000

    return 0;
}