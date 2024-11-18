// Criar objeto da classe Conexão
Conexao c = new();

// Criar objeto da classe PessoaSQL
PessoaSQL p = new(c.ObterStringDeConexao());

// p.Cadastrar("Ricardo", "Rio de Janeiro");

// p.Alterar("Marcelo", "Porto Alegre", 2);

p.Excluir(2);

p.Selecionar();