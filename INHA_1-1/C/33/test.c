#include <stdio.h> 

int main(){

    int arr1[5]={0, 1, 2};
    int arr2[5]={3, 4, 5};

    arr1[3]=arr2[1];

    printf("%d", arr1[3]);

    return 0;
}

