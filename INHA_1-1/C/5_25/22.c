#include <stdio.h> 


int main(){
    int i = 3000;
    int *p=NULL;

    p = &i;

    printf("p = %p\n", p);
    printf("&i = %p\n", &i);
    printf("i = %d\n", i);
    printf("*p = %d\n", *p);

    *p=2000;
    printf("%d %d\n", i, *p);
    return 0;
}