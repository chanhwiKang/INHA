import score as sc

print("step1", "-" * 10)
score1 = sc.Score2()
score2 = sc.Score2(kor=10, eng=20, math=30)
print(score1)
print(score2)
print(score1.kor)
print(score2.kor)

print("step2", "-" * 10)
score2 = sc.Score3(10, 20, 30)
print(score2)
print(score2.scores["kor"])
del score2.scores["kor"]
print(score2)
del score2.scores["eng"]
del score2.scores["math"]
print(score2)

print("step3", "-" * 10)
score3 = sc.Score4("kor", "eng", "math", "sci")
print(score3.scores)

print("step4", "-" * 10)
score4 = sc.Score5()
print(score4)
score5 = sc.Score5(kor=100, math=80)
print(score5)
score6 = sc.Score5(kor=100, sci=80, soc=40)
print(score6)
print(score6.scores)