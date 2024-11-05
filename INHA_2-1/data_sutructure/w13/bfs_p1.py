from collections import deque
class Graph():
    def __init__(self, size) -> None:
        self.size = size
        self.graph = [[0 for _ in range(size)] for _ in range(size)]

G1 = None
queue = []
visited_ary = []

def bfs(graph, start):
    visited_ary = list()
    queue = deque([start])
    while queue:
        current = queue.popleft()
        if current not in visited_ary:
            visited_ary.append(current)
            for vertex in range(graph.size):
                if graph[current][vertex] == 1 and graph[current][vertex] not in visited_ary:
                    queue.append(vertex)
    return visited_ary