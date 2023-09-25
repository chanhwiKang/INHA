#include <stdio.h> 

int main(){

    int count=1,number,clone=0;
    scanf("%d", &number);
    clone=number;
    while (count<=number)
    {
        printf("%d\n",clone); //1
        clone=clone-1; //0
        count++; //4

        printf("<count=%d clone=%d>\n", count, clone);
    }
    

    return 0;
}