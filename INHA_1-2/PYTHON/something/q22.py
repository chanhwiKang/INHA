def merge_list(lstA, lstB):
    for i in lstB:
        if i not in lstA:
            lstA.append(i)
    lstA.sort()
    return lstA

print(merge_list([1, 2, 3, 4], [1, 2, 5]))
print(merge_list([0, 1, 10], [1, 2, 6, 7, 8]))