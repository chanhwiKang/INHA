package main

import (
	"fmt"
	"log"
	"os"
)

func isPrime(n int) (bool, error) {
	if n < 2 {
		return false, fmt.Errorf("%d는 소수가 아닙니다", n)
	}
	for i := 2; i < n; i++ {
		if n%i == 0 {
			return false, nil
		}
	}
	return true, nil
}

func Prime(n int) {
	fmt.Println("구현 안됨 XD")
}

func PrimeRange(a int, b int) {
	if a > b {
		temp := a
		a = b
		b = temp
	}
	for i := a; i <= b; i++ {
		p, err := isPrime(i)
		if err != nil {
			fmt.Println(err)
			os.Exit(0)
		}
		if p {
			fmt.Print(i, " ")
		}
	}
}

func main() {
	var menu int
	for true {
		fmt.Print("소수 판정 = 1, 범위 내 소수 = 2:")
		_, err := fmt.Scanln(&menu)
		if err != nil {
			log.Fatal(err)
		}
		switch menu {
		case 1:
			var num int
			fmt.Print("input int: ")
			_, err := fmt.Scanln(&num)
			if err != nil {
				log.Fatal(err)
			}
			Prime(num)
		case 2:
			var num1, num2 int
			fmt.Print("input two int: ")
			fmt.Scanln(&num1, &num2)
			if err != nil {
				log.Fatal(err)
			}
			PrimeRange(num1, num2)
		default:
			os.Exit(0)
		}

	}
}
