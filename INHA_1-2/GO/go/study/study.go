package main

import (
	"fmt"
)

//난수 추출된 수의 소수 판정 프로그램 ve.6

func main() {

	// seed := (time.Now().Unix())
	// rand.Seed(seed)

	isPrime := true
	// number := rand.Intn(150) + 2
	// fmt.Println("임으로 추출된 수 : ", number)
	number := 13
	for i := 2; i < number; i++ {
		if number%i == 0 {
			isPrime = false
			break
		}
		fmt.Print(i, " ")
	}

	if isPrime {
		fmt.Println(number, "는(은) 소수입니다!")
	} else {
		fmt.Println(number, "는(은) 소수가 아닙니다!")
	}

}
