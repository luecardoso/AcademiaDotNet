var n1 = 10;
var n2 = 10.5;
var n3 = 1.5e3;
var n4 = 0xff;

var s1 = "teste";
var s2 = 'teste';

var b1 = true;

var u = undefined;
var n = null;

var obj = 
{
   id: 30,
   nome: "Fabrício"
}

var array = ["string1", "string2", "string3", "string4", "string5"];

var funcao = function (x, y) {  return x + y; };

var numero = 1;

if(numero == "1")
{
    //alert("com == entrou aqui? SIM");
}

if(numero === "1")
{
    //alert("com === entrou aqui? Não");
}

var x = (numero === "1") ? "Nunca executa!" : "Numero é diferente de string, mesmo com o valor igual, ele da falso!";
//alert(x);

var nome = "";

var pessoa = {nome: "Lucas", sobrenome:"Reis"};

for(atributo in pessoa)
{
    nome += pessoa[atributo] + " ";
}

//alert(nome);

var resultado = "";
var numero = 1;

while(numero <=10)
{
    resultado += numero + " ";
    numero++;
}
//alert(resultado);

//01-Escreva um código que código que mostre os números ímpares entre 1 e 10
for(var i = 1; i <= 10; i++)
{
    if(i % 2 != 0)
    {
        //alert(i);
    }
    
}

//02-Escreva um código que calcule a soma de 1 até 100
var soma = 0;
for(var i = 1; i <= 100; i++)
{
    soma += i;
}
//alert(soma);

//Desafio: "executar função ao clique do botão": executar um alerta cada vez que um botão
//seja acionado até, nomáximo, 5 alertas. A cada iteração, apresentar o número do alerta.

var cont = 1;
// do{
function funcaoBotao()
{
    if(cont <= 5)
    {
        alert(cont+"o click!");
        cont++;
    }
    
}
// }while(cont <= 5);

let z;
console.log(z);
document.getElementsByTagName("p");
//1
function mostrarInformacao()
{
    let nome = document.getElementById("nomePessoa");
    let idade = document.getElementById("idadePessoa");

    alert(nome.value + " tem "+idade.value +" anos");

    
}
//2
function mostrarInformacao()
{
    let nome = document.getElementById("nomePessoa");
    let idade = document.getElementById("idadePessoa");
    if(idade.value >= 18)
    {
        alert(nome.value + " é maior de idade");
    }else
    {
        alert(nome.value + " é menor de idade");
    }
    
}

//3
function somaNumeros()
{
    let n1 = parseInt(document.getElementById("numero1").value);
    let n2 = parseInt(document.getElementById("numero2").value);
    let soma = n1 + n2;
    alert("A soma de "+n1+" + "+ n2+ " = "+ soma)
}