#include <stdio.h> 

int main(){

    int a=1, x=0;

    scanf("%d", &x);

    while (1){
        printf("%d * %d = %d\n", x, a, x*a);
        a++;
        if(a>9){
            break;
        }
    }
    
    return 0;
}