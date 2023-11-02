student=[]
titles=['국어', '영어', '수학']
num = int(input("몇명"))
for i in range(num):
    print(f"{i+1}번째 학생의 ", end=" ")
    scores=[]
    for j in titles:
        scores.append(int(input(f"{j}과목의 점수")))
    student.append(scores)
print(student)

# for i, ii in enumerate(student):
#     print(f"{i+1}번째 학생")
#     for j, jj in enumerate(ii):
#         print(f"{titles[j]}점수{jj:>3}")
#     print(f"점수 총 합{sum(student[i])}, 평균{sum(student[i])/len(titles)}")

for i in range(len(student)):
    print(f"{i+1}번째 학생")
    for j in range(len(titles)):
        print(f"{titles[j]}점수 {student[i][j]:>3} ")
    print(f"점수 총 합{sum(student[i])}, 평균 {sum(student[i])/len(titles)}")