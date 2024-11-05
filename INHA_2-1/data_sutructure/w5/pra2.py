class Node():
    def __init__(self):
        self.data = None
        self.link = None

def print_node(start):
    if start is None:
        return
    print(start.data, end=" ")
    while start.link is not None:
        start= start.link
        print(start.data, end=" ")
    print()

def insert_node(pos, val):
    global head, pre ,current
    node = Node()
    node.data = val
    if head.data == pos:
        node.link = head
        head = node
        return
    current = head
    while current.link is not None:
        pre = current
        current = current.link
        if current.data == pos:
            pre.link = node
            node.link = current
            return
    current.link = node
    
def delete_node(pos):
    global head, pre, current
    if head.data == pos:
        current = head
        head = head.link
        del current
        return
    
    current = head
    while current.link is not None:
        pre = current
        current = current.link
        if current.data == pos:
            pre.link = current.link
            del current
            return
    
datas=["0", "1", "2", "3", "4"]
pre, head, current = None, None, None
if __name__ == "__main__":
    node = Node()
    node.data = datas[0]
    head = node
    for i in datas[1:]:
        pre = node
        node = Node()
        pre.link = node
        node.data = i

    print_node(head)
    insert_node("2","a")
    print_node(head)
    delete_node("4")
    print_node(head)