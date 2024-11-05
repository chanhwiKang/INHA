class Node():
    def __init__(self) -> None:
        self.data = None
        self.link = None

def print_node(start):
    if start.data == None:
        print("값이 없습니다.")
        return
    
    current = start
    print(current.data, end="")
    while current.link is not None:
        current = current.link
        print(current.data, end="")
    print()
def insert_node(pos, val):
    global pre, head, current
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
        
def delet_node(val):
    global pre, current, head
    if head.data == val:
        current = head
        head = head.link
        del current
        return
    
    current = head
    while current.link is not None:
        pre = current
        current = current.link
        if current.data == val:
            pre.link = current.link
            del current
            return
        
def find_node(val):
    global head, current, pre
    if head.data == val:
        return head
    
    current = head
    while current.link is not None:
        pre = current
        current = current.link
        if current.data == val:
            return current
        
    return Node()

arr = ["0", "1", "2", "3", "4"]
pre, head, current = None, None, None
if __name__ == "__main__":
    node = Node();
    node.data = arr[0]
    head = node
    current = head
    for i in arr[1:]:
        pre = current
        node = Node()
        node.data = i
        pre.link = node
        current = node

    print_node(head)
    insert_node("7", "a")
    print_node(head)
    delet_node("4")
    print_node(head)
    print(find_node("0").data)
    print(find_node("2").data)
    print(find_node("zs").data)