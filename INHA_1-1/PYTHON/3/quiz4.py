from random import *

lst = range(1, 21)
print(type(lst)) # type = range
lst = list(lst)
print(type(lst)) # type = list로 변경 완료, lst = [1,2,...19,20]

shuffle(lst)
winners = sample(lst, 4)

#chicken = sample(lst, 1)
#lst.remove(chicken)

#coffe = sample(lst, 3)

print("-- 당첨자 발표 --")
print("치킨 당첨자 : {}" .format(winners[0]))
print("커피 당첨자 : {}" .format(winners[1:]))
print("-- 축하합니다 --")
