#include <stdio.h> 

int main(){

    int score;
    int result = 0;
    int i = 0;

    while(1) {
        scanf("%d", &score);
        if(score < 0) {
            break;
        }
        i++;
        result += score;
        
    }
    printf("%d\n", result/i);
    return 0;
}