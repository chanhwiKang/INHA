animals = [
    {"name": "코끼리", "weight" : 6, "preference" : 6},
    {"name": "하마", "weight" : 4, "preference" : 3},
    {"name": "기린", "weight" : 5, "preference" : 5},
    {"name": "물소", "weight" : 3, "preference" : 6},
    {"name": "호랑이", "weight" : 2, "preference" : 1},
    {"name": "사자", "weight" : 2, "preference" : 1},
    {"name": "얼룩말", "weight" : 2, "preference" : 1},
]
animals.sort(key=lambda animal:animal["preference"], reverse=True)
loaded_animals = []
current_weight=0;
current_preference=0;
for animal in animals:
    if current_weight + animal["weight"] <= 8:
        loaded_animals.append(animal["name"])
        current_weight = current_weight + animal["weight"]
        current_preference = current_preference + animal["preference"]

print(loaded_animals)
print(current_weight)
print(current_preference)