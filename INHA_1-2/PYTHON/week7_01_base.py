def average(a):
    if type(a) is list:
        return sum(a)/len(a)
    elif type(a) is dict:
        # a = list(a.values())
        # return sum(a)/len(a)
        return sum(a.values()) / len(a)

s1 = [10,20,30,40]
s2 = {"kim": 10, "in": 20, "ha": 30}
print(average(s1))
print(average(s2))

def remove_value(src_list, target):
    # src_list = src_list[:]
    # while target in src_list:
    #     src_list.remove(target)
    # return src_list

    return [ i for i in src_list if target != i] # 위 코드와 같다

print(average("123"))
num = [1, 2, 3, 3, 3, 3, 3, 4]
new_num = remove_value(num, 3)
print(num) # [1, 2, 3, 3, 3, 3, 3, 4]
print(new_num) # [1, 2, 4]