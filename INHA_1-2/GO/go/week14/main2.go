package main

import "fmt"

func main() {
	// 선언하는 부분 주석 바꿔가며 출력 비교
	balls := make(map[string]int)
	// var balls map[string]int

	fmt.Printf("%#v\n", balls)

	balls["성기훈"] = 20
	fmt.Println(balls["성기훈"])
	fmt.Println(balls["오일남"])
}
