# 왼쪽 서브트리는 루트 노드보다 작은 값을 가진다.
# 오른쪽 서브트리는 루트 노드보다 큰 값을 가진다.
# 모든 노드 값은 중복되지 않는다. 중복된 값은 저장할 수 없다.
# 시간 복잡도 -> 로그시간.
import random

class Tree_node() :
	def __init__ (self) :
		self.left = None
		self.data = None
		self.right = None

def preorder(node): # 전위 순회
    if node is None:
        return
    print(f"{node.data}->", end=" ")
    preorder(node.left)
    preorder(node.right)
		
def inorder(node): # 중위 순회
    if node is None:
        return
    inorder(node.left)
    print(f"{node.data}->", end=" ")
    inorder(node.right)

def postorder(node):# 후위 순회
    if node is None:
        return
    postorder(node.left)
    postorder(node.right)
    print(f"{node.data}->", end=" ")
	
## 전역 변수 선언 부분 ##
root_book, root_auth = None, None
book_ary = [ ['어린왕자', '쌩떽쥐베리'],['이방인', '까뮈'], ['부활', '톨스토이'],
		   ['신곡', '단테'], ['돈키호테', '세브반테스'], ['동물농장', '조지오웰'],
		   ['데미안','헤르만헤세'], ['파우스트', '괴테'], ['대지', '펄벅'] ]
random.shuffle(book_ary)
## 메인 코드 부분 ##

### 책 이름 트리 ###
node = Tree_node()
node.data = book_ary[0][0]
root_book = node

for book in book_ary[1:] : #[이방인, 까뮈] 
	name = book[0] # 이방인
	node = Tree_node()
	node.data = name

	current = root_book
	while True :
		if name < current.data :
			if current.left is None :
				current.left = node
				break
			current = current.left
		else :
			if current.right is None :
				current.right = node
				break
			current = current.right


print("책 이름 트리 구성 완료!")

### 작가 이름 트리 ###
node = Tree_node()
node.data = book_ary[0][1]
root_auth = node

for book in book_ary[1:] :
	name = book[1]
	node = Tree_node()
	node.data = name

	current = root_auth
	while True :
		if name < current.data :
			if current.left is None :
				current.left = node
				break
			current = current.left
		else :
			if current.right is None :
				current.right = node
				break
			current = current.right


print("작가 이름 트리 구성 완료!")

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
