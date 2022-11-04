package main

import (
	"fmt"
)

func main() {

	var firstnum int 
	var secondnum int 
	var sum uint8 

	fmt.Print("Input your first number: ") 
	fmt.Scan(&firstnum) 
	fmt.Print("\nInput your second number: ") 
	fmt.Scan(&secondnum) 
	sum = uint8(firstnum) + uint8(secondnum) 

	fmt.Println("\nThe sum of your two numbers is:", sum) 

}
