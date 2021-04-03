Endpoints da Book API
---

**base_url** = https://meuenderecoapi.com

### Autores

- **GET** autores - `{base_url}/api/autores`
 Use para listar todos os Autores

[========]

- **POST** autor - `{base_url}/api/autores`
 Use para postar um autor
Exemplo:
```json
{
	"nome": "Clarice",
	"sobrenome": "Lispector",
	"email": "clarice@lispector.com",
	"dataNascimento": "10/12/1920"
}
```

[========]

- **PATCH** autor - `{base_url}/api/autores/{id}`
 Use para atualizar os dados de um autor
```json
{
	"nome": "Clarice",
	"sobrenome": "Lispector",
	"email": "clarice.lispector@autores.com"
}
```
[========]

- **DELETE** autor - `{base_url}/api/autores/{id}`
 Use para deletar um autor da base de dados

### Livros

- **GET** livros - `{base_url}/api/livros`
 Use para listar todos os Autores

[========]

- **POST** livro - `{base_url}/api/livros`
 Use para postar um livro
Exemplo:
```json
{
	"titulo": "A Hora da Estrela",
	"isbn": "853250812X",
	"ano": "1977"
	"autorid" "66bce229-5485-46a2-8356-0de3fb288ee6"
}
```

[========]

- **PATCH** livro - `{base_url}/api/livros/{id}`
 Use para atualizar os dados de um livro
```json
{
	"isbn": "853250812X6"
}
```
[========]

- **DELETE** autor - `{base_url}/api/livros/{id}`
 Use para deletar um livro da base de dados
