package main

import (
	"fmt"
)

func main() {

	var firstnum int 
	var secondnum int 
	var operation string
	var total uint8 

	fmt.Print("Input your first number: ") 
	fmt.Scan(&firstnum) 
	fmt.Print("\nInput your second number: ") 
	fmt.Scan(&secondnum) 
	fmt.Print("\nInput your desired operation: ") 
	fmt.Scan(&operation) 

  if (operation == "+") {
    total = uint8(firstnum) + uint8(secondnum) 
  }
  if (operation == "-") {
    total = uint8(firstnum) - uint8(secondnum) 
  }
  if (operation == "*") {
    total = uint8(firstnum) * uint8(secondnum) 
  }
  if (operation == "/") {
    total = uint8(firstnum) / uint8(secondnum) 
  }
  

	fmt.Println("\nThe total of your two numbers is:", total) 

}
