#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int a, int b) {
    char ab[10];
    char ba[10];

    sprintf(ab, "%d%d", a, b);
    
    // sprintf(ba, "%d%d", b, a);
    int sum = 2 * a * b;
    
    int num1 = atoi(ab);
    // int num2 = atoi(ba);

    return (sum >= num1) ? sum : num1;
}