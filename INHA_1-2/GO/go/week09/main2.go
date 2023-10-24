package main

import "fmt"

func double(number *int) {
	*number = *number * 2
}
func main() {
	var amount int = 5
	double(&amount)
	fmt.Printf("%d", amount)
}
