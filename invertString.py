stringPadrao = input("Digite a string: ")
stringReverse = ''
for i in range(len(stringPadrao)):
    stringReverse += stringPadrao[len(stringPadrao) - 1 - i]

print(stringReverse)