def fibonacci():
    number = (int(input("insira o numero: ")))

    numeroAnterior = 0
    proximoValor = 1

    if number < 0:
        return "Não pode número negativo"
    elif number == 0 or number == 1:
        return f"O número {number} pertence à sequência de Fibonacci"
    else:
        while proximoValor < number:
            tempAnterior = numeroAnterior
            numeroAnterior = proximoValor

            proximoValor = tempAnterior + numeroAnterior
        
        if proximoValor == number:
            return f"O número {number} pertence a sequência de fibonacci"
        else:
            return f"O número {number} nao pertence a sequência de fibonacci"

print(fibonacci())