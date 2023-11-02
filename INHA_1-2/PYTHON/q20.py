def get_students(sc_dict):
    if sc_dict.keys():
        return sc_dict.keys()


# scores = {"kim": 95, "lee": 65}
scores = {}
students = get_students(scores)
if students:
    students = ".".join(students)
    print(f"명단:{students}")
else:
    print("학생이 없음")