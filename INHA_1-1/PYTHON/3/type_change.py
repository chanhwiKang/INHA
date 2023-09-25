# 자료구조 변경
menu = {"cofee", "milk", "juice"}
print(menu) #{'milk', 'cofee', 'juice'}
print(menu, type(menu)) #{'milk', 'cofee', 'juice'} <class 'set'>

menu = list(menu)
print(menu, type(menu)) #['cofee', 'milk', 'juice'] <class 'list'>

menu = tuple(menu)
print(menu, type(menu)) #('juice', 'cofee', 'milk') <class 'tuple'>

menu = set(menu)
print(menu, type(menu)) #{'milk', 'juice', 'cofee'} <class 'set'>
