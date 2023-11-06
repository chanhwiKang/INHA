package main

import (
	"fmt"
	"log"
	"week11/floats"
)

// func GetFloats(fileName string) ([3]float64, error) {
// 	var numbers [3]float64
// 	file, err := os.Open(fileName)
// 	if err != nil {
// 		return numbers, err
// 	}
// 	i := 0
// 	scanner := bufio.NewScanner(file)
// 	for scanner.Scan() {
// 		numbers[i], err = strconv.ParseFloat(scanner.Text(), 64)
// 		if err != nil {
// 			return numbers, err
// 		}
// 		i++
// 	}
// 	err = file.Close()
// 	if err != nil {
// 		return numbers, err
// 	}
// 	if scanner.Err() != nil {
// 		return numbers, scanner.Err()
// 	}
// 	return numbers, nil
// }

func main() {
	// file, err := os.Open("data.txt")
	// if err != nil {
	// 	log.Fatal(err)
	// }
	// scanner := bufio.NewScanner(file)
	// for scanner.Scan() { // scanner.Scan()은 읽어들일게 있으면 true반환
	// 	fmt.Println(scanner.Text())
	// }
	// err = file.Close()
	// if err != nil {
	// 	log.Fatal(err)
	// }
	// if scanner.Err() != nil {
	// 	log.Fatal(scanner.Err())
	// }

	numbers, err := floats.GetFloats("data.txt")
	if err != nil {
		log.Fatal(err)
	}
	var sum float64 = 0
	for _, number := range numbers {
		sum += number
	}
	sampleCount := float64(len(numbers))
	fmt.Printf("Average: %0.2f\n", sum/sampleCount)
}
