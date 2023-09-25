#include <stdio.h> 

int main(){
    int sum=0;
    int arr[5];

    for(int i=0;i<5;i++){
        printf("학생들의 성적을 입력하시오: ");
        scanf("%d", &arr[i]);
    }
    for(int i=0;i<5;i++){
        sum+=arr[i];
    }
    printf("성적 평균 = %d\n", sum/5);

    return 0;
}