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
	file, err := os.Open("/Users/gangchanhwi/Desktop/INHA/INHA_1-2/GO/go/gimal/text/data.txt")
	if err != nil {
		log.Fatal(err)
	}
	scanner := bufio.NewScanner(file)
	sum := 0.0
	for scanner.Scan() {
		file_text := strings.TrimSpace(scanner.Text())
		file_float, err := strconv.ParseFloat(file_text, 64)
		if err != nil {
			log.Fatal(err)
		}
		sum += file_float
	}
	fmt.Println(sum)
}
