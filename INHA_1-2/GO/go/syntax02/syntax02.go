package main

import (
	"fmt"
	"reflect"
)

func main() {
	c := 'a'
	a := 22
	// NewReplacer - Replace, reflect
	fmt.Println(reflect.TypeOf(c))
	fmt.Println(reflect.TypeOf(a))
}
