# Jogo da Forca
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/LICENSE) 

# Sobre o projeto

Jogo da Forca é uma aplicação construída como trabalho da matéria Programação de Algoritmos, do 1º semestre do Curso Técnico de Desenvolvimento de Sistemas, curso da [ETEC de Embu](https://www.etecdeembu.com.br/ "Site da ETEC de Embu").

A aplicação consiste nas mesmas regras do Jogo da Forca que conhecemos, onde uma pessoa escolhe a palavra e a outra tem que acertar qual é a palavra proposta, tendo como dica o número de letras. A cada letra errada, é desenhado uma parte do corpo do enforcado. O jogo termina ou com o acerto da palavra ou com o término do preenchimento das partes corpóreas do enforcado.

Agora falando sobre a aplicação, uma pessoa insere a palavra que quer que a outra pessoa adivinhe em um TextBox, após isso ela clica no Button "Esconder", o programa esconde a palavra, fazendo com que todas as letras sejam trocadas por "?". Daí a outra pessoa que terá que adivinhar tem a opção de 26 botões, cada um com uma letra do alfabeto (de A a Z). A cada vez que ele erra aparece uma mensagem na tela informando que "A letra não aparece na palavra!", o botão escolhido fica na cor vermelha e inclicável, e o pictureBox muda a imagem para a próxima parte do corpo do enforcado. Agora quando a pessoa acerta a letra aparece uma mensagem na tela informando que a letra aparece na palavra e a quantidade de vezes, e o botão clicado fica na cor verde e inclicável. E dependendo do desfecho do jogo o jogador recebe uma mensagem de parabéns por ter acertado ou uma mensagem informando que ele perdeu o jogo, e em ambos os casos todos os botões são desativados ao termino do jogo, sendo ativados quando o jogo for reiniciado. E o jogo pode ser reiniciado com o Button "Reiniciar". Também temos a opção de jogar contra a máquina, onde ele seleciona uma palavra aleatória de um arquivo de texto e o jogador tem que acertar qual é a palavra, possibilitando jogar sozinho.

## Layout
### Início
![Layout 1](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca01.JPG)

### Escolhendo e escondendo a palavra
![Layout 2](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca02.JPG) ![Layout 3](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca03.JPG)

### Acertando a letra
![Layout 4](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca04.JPG) ![Layout 5](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca05.JPG)

### Errando a letra
![Layout 6](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca06.JPG) ![Layout 7](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca07.JPG)

### Ganhando o jogo
![Layout 8](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca08.JPG) ![Layout 9](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca09.JPG)

### Perdendo o jogo
![Layout 10](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca10.JPG) ![Layout 9](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca11.JPG)

### Reiniciando e selecionando a opção de jogar contra a máquina
![Layout 12](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca12.JPG) ![Layout 13](https://github.com/MatheusCoutinho10/JogoDaForca/blob/master/Assets/JogoDaForca13.JPG)

# Tecnologias utilizadas
## Back end
- C#
  - Lógicas de Programação
  - Variável Randomica
  - Métodos Foreach
  - Metódos IF/Else para verificação
  - Métodos Try/Catch
## Front end
- Windows Forms Designer
  - TextBox
  - Button
  - PictureBox
  - RichTextBox
  - Panel
## Implantação em produção
- Back end: SharpDevelop
- Front end: SharpDevelop

# Como executar o projeto

- Pré-requisitos: Microsoft Visual C++

```bash
# clonar repositório
git clone https://github.com/MatheusCoutinho10/JogoDaForca

# entrar na pasta do executável
cd JogoDaForca\Jogo da Forca\bin\Debug

# executar o projeto
JogoDaForca spring-boot:run
```

# Autor

Matheus Henrique Martins Coutinho

https://www.linkedin.com/in/matheushmcoutinho/

# Agradecimentos

[ETEC de Embu](https://www.etecdeembu.com.br/ "Site da ETEC de Embu")
