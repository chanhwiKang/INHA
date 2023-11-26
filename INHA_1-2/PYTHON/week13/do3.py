from score import Score

scores = []
scores.append(Score(kor=20, eng=30, math=40))
scores.append(Score())

for score in scores:
    avg = score.get_average()
    print(avg)

print(scores[0].add_subject("kor", 10))
print(scores[0].scores)
print(scores[0].add_subject("sci"))
print(scores[0].scores)