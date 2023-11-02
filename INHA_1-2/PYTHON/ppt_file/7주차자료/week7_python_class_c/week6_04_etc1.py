# week6_04_etc1.py
# 연습 예제
ip_addr = [127, 0, 0, 1]

# p.257 *리스트 내포
array = []
for i in range(0, 20, 2):
    if i % 4:
        array.append(i * i)
print(array)

array = [i * i for i in range(0, 20, 2) if i % 4]

array = []
for i in range(0, 20, 2):
    array.append(i * i)
print(array)

array = [i * i for i in range(0, 20, 2)]

# p.263 - str.join()
fruits = ["달기", "사과", "배"]  # "달기,사과,배"
# "내가 좋아하는 과일은 달기, 사과, 배 입니다."

my_fav = ""
for f in fruits:
    if len(my_fav) > 0:
        my_fav += ","
    my_fav += f
print(my_fav)  # "달기,사과,배,"

my_fav = ",".join(fruits)
print(my_fav)

# p.256 items(), keys(), values()
example = {1: "one", 2: "two", 5: "five"}

for k in example:
    print(k)
for k in example.keys():
    print(k)
for v in example.values():
    print(v)
for k, v in example.items():
    print(k, v)


# p.254
scores = [100, 45, 80, 0, 23]

for i, score in enumerate(scores):
    print(f"{i+1}번 과목: {score}")

for i, name in enumerate("장은미"):
    print(i, name)

# p.252
scores = [100, 45, 80, 0, 23]
print(reversed(scores))
print(list(reversed(scores)))
print(scores)

rvs = reversed(scores)
for r in rvs:
    print("1st:", r)
for r in rvs:
    print("2nd:", r)


# p.251
scores = [100, 45, 80, 0, 23]

print(min(scores))
print(max(scores))
print(sum(scores))
print(sum(scores) / len(scores))

# 사용자가 입력한 점수를 가지고
# 평균을 구하는 코드를 작성하세요.
