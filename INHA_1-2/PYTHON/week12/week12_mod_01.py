def add(a, b):
    return a + b
def div(a, b):
    try:
        return a / b
    except:
        return None
# __name__ == 현재 나의 모듈이름을 알려줌
print(f"내 이름: {__name__}")
lambda a, b: a+b