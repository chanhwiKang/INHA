#include <stdio.h>

int main() {
    char grade = ' ';
    char grade0 = ' ';
    int score;
    scanf("%d", &score);

    if (score >= 95) {
        grade = 'A';
        grade0 = '+';
    }
    else if (score >= 90) {
        grade = 'A';
        grade0 = '0';
    }
    else if (score >= 85 && score <= 89) {
        grade = 'B';
        grade0 = '+';
    }
    else if (score >= 80 && score <= 84) {
        grade = 'B';
        grade0 = '0';
    }
    else if (score >= 75 && score <= 79) {
        grade = 'C';
        grade0 = '+';
    }
    else if (score >= 70 && score <= 74) {
        grade = 'C';
        grade0 = '0';
    }
    else if (score >= 65 && score <= 69) {
        grade = 'D';
        grade0 = '+';
    }
    else if (score >= 60 && score <= 64) {
        grade = 'D';
        grade0 = '0';}
    else if (score < 60) {
        grade = 'F';
    }

    printf("%c%c\n\n", grade, grade0);
    printf("201602148, 임재건");
    return 0;
}
