# 실행하고자 하는 코드를 try안에 입력
try:
    list_score = [10, 20, 30, 40, 50, 60]
    number1 = int(input("분자:"))
    number2 = int(input("분모:"))
    result = number1 // number2
    print(result)
    print(list_score[result])

# 실행 중 문제가 발생하면 처리하는 코드블록
except ValueError as ex:
    print("정수 입력 하세요")
except ZeroDivisionError as ex:
    print("분모에 0을 넣지 마세요")
# valueErr, zeroDivErr외의 err를 예외처리
except Exception as ex: 
    print(type(ex))
    print(ex)
    print("예외 발생, ", end="")
    print("비정상 종료")

age = 9
if age < 10:
    # pass사용 시 err 없이 진행되기 때문에 일부러 err발생
    raise NotImplementedError