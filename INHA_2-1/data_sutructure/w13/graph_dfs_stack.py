## 클래스 및 함수 선언 부분 ##
class Graph :
	def __init__ (self, size) :
		self.SIZE = size
		self.graph = [[0 for _ in range(size)] for _ in range(size)]

## 전역 변수 선언 부분 ##
G1 = None
stack = []
visited_ary = []		# 방문한 정점

## 메인 코드 부분 ##
G1 = Graph(5)
G1.graph[0][2] = 1; G1.graph[0][3] = 1
G1.graph[1][2] = 1; G1.graph[1][4] = 1
G1.graph[2][0] = 1; G1.graph[2][1] = 1; G1.graph[2][3] = 1
G1.graph[3][0] = 1; G1.graph[3][2] = 1
G1.graph[4][1] = 1

print('## G1 무방향 그래프 ##')
for row in range(G1.SIZE) :
	for col in range(G1.SIZE) :
		print(G1.graph[row][col], end = ' ')
	print()

def dfs_all_node(graph, start):
	visited_ary = list()
	stack = [start]
	while stack:
		current = stack.pop() # node를 스택에서 꺼냄 
		if current not in visited_ary:
			visited_ary.append(current)
			for vertex in range(graph.SIZE -1, -1, -1):
				if graph.graph[current][vertex] == 1 and vertex not in visited_ary:
					stack.append(vertex)
		print(stack, visited_ary)
	return visited_ary
	
visited_ary = dfs_all_node(G1, start=2) # C부터 시작 

print('방문 순서 -->', end='')
for i in visited_ary :
	print(chr(ord('A')+i), end='   ')
