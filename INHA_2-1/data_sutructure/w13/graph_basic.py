class Graph:
    def __init__(self, size) -> None:
        self.size = size
        self.graph = [[0 for _ in range(size)] for _ in range(size)]

# 무방향 그래프
G1 = Graph(4)
G1.graph[0][1] = 1; G1.graph[0][2] = 1; G1.graph[0][3] = 1;
G1.graph[1][0] = 1; G1.graph[1][2] = 1; 
G1.graph[2][0] = 1; G1.graph[2][1] = 1; G1.graph[2][3] = 1;
G1.graph[3][0] = 1; G1.graph[3][2] = 1;
for row in range(G1.size):
    for col in range(G1.size):
        print(G1.graph[row][col], end=' ')
    print()
print()

# 방향 그래프
G3 = Graph(4)
G3.graph[0][1] = 1; G3.graph[0][2] = 1; 
G3.graph[3][0] = 1; G3.graph[3][2] = 1;
for row in range(G3.size):
    for col in range(G3.size):
        print(G3.graph[row][col], end=' ')
    print()
print()

# 연습
G0 = Graph(4)
G0.graph[0][3] = 1; G0.graph[3][0] = 1; 
G0.graph[1][2] = 1; G0.graph[2][1] = 1; 
G0.graph[1][3] = 1; G0.graph[3][1] = 1; 
for row in range(G0.size):
    for col in range(G0.size):
        print(G0.graph[row][col], end=' ')
    print()