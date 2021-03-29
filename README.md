# desafiosoftplan
Projeto desenvolvido Asp.NET Core 3.1

Architecture
- API - Camada dos módulos REST.
- Domain - Camada de domínio e declaração dos contratos de repositório e serviços.
- Infra.Data - Camada de acesso a dados.
- Service - Camada de regra de negócios.
- Test - Projeto de teste

APIs
- CalculatesInterest API responsável por calcular os juros
- InterestRate API responsável por listar a taxa de juros

Development server 
- CalculatesInterest 
Navage até o diretório raiz e execute o comando no terminal "docker-compose up". Navegue para http://localhost:5001/.

 - InterestRate
Navage até o diretório raiz e execute o comando  no terminal "docker-compose up". Navegue para http://localhost:5000/.

Caso esteja utilizando docker for windows alterar o target nos arquivos .csproj dos projetos API 
ex: definir DockerDefaultTargetOS para Windows


Detalhamento dos endpoints das duas APIs podem ser acessado através do swageer exemplo: http://localhost:5000/swagger
