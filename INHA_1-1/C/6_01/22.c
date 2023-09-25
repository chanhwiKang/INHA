#include <stdio.h> 
#include <string.h>

int main(){

    char arr[10001] = {};
    int i = 0;
    int KOI = 0, IOI = 0;

    scanf("%s", arr);
    
    for(i=0; i<strlen(arr)-2; i++){
        if((arr[i]=='K')&&(arr[i+1]=='O')&&(arr[i+2]=='I')){
            KOI++;
        }
        else if((arr[i]=='I')&&(arr[i+1]=='O')&&(arr[i+2]=='I')){
            IOI++;
        }
    }
    
    printf("%d\n%d\n", KOI, IOI);
    return 0;
}