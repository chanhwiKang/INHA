#include <stdio.h> 

int main(){
    // 2개의 값을 입력받아 0, 1번째 인덱스에 넣는다.
    // 사칙연산 중 한가지를 진행한 후, 2번째 인덱스에 넣는다.
    // 11번째 라인과 같이 출력한다.
    int a =0;
    int b =1;
    int arr[3] = {1, 2, 3};
    scanf("%d %d", &arr[0], &arr[1]);
    scanf("%d %d", arr, arr+1);

    fuction(arr);
    
    printf("%d %d %d", arr[0], arr[1], arr[2]);
    return 0;
}
void fuction(int *a,int *b){
    *a = *a + 1;
    *b = *b + 2;
}