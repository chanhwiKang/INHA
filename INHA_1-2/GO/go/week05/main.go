package main

import (
	"bufio"
	"fmt"
	"log"
	"math/rand"
	"os"
	"strconv"
	"strings"
	"time"
)

func main() {
	rand.Seed(time.Now().Unix())
	answer := rand.Intn(100) + 1
	fmt.Println("1에서 100까지 숫자맞추기 레쓰기릿")
	fmt.Println(answer)

	reader := bufio.NewReader(os.Stdin)

	for i := 0; i < 10; i++ {
		fmt.Println("남은 기회", 10-i)
		fmt.Print("당신의 선택은?:")
		inputNumberString, err := reader.ReadString('\n')
		if err != nil {
			log.Fatal(err)
		}
		inputNumberString = strings.TrimSpace(inputNumberString)
		inputNumber, err := strconv.Atoi(inputNumberString)
		if inputNumber > answer {
			fmt.Println("더 낮게")
		} else if inputNumber < answer {
			fmt.Println("더 높게")
		} else {
			fmt.Println("정답입니다~")
			break
		}

	}
}
