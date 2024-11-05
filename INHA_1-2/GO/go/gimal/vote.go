package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
)

func getStringInText() map[string]int {
	votes_sum := make(map[string]int)
	key := ""
	file, err := os.Open("/Users/gangchanhwi/Desktop/INHA/INHA_1-2/GO/go/gimal/text/votes.txt")
	if err != nil {
		log.Fatal(err)
	}
	scanner := bufio.NewScanner(file)
	for scanner.Scan() {
		key = scanner.Text()
		if votes_sum[key] == 0 {
			votes_sum[key] = 1
		} else {
			votes_sum[key]++
		}
	}
	return votes_sum

}
func main() {
	votes_sum := getStringInText()
	for k, v := range votes_sum {
		fmt.Println(k, v)
	}
}
