class Graph():
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
        print(G1.graph[col][row], end=' ')
    print()
print()

