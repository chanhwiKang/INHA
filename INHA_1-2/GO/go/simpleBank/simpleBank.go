// simple bank system
package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
	"strconv"
	"strings"
)

var userList = make(map[string]Person)

type Person struct {
	InOutput     string
	InOutMoney   string
	CurrentMoney string
}

func UserDupChk(newName string) bool {
	_, exists := userList[newName] // newName이 이미 userList에 있는지 확인
	return exists
}
func AccountUpdate(inOutMoney string, currentMoney string, inOutPut string) string {
	inOutMoneyInt, _ := strconv.Atoi(inOutMoney)
	currentMoneyInt, _ := strconv.Atoi(currentMoney)
	result := 0
	if inOutPut == "input" {
		result = inOutMoneyInt + currentMoneyInt
	} else if inOutPut == "output" {
		result = currentMoneyInt - inOutMoneyInt
	} else {
		return "0"
	}
	m := strconv.Itoa(result)
	return m
}
func Bank() {
	for {
		reader := bufio.NewReader(os.Stdin)
		fmt.Print("고객님 성함, 입/출금여부, 입/출금 금액을 입력해주세요.")
		userData, err := reader.ReadString('\n')
		userData = strings.TrimSpace(userData)
		if userData == "LIST" {
			// 사용자 목록 출력
			for name := range userList {
				fmt.Printf("%s %s\n", name, userList[name].CurrentMoney)
			}
			continue
		}

		splitedUserData := strings.Split(userData, " ")

		if err != nil {
			log.Fatal(err)
		}

		tempName := splitedUserData[0]
		tempInOut := splitedUserData[1]
		tempInOutMoney := splitedUserData[2]

		isDup := UserDupChk(tempName) // 중복 체크
		if !isDup {                   // 신규 고객이면 계좌 만들기
			userList[tempName] = Person{
				InOutput:     tempInOut,
				InOutMoney:   tempInOutMoney,
				CurrentMoney: "",
			}
		}
		tempSumMoney := AccountUpdate(tempInOutMoney, userList[tempName].CurrentMoney, tempInOut)
		tempPerson := userList[tempName]
		tempPerson.InOutput = tempInOut
		tempPerson.InOutMoney = tempInOutMoney
		tempPerson.CurrentMoney = tempSumMoney
		userList[tempName] = tempPerson

		fmt.Printf("%s고객님의 계좌에서 %s원을 %s했습니다. 잔액은 %s원입니다.\n", tempName, userList[tempName].InOutMoney, userList[tempName].InOutput, userList[tempName].CurrentMoney)
	}
}

func main() {
	Bank()
}
