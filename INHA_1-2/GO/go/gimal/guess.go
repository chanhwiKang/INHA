package main

import (
	"bufio"
	"fmt"
	"log"
	"math/rand"
	"os"
	"strconv"
	"strings"
)

func main() {
	// seconds := time.Now().Unix()
	// rand.Seed(seconds)
	target := rand.Intn(100) + 1
	fmt.Println(target)
	i := 0
	for {
		i++
		fmt.Println("상대방의 숫자를 맞춰보세요: ")
		reader := bufio.NewReader(os.Stdin)
		input, err := reader.ReadString('\n')
		if err != nil {
			log.Fatal(err)
		}
		input = strings.TrimSpace(input)
		yourNum, err := strconv.Atoi(input)
		if err != nil {
			log.Fatal(err)
		}
		if yourNum > target {
			fmt.Println("컴퓨터의 숫자가 더 작습니다.")
			fmt.Println("남은 횟수: ", 10-i)
		} else if yourNum < target {
			fmt.Println("컴퓨터의 숫자가 더 큽니다.")
			fmt.Println("남은 횟수: ", 10-i)
		} else {
			fmt.Println("correct")
			break
		}
		if i == 10 {
			fmt.Println("맞추지 못했습니다. 정답은", target)
		}
	}

}
