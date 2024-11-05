## 함수 선언 부분 ##
class Graph() :
	def __init__ (self, size) :
		self.size = size
		self.graph = [[0 for _ in range(size)] for _ in range(size)]

def print_graph(g) :
	print('    ', end = ' ')
	for v in range(g.size) : # 표 맨 위에 이름 쭉 출력
		print(f"{name_ary[v]}", end = ' ')
	print()
	for row in range(g.size) :
		print(name_ary[row], end = '') # 표 맨 이름 한번 출력
		for col in range(g.size) :
			print(f"{g.graph[row][col]:>4}", end= ' ')
		print()
	print()


## 전역 변수 선언 부분 ##
G1 = None
name_ary = ['문별', '솔라', '휘인', '쯔위', '선미', '화사']
문별, 솔라, 휘인, 쯔위, 선미, 화사 = 0, 1, 2, 3, 4, 5


## 메인 코드 부분 ##
g_size = 6
G1 = Graph(g_size)
G1.graph[문별][솔라] = 1; G1.graph[문별][휘인] = 1
G1.graph[솔라][문별] = 1; G1.graph[솔라][쯔위] = 1
G1.graph[휘인][문별] = 1; G1.graph[휘인][쯔위] = 1
G1.graph[쯔위][솔라] = 1; G1.graph[쯔위][휘인] = 1; G1.graph[쯔위][선미] = 1; G1.graph[쯔위][화사] = 1
G1.graph[선미][쯔위] = 1; G1.graph[선미][화사] = 1
G1.graph[화사][쯔위] = 1; G1.graph[화사][선미] = 1

print('## G1 무방향 그래프 ##')
print_graph(G1)
