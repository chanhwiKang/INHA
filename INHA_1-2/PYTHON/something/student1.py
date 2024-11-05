# (1) 입력될때마다 파일에 저장

import datetime as dt
import os
from stu import Student

if __name__ == "__main__":
    target_path = "/Users/gangchanhwi/Desktop/INHA/INHA_1-2/PYTHON"
    target_output_file = "scores_output.txt"
    target_input_file = "scores_input.txt"
    # target_output_full_file = target_path + "/" + target_file
    target_output_full_file = os.path.join(target_path, target_output_file)
    target_input_full_file = os.path.join(target_path, target_input_file)
    students = []
    if os.path.exists(target_output_full_file): # 파일이 존재하는가?
        '''123|김인하|100|80|90|2023-11-30 19:17:20\n'''
        '''123|김인하|100,80,90|2023-11-30 19:17:20\n -> 이 경우도 해보기'''
        with open(target_output_full_file, "r", encoding="utf-8") as file:
            for record in file:
                record = record.strip()
                fields = record.split("|")
                if len(fields) == 6:
                    num = fields[0]
                    name = fields[1]
                    kor = int(fields[2])
                    math = int(fields[3])
                    eng = int(fields[4])
                    regdate = dt.datetime.strptime(fields[5], Student.time_format)
                    stu = Student(num, name, kor, math, eng, regdate)
                    students.append(stu)
                    with open(target_input_full_file, "a", encoding="utf-8") as file_input:
                        if not os.path.exists(target_path):
                            os.mkdir(target_path)
                        file_input.write(stu.make_record())
                    

    # (2) 신규입력을 모두 받고, 해당 데이터를 한꺼번에 추가

    # (3) 기존+신규 모두 새로 저장하기(기존 데이터가 바뀔 수 있는 경우)
 