import os
path_name = "c:/202344073"
full_filename = path_name + "/list.txt" # 저장할 파일의 전체경로
# path_name = "/Users/gangchanhwi/Desktop/INHA/INHA_1-2/PYTHON"
# full_filename = path_name + "/list.txt" # 저장할 파일의 전체경로

if os.path.isfile(full_filename):
    f = open(full_filename, "r")
    # 점수 정보를 저장할 리스트를 생성한다.
    stu_info = []
    
    while True:
        # 파일에서 한 줄을 읽어온다.
        tmp = f.readline().strip()
        # 읽어온 내용이 없으면 반복문을 종료한다.
        if not tmp:
            break
        # 읽어온 내용 을 ,( 쉼표 ) 로 분해한다. split() 이용
        tmp = tmp.split(",")
        # 분해한 데이터의 개수가 4개인지 확인한다.
        # 4개인 경우에만
        if len(tmp) == 4:
            # 딕셔너리를 생성하여
            stu_score = {}
            # 이름 ( name) , 국어점수 ( kor) , 영어점수 ( eng) , 수학점수 ( mat) 를
            # 딕셔너리에 추가하고
            stu_score[tmp[0]] = tmp[1:]
            # 해당 딕셔너리를 점수 정보를 저장할 리스트에 추가한다.
            stu_info.append(stu_score)
f.close()
# 반복문을 통해 점수 정보를 저장할 리스트의 모든 내용을 실행화면 예제를 참고하여
# 화면에 출력한다.
for d in stu_info:
    for name, v in d.items():
        kor, eng, math = map(int, v)
    print(f"이름:{name} 국어:{kor} 영어:{eng} 수학:{math} 평균:{(kor + eng + math) / 3:.2f}")
    
