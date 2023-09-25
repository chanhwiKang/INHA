#include <stdio.h> 
int UserInput();
void cal(int a);

int main(){

    int num = UserInput();
    cal(num);

    return 0;
}

int UserInput(){
    int a;
    printf("정수를 입력:");
    scanf("%d", &a);
    return a;
}
void cal(int a){
    int count=0;
    for(int i=1; i<a; i++){
        for(int j=1; j<=i; j++){
            if(i%j == 0){
                count+=1;
            }
        }
        if(count==2){
            printf("%d", i);
        }
        count = 0;
    }
    printf("\n");
}