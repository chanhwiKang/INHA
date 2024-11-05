package main

import (
	"fmt"

	"week10/mymath"

	"week10/greeting"
)

func main() {
	fmt.Println(mymath.MyAbs(-10))
	fmt.Println(mymath.MyAbs(120))
	fmt.Println(mymath.MyPower(2, 10))
	greeting.Hello()
	greeting.Hi()
}
