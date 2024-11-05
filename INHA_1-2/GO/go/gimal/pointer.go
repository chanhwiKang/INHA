package main

import "fmt"

func double(a *int) {
	*a = *a * *a
}
func main() {
	a := 3
	ap := &a
	fmt.Println(a)
	double(&a)
	fmt.Println(a)
	double(ap)
	fmt.Println(a)

}
