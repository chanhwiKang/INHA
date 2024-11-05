class Node():
    def __init__(self):
        self.data = None
        self.link = None

def print_node(start):
    if head is None:
        print("이건 아닌듯")
        return
    print(start.data, end=" ")
    while start.link != head:
        start = start.link
        print(start.data, end=" ")
    print()

def insert_node(pos, val):
    global pre, head, current
    node = Node()
    node.data = val
    if head.data == pos:
        link = head
        while link.link != head:
            link = link.link
        link.link = node
        node.link = head
        head = node
    current = head
    while current.link != head:
        pre = current
        current = current.link
        if current.data == pos:
            pre.link = node
            node.link = current
            return
    current.link = node
    node.link = head

def delete_node(pos):
    global pre, current, head
    if head.data == pos:
        link = head
        while link.link != head:
            link = link.link
        head = head.link
        current = link.link
        link.link = head
        del current
        return
    
    current = head
    while current.link != head:
        pre = current
        current = current.link
        if current.data == pos:
            pre.link = current.link
            del current
            return

head, current, pre = None, None, None
data_array = ["다현", "정연", "쯔위", "사나", "지효"]

if __name__ == "__main__" :
    node = Node()
    node.data = data_array[0]
    node.link = node
    head = node

    for i in data_array[1:]:
        pre = node
        node = Node()
        node.data = i
        pre.link = node
        node.link = head
    print_node(head)
    insert_node("다현", "호두")
    print_node(head)
    delete_node("호두")
    print_node(head)