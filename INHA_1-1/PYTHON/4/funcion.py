def open_account():
    print("새로운 계좌가 생성되었습니다.")

def deposit(balance, money): # 입금
    print(f"입금이 완료되었습니다. 잔액은 {balance+money}원입니다.")
    return balance + money

def withdraw(balance, money): # 출금
    if balance >= money:
        print(f"출금이 완료되었습니다. 잔액은 {balance-money}원입니다.")
        return balance - money
    else:
        print(f"잔액이 부족합니다. 잔액은 {balance}원 입니다.")
        return balance

def withdraw_night(balance, money):
    commission = 100
    return commission, balance - money - commission # tuple형식으로 반환

balance = 0
balance = deposit(balance, 10000)
commission, balance = withdraw_night(balance, 1000)
print(commission, balance)
