using Estacionamento.View;

Console.OutputEncoding = System.Text.Encoding.UTF8;


//Instancias necessarias
Mensagens mensagens = new Mensagens();

//preenchendo os valores base
mensagens.ValoresInciais();


//Para manter o loop
int cont = 1;
while(cont == 1){

    cont = mensagens.Menu();
    Console.Clear();

}