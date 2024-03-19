using Celular.Models;

//Instanciando a classe Android no Objeto Galaxy e atribuindo suas propriedades
Android Galaxy = new Android("1192222-3333");
Galaxy.Modelo = "S22 Ultra";
Galaxy.Imei = "1212efqw456";
Galaxy.Memoria = 12;

//Realizando a chamada das funções herdades da classe Pai (Smartphone)
Galaxy.InstalarAplicativo("Google Chrome");
Galaxy.InfoSmartPhone();
