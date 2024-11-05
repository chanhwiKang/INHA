def push(data):
    global top, stack
    if is_stack_full():
        return False
    top += 1
    stack[top] = data

def pop():
    global top, stack
    if is_stack_empty():
        return False
    tmp = stack[top]
    stack[top] = None
    top -= 1
    return tmp

def is_stack_empty():
    global top, stack
    if top == -1:
        return True
    return False

def is_stack_full():
    global top, stack
    if SIZE-1 == top:
        return True
    return False

SIZE = int(input("스택 크기를 입력하세요 ==>"))
stack = [None for _ in range(SIZE)]
top = -1

## 메인 코드 부분 ##
if __name__ == "__main__" :

    while True :
        select = input("삽입(I)/추출(E)/확인(V)/종료(X) 중 하나를 선택 ==> ")
        
        if select=='I' or select =='i' :
            data = input("입력할 데이터 ==> ")
            push(data)
            print("스택 상태 : ", stack)
        elif select=='E' or select =='e' :
            data = pop()
            print("추출된 데이터 ==> ", data)
            print("스택 상태 : ", stack)
        elif select=='V' or select =='v' :
            data = peek()
            print("확인된 데이터 ==> ", data)
            print("스택 상태 : ", stack)
        elif select != 'X' or select != 'x':
            break
        else :
            print("입력이 잘못됨")
            break
    print("프로그램 종료!")