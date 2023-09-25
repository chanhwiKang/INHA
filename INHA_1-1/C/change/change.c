#include <stdio.h>

int main(void){
    int price, money, change;
    int c1000, c500, c100;

    printf("물건 값: ");
    scanf("%d", &price);
    
    printf("투입 한 금액: ");
    scanf("%d", &money);

    change = money - price; //거스름돈 계산
    c1000 = change / 1000; //1000원권 계산

    printf("\n거스름돈\n천원: %d장", c1000);
    change = change - c1000*1000; //남은 돈 계산
    c500 = change / 500; //500원 계산

    printf("\n오백원: %d개", c500);
    change = change - c500*500; //남은 돈 계산
    c100 = change / 100; //100원 계산

    printf("\n백원: %d개\n", c100);
    return 0;
}