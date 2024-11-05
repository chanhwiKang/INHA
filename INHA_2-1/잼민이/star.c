#include <stdio.h> 

int main(){
    int sum=0;
    int loop=0;

    while(1){
        int value;
        printf("값을 입력해주세여");
        scanf("%d", &value);
        if(value < 0){
            printf("음수입니다\n 재시작");
            continue;
        }
        if (loop == 0){
            printf("몇번 반복할까요");
            scanf("%d", &loop);
        }



        
    }

    return 0;
}