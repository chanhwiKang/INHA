package main

import "fmt"

func main() {
	// 방법 1
	var s []int
	s = make([]int, 5)

	// 방법 2
	for _, v := range s {
		fmt.Println(v)
	}
}
