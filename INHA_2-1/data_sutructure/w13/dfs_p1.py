class Graph():
    def __init__(self, size) -> None:
        self.size = size
        self.graph = [[0 for _ in range(size) for _ in range(size)]]

def dsf_all_node(graph, start):
    visited_ary = list()
    stack = [start]
    while stack:
        current = stack.pop()
        if current not in visited_ary:
            visited_ary.append(current)
            for vertex in range(graph.size -1, -1, -1):
                if graph.graph[current][vertex] == 1 and graph.graph[current][vertex] not in visited_ary:
                    stack.append(vertex)
        print(stack, visited_ary)

G1 = None
stack = []
visited_ary = []

G1 = Graph(5)
G1.graph[0][2] = 1; G1.graph[0][3] = 1
G1.graph[1][2] = 1; G1.graph[1][4] = 1
G1.graph[2][0] = 1; G1.graph[2][1] = 1; G1.graph[2][3] = 1
G1.graph[3][0] = 1; G1.graph[3][2] = 1
G1.graph[4][1] = 1