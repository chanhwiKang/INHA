def en_queue(data):
    global rear
    if is_queue_full():
        print("queue is full")
        return
    rear += 1
    queue[rear] = data

def de_queue():
    global queue, rear, front
    if is_queue_empty():
        print("queue is empty")
        return
    front += 1
    tmp = queue[front]
    queue[front] = None
    return tmp

def is_queue_full():
    global rear, front, queue
    if rear != SIZE-1:
        return False
    elif rear == SIZE-1 and front == -1:
        return True
    else:
        for i in range(front+1, SIZE):
            queue[i-1] = queue[i]
            queue[i] = None
        front -= 1
        rear -= 1
        return False

def is_queue_empty():
    global rear, front
    if rear == front:
        return True
    return False

SIZE = int(input("input queue size -> "))
queue = [None for _ in range(SIZE)]
front = -1
rear = -1

if __name__ == "__main__":
    while True:
        menu = input("삽입(i), 추출(e), 확인(v), 종료(x)")
        if menu == 'x' or menu == 'X':
            print("프로그램을 종료합니다.")
            break
        elif menu == 'i' or menu == 'I':
            en_queue(input("입력할 데이터: "))
            print(queue)
        # elif menu == 'e' or menu == 'E':
        #     print(f"추출된 데이터: {de_queue()}")
        #     print(queue)
        # elif menu == 'v' or menu == 'V':
        #     print(f"확인된 데이터 {peek()}")
        #     print(queue)
        else:
            print(f"{menu} 메뉴는 존재하지 않습니다. 메뉴의 기능을 이용해주세요.")
            