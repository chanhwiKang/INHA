# name = "marin"
# hp = 40
# damage = 5
# print(f"{name}유닛이 생성되었습니다.")
# print(f"체력 {hp}, 공격력 {damage}\n")

# tank_name = "tank"
# tank_hp = 150
# tank_damage = 35
# print(f"{tank_name}유닛이 생성되었습니다.")
# print(f"체력 {tank_hp}, 공격력 {tank_damage}\n")

# def attack(name, location, damage):
#     print(f"{name} : {location} 방향으로 적군을 공격합니다. [공격력 {damage}]")

# attack(name, "1시", damage)
# attack(tank_name, "1시", tank_damage)

class Unit:
    def __init__(self, name, hp, damage):
        self.name = name
        self.hp = hp
        self.damage = damage
        print(f"{name}유닛이 생성되었습니다.")
        print(f"체력 {hp}, 공격력 {damage}")
        
# marine1 = Unit("마린", 40 , 5)
# marine1 = Unit("마린", 40 , 5)
# tank = Unit("탱크", 150 , 35)

wraith1 = Unit("레이스", 80, 5)
print(f"유닛 이름: {wraith1.name}, 공격력: {wraith1.damage}")

wraith2 = Unit("빼앗은 레이스", 80, 5)
wraith2.clocking = True

if wraith2.clocking == True:
    print(f"{wraith2.name}는 현재 클로킹 상태입니다.")