def build_profile(first, last, **userinfo):
    print(f"{last} {first}의 추가 정보는 아래와 같습니다.")
    print(" 활동지역 :", userinfo.get('loc', '정보 없음'))
    print(" 분야 :", userinfo.get('field', '정보 없음'))

build_profile('albert', 'einstein', loc='princeton')
build_profile(last='kim', first='inha', loc='incheon', field='cs')
build_profile('inha', 'lee', loc='incheon', field='lg')
###########################################################################
PI = 3.141592

class Math:
    def solv(self, r):
        return PI * (r ** 2)

def add(a, b):
    return a + b

