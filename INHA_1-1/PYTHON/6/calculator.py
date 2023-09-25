class FourCal:
    def __init__(self, first, second):
        self.first = first
        self.second = second

    def setdata(self, first, second):
        self.first = first
        self.second = second
    
    def add(self):
        return self.first + self.second

    def sub(self):
        return self.first - self.second
        
class MoreFourCal(FourCal):
    def pow(self):
        return self.first ** self.second

a = MoreFourCal(4, 2)
print(a.add())
print(a.pow())