class Table:
    def __init__(self, length=10, width=10, heigth=1):
        self.length = length
        self.width = width
        self.heigth = heigth

    def square(self):
        return self.length * self.width


class KitchenTable(Table):
    def __init__(self, length, width: int, heigth, name):
        Table.__init__(self, length, width, heigth)
        self.name = name

class ComputerTable(Table):
    def printName(self):
        return "Компьютерный стол"


if __name__ == '__main__':
    commonTable = Table(100, 50, 50)
    print("Площадь стола: ", commonTable.square())
    computer01 = ComputerTable()
    computer02 = ComputerTable(90, 90, 50)
    print(computer02.printName())
    kitchen = KitchenTable(100, 60, 50, "стол на кухне")
