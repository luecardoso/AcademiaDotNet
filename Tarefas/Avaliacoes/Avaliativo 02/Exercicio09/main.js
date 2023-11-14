
let login = document.getElementById("login");
let senha = document.getElementById("senha");
let confirmarSenha = document.getElementById("confirmar");

let formulario = document.getElementById("formulario");
let botao = document.getElementById("enviar");
let aviso = document.getElementById("aviso")


function confirmarDados()
{
   formulario.addEventListener('submit',function(e){
      if(senha.value != confirmarSenha.value){
         aviso.innerText = "As senhas não são iguais!";
         aviso.style.color = "red";
         senha.focus();
         e.preventDefault();
      }else
      {
         aviso.innerText = "Dados enviados com sucesso!";
         aviso.style.color = "green";
         login.value = ""
         login.focus();
         senha.value = "";
         confirmarSenha.value = "";
         e.preventDefault();
      }
   });

   
}