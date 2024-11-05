import random
class Node():
    def __init__(self):
        self.data = None
        self.link = None

def print_node(start):
    if start is None:
        return
    print(start.data, end=" ")
    while start.link != head:
        start = start.link
        print(start.data, end=" ")
    print()

def data_check():
    global pre, head, current
    even, odd = 0, 0
    current = head
    while True:
        if current.data % 2 == 0:
            even = even + 1
        else:
            odd = odd + 1
        if current.link == head:
            return even, odd
        current = current.link

def change_data(even, odd):
    global pre, head, current
    current = head
    while True:
        if even > odd and current.data % 2 == 1:
            current.data *= -1
        elif even < odd and current.data % 2 == 0:
            current.data *= -1
        if current.link == head:
            return
        current = current.link

datas = [random.randint(1, 100) for _ in range(7)]
pre, head, current = None, None, None
if __name__ == "__main__" :
    node = Node()
    node.data = datas[0]
    head = node
    node.link = node

    for i in datas[1:]:
        pre = node
        node = Node()
        node.data = i
        pre.link = node
        node.link = head

    print_node(head)
    even, odd = data_check()
    change_data(even, odd)
    print_node(head)