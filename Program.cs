
using Trabalho.Modulos;

class Program{
    static void Main(){
       Departamento dep_compras = new Departamento("D23","Compras");
       Funcionario funcionario = new Funcionario("A-125","Daniel",dep_compras);
       Gerente gere = new Gerente(dep_compras.getId(),"A-126","Matheus",dep_compras);

      
    }   
}