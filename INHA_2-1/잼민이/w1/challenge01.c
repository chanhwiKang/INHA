#include <stdio.h> 

int main(){

    char id[8];
    char pw[10];

    printf("id(최대 8자리) : ________\b\b\b\b\b\b\b\b");
    scanf("%s", id);

    printf("pw(최대 10자리) : __________\b\b\b\b\b\b\b\b\b\b");
    scanf("%s", pw);
    return 0;
}