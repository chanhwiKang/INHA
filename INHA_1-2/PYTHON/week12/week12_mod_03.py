def add(a, b):
    return a + b
def div(a, b):
    try:
        return a / b
    except:
        return None
# __name__ -> 현재 나의 모듈이름을 알려줌
#  __name__ == "__main__": -> 현재 이 모듈에서 코드 실행한 경우(이 모듈이 시작 모듈인 경우) True
# 다른 파일에서 실행하면 False
if __name__ == "__main__":
    print(f"내 이름: {__name__}")
lambda a, b: a+b