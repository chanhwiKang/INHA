package main

import "fmt"

func swap(a *int, b *int) {
	tmp := *a
	*a = *b
	*b = tmp
}
func main() {
	a := 10
	b := 20
	fmt.Println(a, b)

	swap(&a, &b)

	fmt.Println(a, b)
}
