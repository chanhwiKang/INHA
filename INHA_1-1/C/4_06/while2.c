#include <stdio.h> 

int main(){

    int count=1, num=0, sum=0;
    
    printf("정수를 입력하시오: \n");
    scanf("%d", &num);
    
    while(count<=num){
        
        if(count%2==0){
            sum+=count;
        }
        count++;
    }
    printf("1부터 %d까지의 합은 %d입니다.\n", num, sum);
    return 0;
}