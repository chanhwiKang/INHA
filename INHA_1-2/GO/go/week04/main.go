package main

import (
	"fmt"
	"math"
	"reflect"
)

func main() {
	var a = 3
	var b, d float32 = 2.7, 3.1
	var c string
	var f string
	var g bool

	var price int = 100
	fmt.Println("Price is", price, "dollars")

	var taxRate float64 = 0.08
	var tax float64 = float64(price) * taxRate
	fmt.Println("Tax is", tax, "dollars")

	var total float64 = float64(price) + tax
	fmt.Println("Total cost is", total, "dollars")

	var availableFunds int = 120
	fmt.Println(availableFunds, "dollars avilable")
	fmt.Println("Within budget?", float64(availableFunds) >= total)

	fmt.Println("------------------")
	fmt.Println(float32(a) > b)
	fmt.Println(float32(a) * b)

	h := 'Z'
	i := "aplle"
	// J := "변수명이 대문자로 시작하면 다른 패키지에서 사용할 수 있음"
	fmt.Println(h, reflect.TypeOf(i))

	fmt.Println(f, g)
	c = "inha"
	a = 9
	fmt.Println(a, b, c, d)

	fmt.Println(reflect.TypeOf('B'))
	fmt.Println(reflect.TypeOf(100))
	fmt.Println(reflect.TypeOf(2.71))
	fmt.Println(reflect.TypeOf(false))
	fmt.Println(reflect.TypeOf("go"))
	// fmt.Println(math.Floor("inha"))
	// fmt.Println(strings.Title(3.14))
	fmt.Println(0xae40)
	fmt.Println(math.Floor(2.75))
	fmt.Println(math.Ceil(2.75))
}
