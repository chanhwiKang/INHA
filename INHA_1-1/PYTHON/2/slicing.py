jumin = "990301-1234567"

print("성별 : " + jumin[7])
print("연도 : " + jumin[0:2]) # 0부터 1까지의 값
print("월 : " + jumin[2:4])
print("일 : " + jumin[4:6])

print("생년월일 : " + jumin[:6]) #0~5
print("뒤 7자리 : " + jumin[7:]) # 7~
print("뒤 7자리 (뒤에서 부터)" + jumin[-7:]) #맨 뒤에서 7번째 끝 까지