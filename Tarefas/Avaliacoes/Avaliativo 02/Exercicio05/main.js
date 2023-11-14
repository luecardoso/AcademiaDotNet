let botao = document.querySelector("button");
let inputs = document.getElementsByTagName("input");
let cont=0;
botao.disabled = true;

window.onchange = function(){

    for(i =0; i< inputs.length; i++)
    {
        if(inputs[i].checked)
        {
            cont++;
            console.log("foi marcada a opção "+(i+1));
        }
    }
    
    if(cont>=2)
    {
        botao.disabled = false;
        cont = 0;
    }else{
        botao.disabled = true;
        cont = 0;
    }

}


