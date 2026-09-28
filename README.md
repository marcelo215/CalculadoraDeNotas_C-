# Calculadora de Notas

Aplicação Console em C# para gerenciamento simplificado das notas de um aluno.
Projeto do Checkpoint 2 (CS - CP2 Lógica com Estruturas em C#).

**Aluno:** SEU NOME AQUI

## Funcionalidades

O programa exibe um menu que fica ativo até o usuário escolher a opção 4:

1. **Cadastrar aluno:** armazena o nome do aluno.
2. **Lançar notas:** cadastra 3 notas (entre 0 e 10) em um array.
3. **Calcular média:** calcula a média e exibe a situação do aluno.
4. **Sair:** encerra o programa.

## Critérios de situação

| Média | Situação |
|---|---|
| >= 7,0 | Aprovado |
| >= 5,0 e < 7,0 | Recuperação |
| < 5,0 | Reprovado |

## Conceitos utilizados

- Variáveis, constantes e operadores
- Estruturas condicionais (`if/else` e `switch expression`)
- Estruturas de repetição (`while` e `for`)
- Arrays
- Métodos `static`
- Entrada e validação de dados com `Console.ReadLine()` e `TryParse()`

## Como executar

Pré-requisito: [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```bash
git clone https://github.com/SEU-USUARIO/CalculadoraDeNotas.git
cd CalculadoraDeNotas
dotnet run
```

## Testes realizados

| Notas | Resultado esperado |
|---|---|
| 7 / 7 / 7 | Aprovado |
| 5 / 5 / 5 | Recuperação |
| 4 / 3 / 2 | Reprovado |
| `abc` ou nota fora de 0 a 10 | Mensagem de entrada inválida |

## Estrutura do código

- `Main()`: controla o menu.
- `CadastrarAluno()`: lê e valida o nome.
- `LancarNotas()`: lê e valida as 3 notas.
- `CalcularMedia()`: calcula a média.
- `ExibirSituacao()`: exibe Aprovado, Recuperação ou Reprovado.
