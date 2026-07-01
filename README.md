# 🖥️ Guia de Configuração do Git/GitHub para Computadores de Laboratório (Ambiente Compartilhado)

Este guia foi criado para quem utiliza computadores públicos ou de laboratório. Ele ensina como limpar as credenciais do usuário anterior, configurar sua própria identidade de forma segura e apagar seus rastros ao terminar.


## 🛑 PASSO 1: Limpar o Usuário Anterior

Antes de começar, certifique-se de remover qualquer configuração global ou chave SSH deixada pelo usuário anterior.


#### 1. Limpar Nome e E-mail Global do Git


```bash
git config --global --unset user.name
git config --global --unset user.email
git config --global --unset-all user.name
git config --global --unset-all user.email
```

#### 2. Remover Chaves SSH Existentes (Se houver)
Verifique se existem chaves SSH antigas que possam causar conflito ou dar acesso indevido:

#### Apaga as chaves rsa antigas da pasta .ssh para evitar conflitos
```Bash
rm -f ~/.ssh/id_rsa ~/.ssh/id_rsa.pub
``` 

#### 3. Limpar o Gerenciador de Credenciais do Sistema (Se Windows/Mac)

```Bash
git credential-cache exit 2> /dev/null || true

```

# 🛑 PASSO 2: Configurar Seu Usuário e Criar Chave RSA


#### 1. Configurar sua Identidade (Local ou Global)
Se você for usar o computador apenas nesta sessão, pode configurar como --global:

```bash
git config --global user.name "Seu Nome Completo"
git config --global user.email "seu_email_do_github@exemplo.com"
```

#### 2. Gerar Chaves SSH

**Para criar uma chave padrão (RSA de 4096 bits):**
```bash 
  ssh-keygen -t rsa -b 4096 -C "seu_email@exemplo.com" 
```

Para criar uma chave para a conta secundária/trabalho (ED25519) especificando o nome do arquivo:
```bash
cat ~/.ssh/id_rsa.pub
```

# 🌐 PASSO 3: Adicionar a Chave ao GitHub

1. Faça login no seu GitHub.

2. No canto superior direito, clique na sua foto de perfil e selecione Settings.

3. Na barra lateral esquerda, clique em SSH and GPG keys.

4. Clique em New SSH key.

    - No campo Title, dê um nome que identifique o momento (Ex: Lab_Computacao_PC_04).

    - No campo Key, cole o conteúdo que você copiou no passo anterior.

5. Clique em Add SSH key.

---

