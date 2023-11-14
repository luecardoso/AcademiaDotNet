let corPreto = document.getElementById("corPreto");
let corBranco = document.getElementById("corBranco");
let corFundo1 = document.getElementById("fundo1"); 
let corFundo2 = document.getElementById("fundo2");
let paragrafo = document.getElementById("texto");
let tamanho = 16;
let tamanhoFonte = paragrafo.style.fontSize = tamanho;

console.log(tamanhoFonte);
function fontPreto()
{
    paragrafo.style.color = "rgb(0, 0, 0)";
}
function fontBranco()
{
    paragrafo.style.color = "rgb(255, 255, 255)";
}

function fundo1()
{
    paragrafo.style.backgroundColor = "rgb(255, 123, 0)";
}

function fundo2()
{
    paragrafo.style.backgroundColor = "rgb(0, 183, 255)";
}

function aumentarFonte()
{
    tamanho++;

    paragrafo.style.fontSize = tamanho+"px";
}

function diminuirFonte()
{
    tamanho--;
    if(tamanho <= 10){
        tamanho = 10;
    }
    paragrafo.style.fontSize = tamanho+"px";
}