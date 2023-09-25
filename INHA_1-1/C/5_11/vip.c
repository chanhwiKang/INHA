#include <stdio.h> 

int discount(int price, char grade){
    if(grade == 'S'){
        return price * 0.95;
    }
    else if(grade == 'G'){
        return price * 0.9;
    }
    else {
        return price * 0.85;
    }
}
int main(){

    int price1, price2, price3;
    char grade1, grade2, grade3;
    price1 = 2500;
    price2 = 96900;
    price3 = 85000;
    grade1 = 'S';
    grade2 = 'G';
    grade3 = 'V';
    int ans = discount(price2, grade2);;
    
    printf("%d\n", ans);
    return 0;
}

