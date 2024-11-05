def en_queue(data):
    global rear, queue
    if is_queue_full():
        return
    rear = (rear + 1) % SIZE
    queue[rear] = data

def de_queue():
    global front, queue
    if is_queue_empty():
        return
    front = (front + 1) % SIZE
    tmp = queue[front]
    queue[front]= None
    return tmp

def peek():
    global front, queue
    if is_queue_empty():
        return
    return queue[(front + 1) % SIZE]
    

def is_queue_full():
    global rear, front
    if (rear+1) % SIZE == front:
        return True
    return False

def is_queue_empty():
    global rear, front
    if rear == front:
        return True
    return False

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
            