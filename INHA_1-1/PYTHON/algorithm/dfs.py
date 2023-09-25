lst = [[0] * 13 for i in range(13)]

lst[0][1] = lst[0][7] = 1
lst[1][2] = lst[1][5] = 1
lst[2][3] = lst[2][4] = 1
lst[5][6] = lst[7][8] = 1
lst[7][9] = lst[9][10] = 1
lst[9][11] = lst[9][12] = 1

def dfs(now):
    for nxt in range(13):
        if lst[now][nxt]:
            dfs(nxt)

dfs(0)