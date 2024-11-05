import random

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
		
def inorder(node):
    if node is None:
        return
    inorder(node.left)
    print(f"{node.data}->", end=" ")
    inorder(node.right)

def postorder(node):
    if node is None:
        return
    postorder(node.left)
    postorder(node.right)
    print(f"{node.data}->", end=" ")

root_book, root_auth = None, None
book_ary = [ ['어린왕자', '쌩떽쥐베리'],['이방인', '까뮈'], ['부활', '톨스토이'],
		   ['신곡', '단테'], ['돈키호테', '세브반테스'], ['동물농장', '조지오웰'],
		   ['데미안','헤르만헤세'], ['파우스트', '괴테'], ['대지', '펄벅'] ]
random.shuffle(book_ary)

# 책 이름
node = Node()
node.data = book_ary[0][0]
root_book = node
for i in book_ary[1:]:
    node = Node()
    node.data = i[0]
    
    current = root_book
    while True:
        if current.data > node.data:
            if current.left is None:
                current.left = node
                break
            else:
                current = current.left
        else:
            if current.right is None:
                current.right = node
                break
            else:
                current = current.right

node = Node()
node.data = book_ary[0][1]
root_auth = node
for i in book_ary[1:]:
    node = Node()
    node.data = i[1]
    
    current = root_auth
    while True:
        if current.data > node.data:
            if current.left is None:
                current.left = node
                break
            else:
                current = current.left
        else:
            if current.right is None:
                current.right = node
                break
            else:
                current = current.right

## 책 이름 및 작가 이름 검색 ##
while(True):
	book_or_auth = int(input('책검색(1), 작가검색(2)-->'))
	find_name = input('검색할 책 또는 작가-->')

	if book_or_auth == 1 :
		root = root_book
		break
	elif book_or_auth == 2 :
		root = root_auth
		break
	elif book_or_auth == 3 :
		break
	else :
		print(f"입력 값 {book_or_auth}이(가) 옳바르지 않습니다.")

current = root
while True:
	if find_name == current.data :
		print(find_name, '을(를) 찾음.')
		findYN = True
		break
	elif find_name < current.data :
		if current.left is None :
			print(find_name, '이(가) 목록에 없음')
			break
		current = current.left
	else:
		if current.right is None :
			print(find_name, '이(가) 목록에 없음')
			break
		current = current.right
