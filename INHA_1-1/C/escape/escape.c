#include <stdio.h>

int main(void){
    int id, pass;

    printf("아이디와 패스워드 4개의 숫자로 입력: \n");
    printf("id: ____\b\b\b\b");
    scanf("%d", &id);

    printf("pass: ____\b\b\b\b");
    scanf("%d", &pass);

    printf("id: \"%d\" \npass: \"%d\" \n", id, pass);

    return 0;
}