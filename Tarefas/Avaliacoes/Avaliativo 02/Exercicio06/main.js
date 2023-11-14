let corPreto = document.getElementById("corPreto");
let corBranco = document.getElementById("corBranco");
let corFundo1 = document.getElementById("fundo1"); 
let corFundo2 = document.getElementById("fundo2");
let paragrafo = document.getElementById("texto");


function fontPreto(){
    paragrafo.style.color = "rgb(0, 0, 0)";
}
function fontBranco(){
    paragrafo.style.color = "rgb(255, 255, 255)";
}

function fundo1(){
    paragrafo.style.backgroundColor = "rgb(255, 123, 0)";
}

function fundo2(){
    paragrafo.style.backgroundColor = "rgb(0, 183, 255)";
}

