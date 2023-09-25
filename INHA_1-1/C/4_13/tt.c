#include <stdio.h> 

int main(){

    int x;
    int result = 0;
    
    scanf("%d", &x);

    for(int i=0; i<x; i++){
        if(i%2==0){
            result += i;
        }
    }

    printf("%d\n", result);
    return 0;
}