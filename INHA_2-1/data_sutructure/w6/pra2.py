class Node():
    def __init__(self) -> None:
        self.data = None
        self.link = None

def sort_linked_list(value):
    global pre, head, current
    
    node = Node()
    node.data = value
    if head is None:
        head = node
        return
    
    if head.data > node.data:
        node.link = head
        head = node
        return

    current = head
    while current.link is not None:
        pre = current
        current = current.link
        if current.data > node.data:
            pre.link = node
            node.link = current
            return
        
    current.link = node

def fast_linked_list(value):
    global pre, head, current
    node = Node()
    node.data = value
    if head is None:
        head = node
        return
    
    current = head
    while current.link is not None:
        current = current.link
    current.link = node

def print_link(start):
    while start.link is not None:
        print(start.data, end="")
        start = start.link
    print(start.data)

def insert_link(value, pos):
    global pre, head, current
    node = Node()
    node.data = value
    if head.data == pos:
        node.link = head
        head = node
        return
    
    current = head
    while current.data is not None:
        pre = current
        current = current.link
        if current.data == pos:
            pre.link = node
            node.link = current
            return
    
    current.link = node

def delet_link(value):
    global pre, head, pre
    if head.data == value:
        node = head
        head = head.link
        del node
        return
    
    current = head
    while current.link is not None:
        pre = current
        current = current.link
        if current.data == value:
            pre.link = current.link
            del current
            return
    
    # if current.data == value:
    #     del current
    #     return
    
    print(f"{value}는 없다맨이야")
    
name = ["4", "1", "7", "3", "2"]
head, pre, current = None, None, None
if __name__ == "__main__":
    for data in name:
        fast_linked_list(data)

    print_link(head)
    insert_link("e", "7")
    print_link(head)
    delet_link("2")
    print_link(head)
