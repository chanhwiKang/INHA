import os
folderPath = "/Users/gangchanhwi/Desktop/INHA/INHA_1-2/python_test/"
filePath = folderPath + "/test02.txt"

if not os.path.exists(folderPath): # 폴더의 유무 확인
    os.mkdir(folderPath) # 없으면 폴더를 만듬

file = open(filePath, "w")

scores = {"math": 90, "kor": 100, "eng": 40}
for k, v in scores.items():
    data = f"{k}, {v}\n"
    file.write(data)

file.close()