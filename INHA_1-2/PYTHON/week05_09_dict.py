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

infos["20230003"] = {} # key 20230003의 빈 value 추가
infos["20230003"]["name"] = "yi com"
infos["20230003"]["major"] = "컴시"
infos["20230004"] = {
    "name": "wang jeonja",
    "major": "전자"
}

print(infos)

test_dict = {1: "uno", 2: "two", 3: "three"}
print(test_dict) # {1: 'uno', 2: 'two', 3: 'three'}

# list처럼 순서가 없기 때문에 append, pop등 없음
test_dict[5] = "five" # key = 5, value = "five"로 새로운 element(요소) 생성
print(test_dict) # {1: 'uno', 2: 'two', 3: 'three', 5: 'five'}

test_dict[1] = "one" # key 1의 value를 one으로 변경
print(test_dict) # {1: 'one', 2: 'two', 3: 'three', 5: 'five'}

del test_dict[2] # key 2와 그 value 삭제
print(test_dict) # {1: 'one', 3: 'three', 5: 'five'}