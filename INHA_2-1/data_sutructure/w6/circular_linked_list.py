## 순환 연결 리스트
## 클래스와 함수 선언 부분 ##
class Node() :
	def __init__ (self) :
		self.data = None
		self.link = None

def print_nodes(start) :
	current = start
	if current.link == None :
		return
	print(current.data, end = ' ')
	while current.link is not start:
		current = current.link
		print(current.data, end = ' ')
	print()

def insert_node(find_data, insert_data) :
	global head, current, pre

	if head.data == find_data :      # 첫 번째 노드 삽입
		node = Node()
		node.data = insert_data
		node.link = head # 새노드.링크 = 다현 
		last = head # 기존 코드에서 추가되는 코드
		# 기존 코드에서 추가되는 코드
		while last.link != head:
			last = last.link
		last.link = node

		head = node
		return

	current = head
	# while current.link is not None :    # 중간 노드 삽입
	while current.link != head:
		pre = current
		current = current.link
		if current.data == find_data :
			node = Node()
			node.data = insert_data
			node.link = current # 새노드.링크 = 사나
			pre.link = node # 쯔위.링크 = 새노드
			return
		
	node = Node()                   # 마지막 노드 삽입
	node.data = insert_data
	current.link = node
	
	# 기존 코드에서 추가
	node.link = head

def delete_node(delete_data) :
	global head, current, pre

	if head.data == delete_data :         # 첫 번째 노드 삭제
		current = head
		head = head.link
		last = head
		while last.link != current:
			last = last.link
		last.link = head
		print(f"# {current.data}, 첫 노드가 삭제돰. #")
		del(current)
		return

	
	current = head                          # 첫 번째  외 노드 삭제
	# while current.link != None :
	while current.link != head:
		pre = current
		current = current.link
		if current.data == delete_data :
			pre.link = current.link
			print(f"# {current.data}, 중간 노드가 삭제됨. #")
			del(current)
			return
	
	print("# 삭제된 노드가 없음. #")

def find_node(find_data) :
	global head, current, pre

	current = head
	if current.data == find_data :
		return current
	while current.link != head :
		current = current.link
		if current.data == find_data :
			return current
	return Node()	# 빈 노드 반환

## 전역 변수 선언 부분 ##
head, current, pre = None, None, None
data_array = ["다현", "정연", "쯔위", "사나", "지효"]

## 메인 코드 부분 ##
if __name__ == "__main__" :

	node = Node()		
	node.data = data_array[0]	# 첫 번째 노드
	head = node
	node.link = head

	for data in data_array[1:] :	# 두 번째 이후 노드
		pre = node
		node = Node()
		node.data = data
		pre.link = node
		node.link = head

	print_nodes(head)
	
	print(find_node("쯔위").data)
