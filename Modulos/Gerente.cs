namespace Trabalho.Modulos{

class Gerente:Funcionario{
    String id_gerente;

    public Gerente(String id_gerente,String id, String nome, Departamento dep):base( id, nome,dep){
        this.id_gerente = id_gerente;
    }

    }

}