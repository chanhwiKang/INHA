class Node():
    def __init__(self) -> None:
        self.data = None
        self.link = None

def circular_linked_list(value):
    global pre, head, current
    node = Node()
    node.data = value
    if head is None:
        node.link = node
        head = node
        return
    
    current = head
    while current.link != head:
        pre = current
        current = current.link
    current.link = node
    node.link = head

def print_linked_list(start):
    if start is None:
        print("아무것도 없다맨이야~")
    while start.link is not head:
        print(start.data, end="")
        start = start.link
    print(start.data)

def insert_link(value, pos):
    global pre, head, current
    node = Node();
    node.data = value
    if head.data == pos:
        node.link = head
        last = head
        while last.link != head:
            last = last.link
        last.link = node
        head = node
        return
    
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

def delete_link(value):
    global pre, current, head
    if head.data == value:
        last = head
        while last.link is not head:
            last = last.link
        last.link = head.link
        del head
        head = last.link
        return
    
    current = head
    while current.link != head:
        pre = current
        current = current.link
        if current.data == value:
            pre.link = current.link
            del current
            return

def find_link(value):
    global head, current
    i=2
    if head.data == value:
        print(f"1번 자리에 있다맨~")
        return
    current = head
    while current.link != head:
        current = current.link
        if current.data == value:
            print(f"{i}번 자리에 있다맨~")
            return
        i = i + 1;
    print("얘!, 여기 없단다!")

name = ["1", "4", "e", "2", "z"]
pre, head, current = None, None, None
if __name__ == "__main__":
    # make circular linked list in def
    # for data in name:
    #     circular_linked_list(data)

    # make circule linked list in main
    node = Node()
    node.data = name[0]
    head = node
    head.link = head

    for data in name[1:]:
        pre = node
        node = Node()
        node.data = data
        node.link = head
        pre.link = node

    print_linked_list(head)
    insert_link("R", "1")
    print_linked_list(head)
    insert_link("Z", "")
    print_linked_list(head)
    delete_link("R")
    print_linked_list(head)
    delete_link("2")
    print_linked_list(head)
    delete_link("Z")
    print_linked_list(head)
    find_link("z")