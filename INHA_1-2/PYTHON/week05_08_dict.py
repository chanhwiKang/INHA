print("-"*20)
infos = {
    "20230001":{
        "name": "kim inha",
        "age": 21
        },
    "20230002":{
        "name": "Choi kom", 
        "age": 22, 
        "major": "컴정"
        }
}

print(infos["20230002"]["major"])
print("-"*20)
infos = {
    1: ["kim inha", 21],
    2: ["Choi kom", 22]
}

print(infos[2][1]) # key2 value 중, 1번 인덱스 출력
print(infos[2][0].split(" ")[0]) # key2 value중 [0]번 인덱스를 split후 [0]번 인덱스 출력
print("-"*20)
info_a = {
    "name": "Kima inha",
    "age": 21
}
info_b = {
    "name": "Choi com",
    "age": 22
}
# print(info_a[0]) # key err
# print(info_a[name]) # name err
print(info_a["name"])
print(info_b["age"])
print()
test_dict = {
    "one": 1,
    #"one": 2, value는 중복 o, key는 중복 x
    "two": 2,
    "three": 3
}
print(test_dict)

test_dict = dict()
print(test_dict, type(test_dict))

test_dict = {}
print(test_dict, type(test_dict))