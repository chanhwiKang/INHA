import sys

# 둘의 출력이 겉보기엔 같으나
print("aaa", file=sys.stdout) # 표준 출력
print("aaa", file=sys.stderr) # err 출력이라는 차이가 있다

scores = {"math":0, "korean":50, "python":100}
for subject, score in scores.items():
    print(f"{subject.ljust(8)} : {str(score).rjust(4)}") # subject = 8칸 확보 후 왼쪽 정렬, score는 4칸 확보 후 오른쪽 정렬

for num in range(1, 21):
    print(f"대기번호 : {str(num).zfill(3)}") # .zfill을 쓰면 0으로 공간 확보

