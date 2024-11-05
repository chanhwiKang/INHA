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

top = -1

if __name__ == "__main__":
    sentence = input("수식을 입력하세요.")
    SIZE = len(sentence)
    stack = [None for _ in range(SIZE)]
    for c in sentence:
        if c in "({<[":
            push(c)
        elif c == ")" and pop() != "(": break
        elif c == "]" and pop() != "[": break
        elif c == ">" and pop() != "<": break
        elif c == "}" and pop() != "{": break
    if is_stack_empty():
        print("정상")
    else:
        print("비정상")
    
            