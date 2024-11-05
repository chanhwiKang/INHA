class Graph():
    def __init__(self, size) -> None:
        self.SIZE = size
        self.graph = [[0 for _ in range(size)] for _ in range(size)]

def find_vertex(g, find_vtx):
    stack = []
    visited_ary = []

    current = 0
    stack.append[current]
    visited_ary.append[current]

    while len(stack) != 0:
        next = None
        for vertex in len(gSize):
            if g.graph[current][vertex] != 0:
                if vertex not in visited_ary:
                    next = vertex
                    break
                else: 
                    pass

    if next is not None:
        current = next
        stack.append(current)
        visited_ary(current)
    else : 
        current = stack.pop()
    

## 전역 변수 선언 부분 ##
G1 = None
name_ary = ['춘천', '서울', '속초', '대전', '광주', '부산' ]
춘천, 서울, 속초, 대전, 광주, 부산 = 0, 1, 2, 3, 4, 5


## 메인 코드 부분 ##
gSize = 6
G1 = Graph(gSize)
G1.graph[춘천][서울] = 10; G1.graph[춘천][속초] = 15
G1.graph[서울][춘천] = 10; G1.graph[서울][속초] = 40; G1.graph[서울][대전] = 11; G1.graph[서울][광주] = 50
G1.graph[속초][춘천] = 15; G1.graph[속초][서울] = 40; G1.graph[속초][대전] = 12
G1.graph[대전][서울] = 11; G1.graph[대전][속초] = 12; G1.graph[대전][광주] = 20; G1.graph[대전][부산] = 30
G1.graph[광주][서울] = 50; G1.graph[광주][대전] = 20; G1.graph[광주][부산] = 25
G1.graph[부산][대전] = 30; G1.graph[부산][광주] = 25

edge_ary = []
for i in range(gSize):
    for j in range(gSize):
        if G1.graph[i][j] != 0:
            edge_ary.append([G1.graph[i][j], i, j])

edge_ary = sorted(edge_ary, key=lambda x: x[0], reverse=True)

new_ary = []
for i in range(0, len(edge_ary), 2):
    new_ary.append(edge_ary[i])

index = 0
while len(new_ary) > gSize-1:
    start = new_ary[index][1]
    end = new_ary[index][2]
    save_cost = new_ary[index][0]

    G1.graph[start][end] = 0
    G1.graph[end][start] = 0

    startYN = find_vertex(G1, start)
    endYN = find_vertex(G1, end)

    if startYN and endYN:
        del new_ary[index]
    else:
        G1.graph[start][end] = save_cost
        G1.graph[end][start] = save_cost
        index += 1

