package main

import "fmt"

func main() {
	// 방법 1
	// var s []int
	// s = make([]int, 5)

	// 방법 2
	// s := make([]int, 5)

	// 방법 3 slice literal
	s := []int{0, 1, 2, 3, 4}

	s[4] = 99

	for _, v := range s {
		fmt.Println(v)
	}

	copyS := s[1:4]
	for _, v := range copyS {
		fmt.Println(v)
	}

	for i := 0; i < len(s); i++ {
		fmt.Println(s[i])
	}
}
