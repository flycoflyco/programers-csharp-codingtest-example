#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int a, int b) {
    char ab[10];

    sprintf(ab, "%d%d", a, b);

    int sum = 2 * a * b;
    int num1 = atoi(ab);

    return (sum >= num1) ? sum : num1;
}
