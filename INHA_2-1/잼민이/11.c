#include <stdio.h> 

char list[5] = {};
int money[5] = {0,};
int customer_cnt = 0;

void Bank(){
    char name;
    int is_customer;
    int menu;
    int customer_num = -1;
    getchar();
    printf("1. 신규 계좌 개설\n2. 잔액 조회");
    scanf("%d", &menu);
    getchar();
    printf("성함을 기재해주세요: ");
    scanf("%c", &name);
    
    for(int i=0; i<5; i++){
        if (list[i] == name) {
            is_customer = 1;
            customer_num = i;
            break;
        } else is_customer = 0;
    }

    if (is_customer == 0 ){
        if (menu == 1){
            for (int i=0; i<5; i++){
                if (list[i]=='\0'){
                    list[i] = name;
                    printf("%c님의 신규 계좌가 발행되었습니다.\n잔액은 0원입니다.\n", name);
                    return;
                }
            }
        } else if (menu == 2){
            printf("%c님은 기존 고객이 아닙니다. 신규 계좌 발급부탁드립니다.\n", name);
            return;
        } else {
            printf("1 혹은 2만 입력부탁드립니다.\n");
            return;
        }
    } else if (is_customer == 1){
        if (menu == 1){
            printf("기존에 가입한 분 입니다.\n");
            return;
        } else if (menu == 2){
            printf("%c님의 잔액은 %d원입니다.\n", name, money[customer_num]);
        }
    }

}

void In_out_money(){
    char name;
    int menu;
    int is_customer=0;
    int customer_num;
    int tmp_money;
    getchar();
    printf("입/출금할분의 성함을 입력해주세요: ");
    scanf("%c", &name);
    getchar();
    printf("1. 입금 2. 출금");
    scanf("%d", &menu);

    for(int i=0; i<5; i++){
        if (list[i] == name) {
            is_customer = 1;
            customer_num = i;
            break;
        }
    }
    if (is_customer == 0){
        printf("기존 고객이 아닙니다. 신규 계좌를 개설해주세요.\n");
        return;
    } else {
        if (menu == 1){
            printf("입금하실 금액을 입력해주세요 : ");
            scanf("%d", &tmp_money);
            money[customer_num] += tmp_money;
            printf("현재 잔액은 %d원 입니다.\n", money[customer_num]);

        } else if (menu == 2){
            printf("출금하실 금액을 입력해주세요 : ");
            scanf("%d", &tmp_money);
            money[customer_num] -= tmp_money;
            printf("현재 잔액은 %d원 입니다.", money[customer_num]);
        } else printf("1 혹은 2만 입력부탁드립니다.\n"); 
        return;
    }
}
int main(){
    int menu;
    while (1)
    {
        printf("1. 새 계좌 만들기 혹은 잔액 확인\n");
        printf("2. 입/출금\n");
        printf("3. 송금\n");
        printf("4. 프로그램 종료\n");
        scanf("%d", &menu);
        if (menu == 1) Bank();
        else if (menu == 2) In_out_money();
        else if (menu == 3){}
        else if (menu == 4 )break;
    }
    printf("프로그램을 종료합니다.");
    return 0;
}
