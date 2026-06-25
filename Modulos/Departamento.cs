namespace Trabalho.Modulos{

    class Departamento{
        String id;
        String id_gerente;
        String nome;
        String sigla;
        String ramal; 
        String chave;
        //primária é o id e a estrangeira é o id_gerente.9
        public Departamento(String id,String nome){
            this.id = id;
            this.nome = nome;
        }

        public String getId(){
            return this.id;
        }
        public String getNome(){
            return this.nome;
        }

        
    }
}