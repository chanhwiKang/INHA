package main

import "fmt"

func main() {
	var a []string
	// a := make([]string, 4, 5) // make 안쓰면 zero value

	a = append(a, "1")    //
	fmt.Printf("%v\n", a) // zero val of empty slice

	fmt.Println(a, len(a), cap(a))
}
