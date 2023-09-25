#include <stdio.h> 

int main(){

    int i=0, a=0, result=0;
    
    printf("값을 입력하시오: \n");
    while(i<=4){
        scanf("%d", &a);
        result+=a;
        i++;
    }
    printf("합계는 %d입니다. \n", result);
    return 0;
}   