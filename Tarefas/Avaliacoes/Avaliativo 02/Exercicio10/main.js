let campoCPF = document.getElementById("cpf");
let campoCNPJ = document.getElementById("cnpj");
let pessoaFisica = document.getElementById("pessoa-fisica");
let pessoaJuridica = document.getElementById("pessoa-juridica");
let dataNascimento = document.getElementById("campo-nascimento");
let campoCEP = document.getElementById("cep");
let nome = document.getElementById("nome");
let campoTelefone = document.getElementById("telefone");
let aviso = document.getElementById("aviso")

campoCPF.disabled = true;
campoCNPJ.disabled = true;
dataNascimento.hidden = true;

window.onchange = function(){
    
    if(pessoaFisica.checked)
    {
        campoCPF.disabled = false;
        campoCPF.focus();
        campoCNPJ.disabled = true;
        campoCNPJ.value = "";
        dataNascimento.hidden = false;
    }else
    {
        campoCPF.disabled = true;
        campoCPF.value = "";
        campoCNPJ.disabled = false;
        campoCNPJ.focus();
        dataNascimento.hidden = true;
    }

}


/*
 /\D/ ou /[^0-9]/  = Corresponde qualquer caractere que não é um dígito no 
 alfabeto basic Latin. 
 g = corresponder globalmente; acha todas as correspondências em vez de parar 
após achar a primeira
https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Reference/Global_Objects/RegExp
*/

oninput = (Event) => {
    nome.value = nome.value.replace(/[0-9]/g,'');
    campoCPF.value = campoCPF.value.replace(/[^0-9]/g,'');
    campoCNPJ.value = campoCNPJ.value.replace(/\D/g,'');
    campoCEP.value = campoCEP.value.replace(/\D/g, '');
    campoTelefone.value = campoTelefone.value.replace(/[^0-9]/g,'');
}