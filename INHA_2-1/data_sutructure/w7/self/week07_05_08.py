import random


class Node:
    def __init__(self):
        self.data = None
        self.link = None


def print_nodes(start):  # !
    current = start  # !
    if current is None:
        return
    print(current.data, end=' ')
    while current.link != start:  # !
        current = current.link
        print(current.data, end=' ')
    print()


def count_odd_even():
    global head, current, pre

    odd, even = 0, 0
    if head is None:
        return False

    current = head
    while True:
        if current.data % 2 == 0:
            even = even + 1
        else:
            odd += 1
        if current.link == head:
            break
        current = current.link

    return odd, even


def make_minus_number(odd, even):
    if odd > even:
        remainder = 1
    else:
        remainder = 0

    current = head
    while True:
        if current.data % 2 == remainder:
            current.data *= -1
        if current.link == head:
            break
        current = current.link


head, current, pre = None, None, None

if __name__ == "__main__":
    # data_array = list()
    # for _ in range(7):
    #     data_array.append(random.randint(1, 100))
    data_array = [random.randint(1, 100) for _ in range(7)]

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

    odd_count, even_count = count_odd_even()
    print(f'홀수 : {odd_count}\t짝수 : {even_count}')

    make_minus_number(odd_count, even_count)
    print_nodes(head)

