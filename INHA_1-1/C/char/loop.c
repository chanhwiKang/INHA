#include <stdio.h> 

int main(){
    int sum = 0;
    for(int count = 1; count <= 100; count++ ){
        sum += count;
    }
    printf("%d\n", sum);
    
    return 0;
}