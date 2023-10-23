package main

import (
	"fmt"
	"math"
	"strings"
)

func main() {
	c := 'a'
	a := 22
	fmt.Println(a)

	fmt.Println(c)          // 유니코드(utf-8)값 출력
	fmt.Printf("%c\n", c)   // 룬 출력
	fmt.Printf("%T\n\n", c) // 타입 출력

	fmt.Println("hello")
	fmt.Println(math.Floor(2.71))
	fmt.Println(strings.Title("go git github java"))
}
