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
# p. 256
for i, j in infos.items(): # items 메소드는 key와 value를 같이 내보내줌
    print(i, j) # 20230001 {'name': 'kim inha', 'age': 21}
# 20230002 {'name': 'Choi kom', 'age': 22, 'major': '컴정'}


print("-"*30)

# p. 226
for i in infos.values(): # infos의 value 출력. 아래와 같음
    print(i) # {'name': 'kim inha', 'age': 21}
# {'name': 'Choi kom', 'age': 22, 'major': '컴정'}
print("-"*30)

for i in infos: # infos의 key로 해당되는 value 출력
    print(infos[i])# {'name': 'kim inha', 'age': 21}
# {'name': 'Choi kom', 'age': 22, 'major': '컴정'}
print("-"*30)

for i in infos: # infos의 key를 출력
    print(i) # 20230001
# 20230001