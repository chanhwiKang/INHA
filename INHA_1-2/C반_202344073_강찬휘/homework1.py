import os
path_name = "c:/202344073"
full_filename = path_name + "/list.txt" # 저장할 파일의 전체경로
# path_name = "/Users/gangchanhwi/Desktop/INHA/INHA_1-2/PYTHON"
# full_filename = path_name + "/list.txt" # 저장할 파일의 전체경로

if not os.path.isdir(path_name):
    # 폴더가 없을 경우 생성한다.
    os.mkdir(path_name)
f = open(full_filename, "a")
subjects = ["국어", "영어", "수학"]
while True:
    # 이름을 입력 받는다.
    tmp = input("이름을 넣어주세요.(종료시:바로엔터)")
    # 입력받은 이름이 비어있으면 반복문을 빠져나간다.
    if not tmp:
        break

    # 국어 점수를 입력 받는다.
    # 영어 점수를 입력 받는다.
    # 수학 점수를 입력 받는다.
    for subject in subjects:
        tmp = tmp + "," + input(f"{subject} 점수:")

    # 파일에 이름 ,국어점수 ,영어점수 ,수학점수 형태로 쓰기를 수행한다.
    f.write(tmp+"\n")
f.close()
'''
    while True:
    # 이름을 입력 받는다.
    tmp = input("이름을 넣어주세요.(종료시:바로엔터)")
    # 입력받은 이름이 비어있으면 반복문을 빠져나간다.
    if not tmp:
        break
    # 국어 점수를 입력 받는다.
    tmp = tmp + "," + input("국어 점수:")
    # 영어 점수를 입력 받는다.
    tmp = tmp + "," + input("영어 점수:")
    # 수학 점수를 입력 받는다.
    tmp = tmp + "," + input("수학 점수:")
    # 파일에 이름 ,국어점수 ,영어점수 ,수학점수 형태로 쓰기를 수행한다.
    f.write(tmp+"\n")
f.close()'''