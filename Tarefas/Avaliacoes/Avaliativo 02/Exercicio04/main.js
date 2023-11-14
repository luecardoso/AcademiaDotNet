
function alterarEstadoTexto()
{
    let botao = document.querySelector("button");
    let paragrafo = document.getElementById("texto");
    // console.log(paragrafo);
    if(paragrafo.hidden)
    {
        paragrafo.hidden = false;
        botao.textContent = "Desativar Texto";
    }
    else
    {
        paragrafo.hidden = true;
        botao.textContent = "Ativar Texto";
    }
}