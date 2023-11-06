package main

import (
	"bufio"
	"fmt"
	"go/scanner"
	"log"
	"os"
)

func main() {
	// var primes [3]int
	// primes[0] = 2
	// primes[2] = 5

	// primes := [3]int{} //빈 배열
	primes := [3]int{2, 3, 5}
	primes[2] = 6
	for i := 0; i < 3; i++ {
		fmt.Println(primes[i])
	}

	// 초기화하지 않은 원소의 제로값은 해당 원소 타입의 제로값으로 결정됨
	test := [5]bool{true, true, true}
	fmt.Println(test)           // [true true true false false]
	fmt.Printf("%#v\n", primes) // [3]int{2, 3, 6}
	for i := range test {
		fmt.Println(i, test[i])
	}
	for i, prime := range primes {
		fmt.Println(i, prime)
	}
	for _, prime := range primes {
		fmt.Println(prime)
	}

}
