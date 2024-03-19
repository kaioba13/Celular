# Sistema de Gestão de Celulares

## Linguagem utilizada
C#

## Paradigma de programação
Orientação a Objetos

## Principais conceitos utilizados
- **Herança:** Utilizada para criar as classes `Android` e `Iphone`, que herdam de `Smartphone`.
- **Abstração:** A classe `Smartphone` é uma classe abstrata que define um conjunto de métodos e propriedades que devem ser implementadas pelas suas classes derivadas.
- **Polimorfismo:** As classes `Android` e `Iphone` implementam o método abstrato `InstalarAplicativo` de maneira específica para cada tipo de smartphone.
- **Encapsulamento:** As propriedades da classe `Smartphone` são definidas como `public` para permitir acesso a elas, enquanto os detalhes de implementação são encapsulados dentro das classes.

## Como baixar e instalar na própria máquina para teste

### Pré-requisitos
- Certifique-se de ter o ambiente de desenvolvimento .NET instalado em sua máquina. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download).
- Um editor de código, como Visual Studio Code ou Visual Studio, pode ser útil para trabalhar com o código.

### Passos
1. **Clone o repositório:**
   ```bash
   git clone https://github.com/kaioba13/Celular.git
   Abra o projeto:

Navegue até o diretório do projeto clonado e abra-o em seu editor de código.
Execute o projeto:

Dentro do seu editor de código, abra o terminal integrado.
Navegue até o diretório onde o projeto está localizado.
Compile e execute o projeto utilizando os seguintes comandos:
````bash
dotnet build
dotnet run

