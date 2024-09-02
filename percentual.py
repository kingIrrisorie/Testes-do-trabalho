def calcularTotal(faturamentos):
    total = 0

    for item in faturamentos.values():
        total += item

    return total

def calcularPercentuais(faturamentos, faturamentoTotal):
    percentuais = {}
    for estado, valor in faturamentos.items():
        percentual = (valor/faturamentoTotal) * 100
        percentuais[estado] = percentual
    
    return percentuais


faturamentoTotal = 0
percentuais = {}
faturamentos = {
    "SP": 67836.43,
    "RJ": 36678.66,
    "MG": 29229.88,
    "ES": 27165.48,
    "Outros": 19849.53
}

faturamentoTotal = calcularTotal(faturamentos)

percentuais = calcularPercentuais(faturamentos, faturamentoTotal)

for estado, percentual in percentuais.items():
    print(f"{estado}: {percentual:.2f}")
