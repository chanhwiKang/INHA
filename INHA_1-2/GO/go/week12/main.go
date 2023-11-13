package main

import "fmt"

func main() {
	// 방법 1
	// var s []int
	// s = make([]int, 5)

	// 방법 2
	// s := make([]int, 5)

	// 방법 3
	s := []int{0, 0, 0, 0, 0}

	for _, v := range s {
		fmt.Println(v)
	}
}
