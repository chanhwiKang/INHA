# def profile(name, age, main_lang):
#     print(f"이름 : {name}\t나이 : {age}\t주 사용 언어 : {main_lang}")

# profile("yu", 20, "python")
# profile("kim", 25, "java")

def profile(name, age=17, main_lang="python"): # age, main_lang은 17, python이 기본값이 됨
    print(f"이름 : {name}\t나이 : {age}\t주 사용 언어 : {main_lang}")

profile("yu")
profile("kim")