class Liked_list:
    def __init__(self) -> None:
        self.data = None
        self.link = None


def print_link(current):
    if (current.data is None): return
    print(current.data, end="")
    while(current.link is not None):
        current = current.link
        print(current.data, end="")


def insert_link(new_mem, pos):
    global pre, head, current
    # 맨 앞 삽입
    if head.data == pos:
        node = Liked_list()
        node.data = new_mem
        node.link = head
        head = node
        return
    
    current = head
    while current.link is not None:
        pre = current
        current = current.link
        if current.data == pos:
            node = Liked_list()
            node.data = new_mem
            node.link = current
            pre.link = node
            return
        
    node = Liked_list()
    node.data = new_mem
    current.link = node
    

def delete_link(del_mem):
    global pre, current, head
    if head.data == del_mem:
        current = head
        head = head.link
        del current
        return
    
    
arr = ["a", "b", "c", "d", "e"]
pre, head, current = None, None, None
if __name__ == "__main__":
    head = Liked_list()
    head.data = arr[0]
    node = head

    for data in arr[1:]:
        pre = node
        node = Liked_list()
        node.data = data
        pre.link = node
    
    # print_link(head)
    # print()
    insert_link("1", "a")
    print_link(head)
    print()
    insert_link("3", "c")
    insert_link("*", "eaa")
    print_link(head)
    print()

    delete_link("3")
    print_link(head)