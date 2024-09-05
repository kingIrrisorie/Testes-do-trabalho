import json

def calculaNumeroDeDiasMaiorQueMedia(numberArray):
    media = 0
    numeroDeDiasMaiorQueMedia = 0
    for item in numberArray:
        media += item
    
    media = media/len(numberArray)
    
    for item in numberArray:
        if item > media:
            numeroDeDiasMaiorQueMedia += 1
    
    return numeroDeDiasMaiorQueMedia


def calculoMaiorValor(numberArray):
    maiorValor = numberArray[0]
    
    for item in numberArray:
        if item > maiorValor:
            maiorValor = item
    
    return maiorValor


def calculoMenorValor(numberArray):
    menorValor = numberArray[0]

    for item in numberArray:
        if item < menorValor:
            menorValor = item
    
    return menorValor

def processamento(faturas):
    menorFaturamento = 0
    maiorFaturamento = 0
    numeroDeDiasMaiorQueMedia = 0
    
    faturasValidas = []

    for item in faturas:
        valor = item["valor"]
        if valor > 0:
            faturasValidas.append(valor)

    numeroDeDiasMaiorQueMedia = calculaNumeroDeDiasMaiorQueMedia(faturasValidas)
    menorFaturamento = calculoMenorValor(faturasValidas)
    maiorFaturamento = calculoMaiorValor(faturasValidas)

    return menorFaturamento, maiorFaturamento, numeroDeDiasMaiorQueMedia
    


with open("../dados/dados.json") as file:
    faturamentos = json.load(file)



print(f"menor faturamento foi: {processamento(faturamentos)[0]}")
print(f"maior faturamento foi: {processamento(faturamentos)[1]}")
print(f"numero de dias maior que a media: {processamento(faturamentos)[2]}")
