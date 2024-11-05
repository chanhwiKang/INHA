## 클래스와 함수 선언 부분 ##
class Node() :
	def __init__ (self) :
		self.data = None
		self.link = None

def print_nodes(start) :
	current = start
	if current is None :
		return
	print(current.data, end = ' ')
	while current.link is not None:
		current = current.link
		print(current.data, end = ' ')
	print()

def make_simple_linked_list(namePhone) :
	global head, current, pre

	node = Node()
	node.data = namePhone
	if head is None :			# 첫 번째 노드일 때
		head = node
		return

	if head.data[1] > namePhone[1] :	# 첫 번째 노드보다 작을 때
		node.link = head
		head = node
		return

	# 중간 노드로 삽입하는 경우
	current = head
	while current.link is not None :
		pre = current
		current = current.link
		if current.data[1] > namePhone[1]:
			pre.link = node
			node.link = current
			return

	# 삽입하는 노드가 가장 큰 경우
	current.link = node

## 전역 변수 선언 부분 ##
head, current, pre = None, None, None
data_array = [["지민", 175], ["정국", 178], ["뷔", 179], ["슈가", 173], ["진", 180]]

## 메인 코드 부분 ##
if __name__ == "__main__" :

	for data in data_array :
		make_simple_linked_list(data)

	print_nodes(head)
