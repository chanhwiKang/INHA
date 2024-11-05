class Node():
    def __init__(self) -> None:
        self.left = None
        self.data = None
        self.right = None

def pre_order(node):
    if node.data is None:
        return
    print(node.data)
    pre_order(node.left)
    pre_order(node.right)


## 전역 변수 선언 부분 ##
root = None
name_ary = ['블랙핑크', '레드벨벳', '마마무', '에이핑크',  '걸스데이', '트와이스' ]

node = Node()
node.data = name_ary[0]
root = node

for name in name_ary[1:]:
    node = Node()
    node.data = name

    current = root
    while True:
        if current.data < name:
            if current.left is None:
                current.left = node
                break
            current = current.left
        else :
            if current.right is None:
                current.right = node
                break
            current = current.right
        


