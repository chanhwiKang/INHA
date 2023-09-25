# def profile(name, age, lang1, lang2, lang3, lang4, lang5):
#     print(f"이름: {name}\t나이: {age}\t", end=" ")
#     print(lang1, lang2, lang3, lang4, lang5)

def profile(name, age, *lang): # *lang을 사용하여 line:1처럼 길게 쓸 필요가 없음
    print(f"이름: {name}\t나이: {age}\t", end=" ")
    for i in lang:
        print(i, end=" ")
    print()

profile("yu", 20, "python", "java", "c", "c++", "c#", "java_sc")
profile("kim", 25, "kotlin", "swift")
