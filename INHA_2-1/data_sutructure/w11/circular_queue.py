# 원형 큐

def is_queue_full() -> bool:
    if (rear + 1) % SIZE == front : # rear == front
        return True
    return False

def is_queue_empty() -> bool:
    global SIZE, rear, front
    if front == rear :
        return True
    return False

def en_queue(data):
    global rear
    if is_queue_full():
        print("큐가 가득 찼습니다.")
        return None
    rear = (rear + 1) % SIZE
    queue[rear] = data

def de_queue():
    global front
    if is_queue_empty():
        print("큐가 비었습니다.")
        return None
    front = (front + 1) % SIZE 
    data = queue[front]
    queue[front] = None
    return data

def peek():
    global front
    if is_queue_empty():
        print("큐가 비었습니다.")
        return None
    return queue[(front+1) % SIZE]

SIZE = int(input("큐 사이즈 입력: "))
queue = [None for _ in range(SIZE)]
front = 0
rear = 0

if __name__ == "__main__":
    while True:
        menu = input("삽입(i), 추출(e), 확인(v), 종료(x)")
        if menu == 'x' or menu == 'X':
            print("프로그램을 종료합니다.")
            break
        elif menu == 'i' or menu == 'I':
            en_queue(input("입력할 데이터: "))
            print(queue)
        elif menu == 'e' or menu == 'E':
            print(f"추출된 데이터: {de_queue()}")
            print(queue)
        elif menu == 'v' or menu == 'V':
            print(f"확인된 데이터 {peek()}")
            print(queue)
        else:
            print(f"{menu} 메뉴는 존재하지 않습니다. 메뉴의 기능을 이용해주세요.")
        print(front, rear)
            