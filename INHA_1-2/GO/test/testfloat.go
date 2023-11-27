package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
	"strconv"
)

func getFloats(fileName string) ([3]float64, error) {
	var numbers [3]float64
	file, err := os.Open(fileName)
	if err != nil {
		return numbers, err
	}
	scanner := bufio.NewScanner(file)
	i := 0
	for scanner.Scan() {
		numbers[i], err = strconv.ParseFloat(scanner.Text(), 64)
		if err != nil {
			return numbers, err
		}
		i++
	}
	err = file.Close()
	if err != nil {
		return numbers, err
	}
	if scanner.Err() != nil {
		return numbers, scanner.Err()
	}
	return numbers, nil
}
func main() {
	numbers, err := getFloats("/Users/gangchanhwi/Desktop/INHA/INHA_1-2/GO/test/data.txt")
	if err != nil {
		log.Fatal(err)
	}
	var sum float64 = 0
	for _, v := range numbers {
		fmt.Println(v)
		sum += v
	}
	fmt.Println(sum)
}
