package main

import (
	"fmt"
	"reflect"
)

func main() {
	a := 1
	b := 0.1
	c := "asd"
	d := "a"

	// 타입 반환 메소드
	fmt.Println(reflect.TypeOf(float64(a))) // float64
	fmt.Println(reflect.TypeOf(a))          // int
	fmt.Println(reflect.TypeOf(b))
	fmt.Println(reflect.TypeOf(c))
	fmt.Println(reflect.TypeOf(d))
}
