# glob : 경로 내의 폴더 / 파일 목록 조회

# import glob
# print(glob.glob("*.py")) # 확장자가 py인 모든 파일

# os : 운영체제에서 제공하는 기본 기능
import os
# print(os.getcwd())

# folder = "sample_dir"

# if os.path.exists(folder):
#     print("이미 존재하는 폴더입니다.")
#     os.rmdir(folder)
#     print("폴더를 삭제하였습니다.")
# else:
#     os.makedirs(folder) # 폴더 생성
#     print(f"{folder} 폴더를 생성하였습니다.")

# print(os.listdir())

# import time # 시간 관련 함수
# print(time.strftime("%Y-%m-%d %H:%M:%S"))

import datetime
print(datetime.date.today())

today=datetime.date.today()
td = datetime.timedelta(days=100) # 100일 후 저장
print(today + td)