# 왼쪽 서브트리는 루트 노드보다 작은 값을 가진다.
# 오른쪽 서브트리는 루트 노드보다 큰 값을 가진다.
# 모든 노드 값은 중복되지 않는다. 중복된 값은 저장할 수 없다.
# 시간 복잡도 -> 로그시간.

class Tree_node() :
	def __init__ (self) :
		self.left = None
		self.data = None
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
	
## 전역 변수 선언 부분 ##
root = None
name_ary = ['블랙핑크', '레드벨벳', '마마무', '에이핑크',  '걸스데이', '트와이스' ]

## 메인 코드 부분 ##
node = Tree_node()
node.data = name_ary[0]
root = node

for name in name_ary[1:] :

	node = Tree_node()
	node.data = name

	current = root
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

print("이진 탐색 트리 구성 완료!")

delete_name = input("삭제할 그룹 입력: ")
current = root
parent = None
while True:
	if delete_name == current.data :
		
		if current.left is None and current.right is None : #leaf node 삭제시
			if parent.left == current :
				parent.left = None
			else :
				parent.right = None
			del current

		elif current.left is not None and current.right is None : # 왼쪽에 자식이 있을 때
			if parent.left == current :
				parent.left = current.left
			else :
				parent.right = current.left
			del current

		elif current.left is None and current.right is not None : # 오른쪽에 자식이 있을 때
			if parent.left == current:
				parent.left = current.right
			else:
				parent.right = current.right
			del current

		print(f'{delete_name}이(가) 삭제됨.')
		break
	elif delete_name < current.data :
		if current.left is None :
			print(f'{delete_name}이(가) 트리에 없음')
			break
		parent = current
		current = current.left
	else:
		if current.right is None :
			print(f'{delete_name}이(가) 트리에 없음')
			break
		parent = current
		current = current.right