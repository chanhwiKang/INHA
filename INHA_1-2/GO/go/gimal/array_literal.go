package main

import "fmt"

func floatSum(floatArr [3]float64) float64 {
	sum := 0.0
	for _, val := range floatArr {
		sum += val
	}
	return sum
}
func main() {
	var arr1 [3]int
	arr1[0] = 00
	arr1[1] = 11
	arr1[2] = 22
	for index, val := range arr1 {
		fmt.Println(index, val)
	}

	arr2 := [3]float64{0.0, 1.1, 2.2}
	for index, val := range arr2 {
		fmt.Println(index, val)
	}

	fmt.Printf("%0.2f", floatSum(arr2))
}
