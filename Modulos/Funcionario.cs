
namespace Trabalho.Modulos{

class Funcionario{
    String id;//Chave Primaria
    String matricula;
    String nome; 
    String dataNascimento;
    String cpf; 
    String id_departamento;//Chave Estrangeira
    double salario;

    public Funcionario(String id, String nome, Departamento dep){
        this.id = id;
        this.nome = nome;
        this.id_departamento = dep.getId();
    }
  
}

}
