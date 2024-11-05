class Node():
    def __init__(self) -> None:
        self.data = None
        self.link = None

def print_link(start):
    if start is None:
        return
    while start.link is not None:
        print(start.data[0], end=" ")
        start = start.link
    print(start.data[0])

def fast_link(mem_list):
    global head, pre, current
    node = Node()
    node.data = mem_list
    if head == None:
        head = node
        return
    
    if head.data[1] > node.data[1]:
        node.link = head
        head = node
        return
    
    current = head
    while current.link is not None:
        pre = current
        current = current.link
        if current.data[1] > node.data[1]:
            pre.link = node
            node.link = current
            return
        
    current.link = node


member = [
    ["찬휘", 3],
    ["찬영", 2],
    ["호두", 7],
    ["엄마", 1],
    ["나나", 5]
]
head, pre, current = None, None, None
if __name__ == "__main__":
    for mem in member:
        fast_link(mem)

    print_link(head)