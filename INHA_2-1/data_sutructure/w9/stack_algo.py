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

def check_bracket(expr) :
	for ch in expr:
		if ch in '([{<':
			push(ch)
		elif ch in ')]}>':
			out = pop()
			if ch == ')' and out == '(':
				pass
			elif ch == ']' and out == '[':
				pass
			elif ch == '}' and out == '{':
				pass
			elif ch == '>' and out == '<':
				pass
			else:
				print("괄호 짝이 다름")
				return False
		else :
			pass
	return is_stack_empty()
      
SIZE = 100
stack = [ None for _ in range(SIZE) ]
top = -1

## 메인 코드 부분 ##
if __name__ == "__main__" :

	exprAry = ['(A+B)', ')A+B(', '((A+B)-C', '(A+B]', '(<A+{B-C}/[C*D]>)']

	for expr in exprAry :
		top = -1
		print(expr, '==>', check_bracket(expr))
    
            