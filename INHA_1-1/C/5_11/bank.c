#include <stdio.h> 

int main(){
    while(1){
        char select;
        printf("입금하려면 I, 출금하려면 O, 프로그램 종료 E 입력하세요.: ");
        scanf("%c", &select);
        if(select=='E'){ break; }
        else if(select=='I'){
            //input
        }else if(select=='O'){
            //output
        }else {
            //Error code
        }
    }

    return 0;
}