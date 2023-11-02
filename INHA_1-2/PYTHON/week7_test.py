def remove_value(number, remove_value):
    while remove_value in number:
        number.remove(remove_value)
    return number
num = [1, 2, 3, 2, 4, 2, 5]
value_to_remove = 2
update_list = remove_value(num, value_to_remove)
print(update_list)
##################################################
def get_duplicate_counts(numbers):
    duplicate_counts = {}
    for number in numbers:  # numbers의 값으로 반복
        if number in duplicate_counts:  # duplicate_counts 안에 number가 있다면
            duplicate_counts[number] += 1 # 해당 key의 value를 1증가
        else:                           # duplicate_counts 안에 number가 없다면
            duplicate_counts[number] = 1 # duplicate_counts에 'number': 1 생성 
    
    # duplicate_counts 새로운 딕셔너리 생성과 동시에 key, value 선언 (리스트 컴프리헨션 사용)
    # duplicate_counts의 value가 1보다 크면(값이 중복되면 ), key, value 추가
    duplicate_counts = {key : value for key, value in duplicate_counts.items() if value > 1}
    return duplicate_counts

num = [1, 2, 3, 2, 4, 2, 5, 3]
duplicate_counts = get_duplicate_counts(num)
print(f"중복 항목: {duplicate_counts}")
