def add_list(lstA, lstB):
    whoIsShort = ""
    whatYouWant = []
    lenListA = len(lstA)
    lenListB = len(lstB)
    if lenListA < lenListB:
        whoIsShort = lenListA
    else:
        whoIsShort = lenListB

    for i in range(whoIsShort):
        whatYouWant.append(lstA[i] + lstB[i])
    if whoIsShort == lenListA:
        for i in range(lenListA if whoIsShort == lenListA else lenListB, \
                       lenListB if whoIsShort == lenListB else lenListA):
            whatYouWant.append(lstB[i] if whoIsShort == lenListA else lstA[i])

    return whatYouWant


print(add_list([1, 2, 3, 4], [1, 2]))
print(add_list([0, 1], [1, 2, 6, 7, 8]))