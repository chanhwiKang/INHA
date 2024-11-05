#include <stdio.h> 
int GetUserInput(int x);
int Gugudan(int x, int y);
int main(){
    int t1,t2;
    int input[2]={};
    GetUserInput(input);
    Gugudan(t1, t2);

    return 0;
}
int GetUserInput(int x){
    int input1, input2;

    while(1){
        scanf("%d %d", &x[0], &input2);

        if(((input1 < 2) || (input1 > 9))||((input2 < 2) || (input2 > 9))){
            printf("INPUT ERROR!\n");
        }
        else {
            break; 
        }
    }
    return 0;
}
int Gugudan(int x, int y){

    
    if(x > y){
        for(int i=1; i<=9; i++){
            for(int j=x; j>=y; j--){
                printf("%d * %d = %2d   ", j, i, i*j);
            }
            printf("\n");
        }
    }else if(y > x){
        for(int i=1; i<=9; i++){
            for(int j=x; j<=y; j++){
                printf("%d * %d = %2d   ", j, i, i*j);
            }
            printf("\n");
        }
    }else {
        for(int j=1; j<=9; j++){
                printf("%d * %d = %2d\n", x, j, y*j);
            }
    }
    return 0;
}