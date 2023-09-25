#include <stdio.h> 

int main(){

    char op;
    int a,b,result;

    printf("수식을 입력하시오(예: 2 + 5) >> ");
    scanf("%d %c %d", &a, &op, &b);

    if(op=='+'){
        result = a+b;
    }else if(op=='-'){
        result = a-b;
    }else if(op=='*'){
        result = a*b;
    }else if(op=='/'){
        result = a/b;
    }else if(op=='%'){
        result = a%b;
    }else {
        printf("지원되지 않는 연산자입니다.\n");
    }
    printf("%d %c %d = %d\n", a, op, b, result);
    return 0;
}