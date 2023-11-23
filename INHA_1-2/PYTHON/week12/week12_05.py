while True:
    # 실행하고자 하는 코드를 try안에 입력
    try:
        list_score = [10, 20, 30, 40, 50, 60]
        number1 = int(input("분자:"))
        number2 = int(input("분모:"))
        result = number1 // number2
        print(result)
        print(list_score[result])
        print("정상종료")
        break

    # 실행 중 문제가 발생하면 처리하는 코드블록
    except:
        print("예외 발생, ", end="")
        print("비정상 종료")
print("완전종료")