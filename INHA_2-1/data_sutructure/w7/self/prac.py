import random
class Node():
    def __init__(self) -> None:
        self.data = None
        self.link = None

def print_node(start):
    global head, current, pre
    if start == None:
        return
    
    current = head
    while current.link != head:
        print(current.data, end=" ")
        current = current.link
    print()

def data_check():
    global pre, current, head
    even, odd = 0, 0
    if head is None:
        return False
    
    current = head
    while True:
        if current.data % 2 == 0:
            even += 1
        else :
            odd += 1
        
        if current.link == head:
            return even, odd
        current = current.link

def change_data(even, odd):
    global head, current

    current = head
    while True:
        if even > odd and current.data %2 == 0:
            current.data *= -1
        elif even < odd and current.data %2 == 1:
            current.data *= -1
        if current.link == head:
            break
        current = current.link

pre, current, head = None, None, None
data_array = [random.randint(1, 100) for _ in range(7)]
if __name__ == "__main__":
    node = Node()
    node.data = data_array[0]
    head = node
    node.link = head

    for i in data_array[1:]:
        pre = node
        node = Node()
        node.data = i
        pre.link = node
        node.link = head

    print_node(head)
    even_cnt, odd_cnt = data_check()
    change_data(even_cnt, odd_cnt)
    print_node(head)