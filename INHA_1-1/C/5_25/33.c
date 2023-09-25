#include <stdio.h> 

int main(){

    int x=10;
    int *p;

    p = &x;
    printf("p = %d\n", x);

    *p = 20;
    printf("p = %d\n", x);
    return 0;
}