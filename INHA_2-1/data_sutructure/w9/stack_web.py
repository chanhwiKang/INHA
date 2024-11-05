import webbrowser
import time

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

SIZE = 5
stack = [None for _ in range(SIZE)]
top = -1

## 메인 코드 부분 ##
if __name__ == "__main__" :
    urls = [ 'naver.com', 'daum.net', 'nate.com']

    for url in urls :
        push(url)
        webbrowser.open('http://'+url)
        print(url, end = '-->')
        time.sleep(1)

    print("방문 종료")
    time.sleep(5)

    while True :
        url = pop()
        if url is None :
            break
        webbrowser.open('http://'+url)
        print(url, end = '-->')
        time.sleep(1)
    print("방문 종료")