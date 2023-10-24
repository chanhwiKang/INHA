package main

import "fmt"

// call by pointer(pass by pointer)
func swap(n1 *int, n2 *int) {
	temp := *n1
	*n1 = *n2
	*n2 = temp
}

func main() {
	a := 10
	b := 20

	c := &a // 단축 선언으로 해도 포인터 변수로 선언됨
	swap(&a, &b)
	fmt.Printf("%d, %d, %T", a, b, c)
}
