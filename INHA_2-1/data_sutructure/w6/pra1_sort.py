class Node():
    def __init__(self):
        self.data = None
        self.link = None

def make_link(name_height):
    global pre, current, head

    node = Node()
    node.data = name_height
    if head is None:
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

def print_link(current):
    if current.data is None:
        print("몬가 이상함")
        return
    print(current.data, end="")
    while current.link is not None:
        current = current.link
        print(current.data, end="")
    print()

head, current, pre = None, None, None
data_array = [["지민", 175], ["정국", 178], ["뷔", 179], ["슈가", 173], ["진", 180]]
if __name__ == "__main__":
    for i in data_array:
        make_link(i)
    print_link(head)