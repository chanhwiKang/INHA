#include <stdio.h> 

int main(){

    int arr[10]={0,};
    int var1, var2, var3;
    int num, remain;

    scanf("%d %d %d", &var1, &var2, &var3);
    num = var1 * var2 * var3;
    printf("세 수의 곱: %d\n", num);
    while(1){
        if(num!=0){
            remain = num%10;
            num /= 10;
        }else {break;}
        arr[remain]++;
    }
    for(int i=0; i<10; i++){
        printf("%d이 들어간 횟수 : %d\n", i,arr[i]);
    }
    return 0;
}