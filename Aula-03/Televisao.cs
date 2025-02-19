namespace Aula_03;

class Televisao
{
    // o metodo construtor possui o mesmo
    // nome da classe. Ele não possui retorno (nem mesmo o void)
    // Este metodo é executado sempre que uma instancia da classe
    // é criada
    // Por padrão, o C# cria um metodo contrutor vazio
    // mas podems criar 
    public  Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }



    // Get: permite que seja executada a 
    // Leitura atual da propriedade
    // Set: permite que seja atribuido um 
    // valor para a propriedade

    // classes, propriedades e metodos possuem modificadores de acesso
    // public: visiveis a todo o projeto
    // internal: visiveis somente no namespace
    // protected: visiveis somente na classe e nas classes que herdam
    // private: visiveis somaente na classe que foram criados
    public float Tamanho { get; private set; }
    public int Resolucao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }
}