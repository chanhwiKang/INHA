package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
	"strconv"
	"strings"
)

func main() {
	fmt.Print("Enter a grade: ")
	reader := bufio.NewReader(os.Stdin)
	input, err := reader.ReadString('\n')
	if err != nil {
		log.Fatal(err)
	}
	// 문자열을 int로 변환하는 방법
	input = strings.TrimSpace(input) // 1. 문자열의 공백을 제거
	// inputFloat, err := strconv.ParseFloat(input, 64) // 2-1. str -> float64로 변환
	inputInt, err := strconv.Atoi(input) // 2-2. str -> int로 변환
	if err != nil {
		log.Fatal(err)
	}
	if inputInt > 60 {
		fmt.Println("pass")
	} else {
		fmt.Println("no pass")
	}
}
