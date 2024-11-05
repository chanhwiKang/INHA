import random


class Node:
    def __init__(self):
        self.data = None
        self.link = None


def print_nodes(start):
    current = start
    if current is None:
        return
    print(current.data, end=' ')
    while current.link != start:
        current = current.link
        print(current.data, end=' ')
    print()


def count_plus_minus():
    """
    각 노드의 data 값을 체크하여 음수, 양수, 0의 갯수를 리턴하는 함수
    :return: 음수, 양수, 0의 갯수
    """
    global head, current, pre

    plus, minus, zero = 0, 0, 0
    if head is None:
        return False

    current = head
    while True:
        if current.data == 0:
            zero = zero + 1
        elif current.data < 0:
            minus += 1
        else:
            plus += 1

        if current.link == head:
            break
        current = current.link

    return plus, minus, zero


def make_toggle_number():
    """
    각 노드의 data값을 반전(음수는 양수, 양수는 음수로)
    :return:
    """
    current = head
    while True:
        current.data = current.data * -1
        if current.link == head:
            break
        current = current.link


head, current, pre = None, None, None

if __name__ == "__main__":
    # data_array = list()
    # for _ in range(7):
    #     data_array.append(random.randint(-100, 100))
    data_array = [random.randint(-10, 10) for _ in range(7)]

    node = Node()
    node.data = data_array[0]
    head = node
    node.link = head

    for data in data_array[1:]:
        pre = node
        node = Node()
        node.data = data
        pre.link = node
        node.link = head

    print_nodes(head)


    plus_count, minus_count, zero_count = count_plus_minus()
    print(f'양수 : {plus_count}\n음수 : {minus_count}\n영 : {zero_count}')

    make_toggle_number()
    print_nodes(head)

