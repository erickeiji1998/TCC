function login() {

    var user = document.getElementById('usuario').value;            //recebe o valor inserido
    var pass = document.getElementById("senha").value;

    var nome = 'a';                                                 //teste de autent.
    var chave = 'a';                                                

    var data = new Date();                                          //registro data de login
    var h = addZero(data.getHours());
    var m = addZero(data.getMinutes());
    var s = addZero(data.getSeconds());
    //var sem = addZero (data.getDay());                            //precisa decidise vai colocar o dia da semana
    var dia = addZero(data.getUTCDate());
    var mes = addZero(data.getMonth());
    var ano = addZero(data.getFullYear());
    var log = `${h}:${m}:${s}\n\n${dia}/${mes}/${ano}`;              
    
    
    document.getElementById('entrar').innerText = 'Entrando...';    //altera status do botão


    //condição para autenticação
    if (user == nome && pass == chave){                 
        
        res.innerHTML = `Você entrou com sucesso!`;
        document.getElementById("hora").innerHTML = log;                      
          
    }
    else{

        res.innerHTML = `Usuário incorreto`;
        document.getElementById("hora").innerHTML = log;
                             
    }


}

function addZero(i) {
if (i < 10) {
    i = "0" + i;
}
return i;
}
