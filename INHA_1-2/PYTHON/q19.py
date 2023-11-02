def avg_score(lst):
    if lst.values():
        return sum(lst.values())//len(lst.values())

scores = {"kim":77, "lee":65}
# scores = {}
avg = avg_score(scores)

if avg != None:
    print(f"평균{avg}")
else:
    print("점수가 없음")