package main

import (
	"fmt"

	"go/week10/mymath"

	"go/week10/greeting"
)

func main() {
	fmt.Println(mymath.MyAbs(-10))
	fmt.Println(mymath.MyAbs(120))
	fmt.Println(mymath.MyPower(2, 10))
	greeting.Hello()
	greeting.Hi()
}
