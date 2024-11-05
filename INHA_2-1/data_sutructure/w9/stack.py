def is_stack_empty() -> bool:
    if top == -1:
        return True
    return False

def pop():
    global top
    # if is_stack_empty():
    if top == -1: # is_stack_empty함수와 통합했을 떄
        print("Stack is empty")
        return
    data = stack[top]
    stack[top] = None
    top -= 1
    return data

def peek():
    # if is_stack_empty():
    if top == -1: # is_stack_empty함수와 통합했을 떄
        print("Stack is empty")
        return None
    return stack[top]

def is_stack_full() -> bool:
    global top, stack
    if top == SIZE-1:
        return True
    return False

def push(data):
    global top
    if is_stack_full():
        print("stack is full")
        return
    top += 1
    stack[top] = data


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