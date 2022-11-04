#include <stdio.h>

int main(void) {

  int firstNum;
  int secondNum;
  
  printf("Input your first number\n");
  scanf("%d", &firstNum);

  printf("Input your second number\n");
  scanf("%d", &secondNum);

  printf("%d", firstNum + secondNum);
  
  return 0;
}
