class Node():
    def __init__(self) -> None:
        self.data = None
        self.left = None
        self.right = None

def preorder(node):
    if node is None:
        return
    print(f"{node.data}->", end=" ")
    preorder(node.left)
    preorder(node.right)
    
name_ary = ['블랙핑크', '레드벨벳', '마마무', '에이핑크',  '걸스데이', '트와이스' ]
root = Node()
root.data = name_ary[0]
for name in name_ary[1:]:
    node = Node()
    node.data = name

    current = root
    while(True):
        if node.data < current.data:
            if current.left is None:
                current.left = node
                break
            current = current.left
        else :
            if current.right is None:
                current.right = node
                break
            current = current.right

preorder(root)