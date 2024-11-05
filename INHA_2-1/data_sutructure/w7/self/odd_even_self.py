import random
class Node():
    def __init__(self) -> None:
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

def odd_even_check():
    # global head, current
    # even, odd = 0, 0
    # current = head
    # while True:
    #     if current.data % 2 == 0:
    #         even = even + 1
    #     else :
    #         odd = odd + 1
    #     if current.link == head:
    #         break
    #     current = current.link
    # print(f"짝수의 갯수는 {even}, 홀수의 갯수는 {odd}")
    # if odd > even:
    #     change_data(True)
    # else:
    #     change_data(False)
    global head, current
    plus, minus = 0, 0
    current = head
    while True:
        if current.data > 0:
            plus = plus + 1
        elif current.data < 0:
            minus = minus + 1
        
        if current.link == head:
            break
        current = current.link
    print(f"양수 {plus}, 음수 {minus}, 0의 갯수 {7-plus-minus}")
    change_data()

# def change_data(is_odd):
    # global current, head
    # current = head
    # while True:
    #     if is_odd and current.data % 2 == 1:
    #         current.data = current.data * -1
    #     elif not is_odd and current.data % 2 == 0:
    #         current.data = current.data * -1
    #     if current.link == head:
    #         break
    #     current = current.link
def change_data(): 
    global current, head
    current = head
    while True:
        current.data = current.data * -1
        if current.link == head:
            break
        current = current.link

        
# data_array = [random.randint(1,100) for _ in range(7)]
data_array = [random.randint(-100, 100) for _ in range(7)]
head, current, pre = None, None, None
if __name__ == "__main__":
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
    odd_even_check()
    print_nodes(head)
    