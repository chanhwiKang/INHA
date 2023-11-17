import os
path_name = "/Users/gangchanhwi/Desktop/INHA/INHA_1-2/PYTHON"
full_filename = path_name + "/list.txt" # 저장할 파일의 전체경로

if os.path.isfile(full_filename):
    f = open(full_filename, "r")
# 점수 정보를 저장할 리스트를 생성한다.
lst = []
while True :
    tmp = f.readline()
    if not tmp :
        break
    datas = tmp.strip().split(",")
        
    if len(datas) == 4:
        dic = {
            "이름": datas[0],
            "국어": int(datas[1]),
            "영어": int(datas[2]),
            "수학": int(datas[3])
        }       
        dic["평균"] = sum([dic["국어"], dic["영어"], dic["수학"]]) / 3

        lst.append(dic)


    for dic in lst:
        print(dic["이름"])
        print("국어:", dic["국어"])
        print("영어:", dic["영어"])
        print("수학:", dic["수학"])
        print("평균:", dic["평균"])

f.close()