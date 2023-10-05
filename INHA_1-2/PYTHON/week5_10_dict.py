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
student_num = input("학번: ")


# 학번 조회 기능 2. 아래와 같은 기능
info = infos.get(student_num, "Err")
print(info)

# 학번 조회 기능 1
# print(infos[student_num]) # keyerr 발생 가능. 아래와 같이 개선

if student_num in infos: # 과거에는 infos를 infos.keys()로 썼음
    print(infos[student_num])
else : print("Err")
