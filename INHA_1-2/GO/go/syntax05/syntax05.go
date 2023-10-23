package main

import (
	"fmt"
	"log"
	"os"
)

// Scanln으로 정수 입력받아 소수 판별
func main() {
	var number int
	fmt.Println("정수 입력:")
	_, err := fmt.Scanln(&number)

	if err != nil {
		log.Fatal(err)
	}

	isPrime := true
	if number < 2 {
		println(number, "는 소수가 아닙니다.")
		os.Exit(1) // 프로그램 종료, 0은 정상 종료
	}
	for i := 2; i < number; i++ {
		if number%i == 0 {
			isPrime = false
			break
		}
	}

	if isPrime {
		println(number, "는 소수입니다.")
	} else {
		println(number, "는 소수가 아닙니다.")
	}

}
