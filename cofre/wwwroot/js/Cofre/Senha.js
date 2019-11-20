let button = document.getElementById('entrar');
document.getElementById('senha').value = 0;;
var fibonacci = [1304969544928657, 2111485077978050, 3416454622906707, 5527939700884757, 8944394323791464];
document.getElementById('digitos').value = '0 +' + fibonacci[0];
var indice = [73, 74, 75, 76, 77];

var sequencia = 0;

button.addEventListener('click', () => {

    if (sequencia <= 4)
        ValidarSenha(fibonacci[sequencia]);

    if (sequencia === 0)
        document.getElementById('digitos').value = fibonacci[sequencia] + '+' + fibonacci[sequencia];
    else if (sequencia >= 4)
        document.getElementById('digitos').value = fibonacci[4];
    else
        document.getElementById('digitos').value = fibonacci[(sequencia - 1)] + '+' + fibonacci[sequencia];

    sequencia++
    
    if (fibonacci[4] === Number(document.getElementById('senha').value))
        alert('Cofre Aberto');
});

function ValidarSenha() {
    let xml = new XMLHttpRequest();
    xml.open('POST', 'Cofre/ValidarSenha?indice=' + indice[sequencia], true);

    xml.onreadystatechange = () => {
        if (xml.readyState === 4) {
            document.getElementById('senha').value = xml.responseText;
        }
    };
    xml.send();
}