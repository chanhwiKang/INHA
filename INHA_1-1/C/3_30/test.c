#include <stdio.h>

int main(){
    int a, b;

    printf("정수 두개를 입력하세요: ");
    scanf("%d %d", &a, &b);

    if(a > b){
        printf("> \n");
    } else if(a < b){
        printf("< \n");
    } else{
        printf("== \n");
    }
    return 0;
}