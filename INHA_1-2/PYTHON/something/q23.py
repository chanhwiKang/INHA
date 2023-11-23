def search_index(lst, target):
    tmp_lst = []
    for i, j in enumerate(lst):
        if j == target:
            tmp_lst.append(i)
    return tmp_lst

print(search_index([35, 28, 30, 29, 30], 30))
print(search_index([35, 28, 30, 29, 30], 31))