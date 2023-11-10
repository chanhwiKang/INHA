filePath = "/Users/gangchanhwi/Desktop/INHA/INHA_1-2/python_test/test03.txt"

infos = [
    ["김인하", "2", "컴퓨터정보"],
    ["이인하", "1", "컴퓨터시스템"],
    ["박인하", "3", "컴퓨터정보"]
]
# with문 사용
# |로 구분해서 저장
with open(filePath, "w") as file: # file = open(filePath, "w")
    for i in infos:
        file.write("|".join(i) + "\n")


# 저장한 파일로 기존 리스트 복원
with open(filePath, "r") as file:
    result = []
    for line in file:
        line = line.strip().split("|")
        result.append(line)

print(result)