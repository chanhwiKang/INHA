#include <stdio.h> 

int main(){

    int i=1, a=0, b=0;
    int n=0;

    scanf("%d", &n);

    while(i<=n){
        scanf("%d %d", &a, &b);
        printf("%d\n", a+b);
        i++;
    }
    
    return 0;
}   