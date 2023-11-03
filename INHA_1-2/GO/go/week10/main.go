package main

import (
	"fmt"
	"week10/src/greeting"
	"week10/src/mymath"
)

func main() {
	fmt.Println(mymath.MyAbs(-10))
	fmt.Println(mymath.MyAbs(120))
	fmt.Println(mymath.MyPower(2, 10))
	greeting.Hello()
	greeting.Hi()
}
