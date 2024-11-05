def push(data):
    global top
    if is_stack_full():
        print("stack is empty")
        return 
    top += 1
    stack[top] = data

def pop():
    if is_stack_empty():
        print("stack is empty")
        return
    tmp = stack[top]
    stack[top] = None
    top -= 1
    return tmp

def is_stack_empty():
    if top == -1:
        return True
    return False

def is_stack_full():
    global top, stack
    if SIZE == top:
        return True
    return False

SIZE = int(input("input stack size -> "))
stack = [None for _ in range(SIZE)]
top = -1

if __name__ == "__main__":
    while True:
        select = input("삽입(I)/추출(E)/확인(V)/종료(X) 중 하나를 선택 ==> ")

        if select == 'I' or select == 'i':
            data = input("input date -> ")
            push(data)
            print("stack status : ", stack)
        elif select == 'E' or select == 'e':
            data = pop()
            print("poped data -> ", data)
            print("stack status : ", stack)
        elif select=='V' or select =='v' :
            pass