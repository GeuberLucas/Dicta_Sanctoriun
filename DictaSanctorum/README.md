

# Dicta Sanctorum - Gerador de Frases dos Santos

## Descrição do Projeto

**Dicta Sanctorum** é um projeto voltado para a fé católica, com foco na exibição de frases inspiradoras dos santos, informações detalhadas sobre suas vidas, e funcionalidades para que os usuários possam interagir com o conteúdo através de filtros, favoritos e compartilhamento.






## Funcionalidades

- **Cadastro no sistema**: Permite que novos usuários se registrem no sistema.
- **Login no sistema**: Usuários podem acessar o sistema usando suas credenciais.
- **Listagem dos Santos cadastrados**: Página que lista todos os santos cadastrados, com filtros por nome, data de festa e nacionalidade.
- **Página sobre os Santos**: Página dedicada a exibir mais informações sobre os santos.
- **Gerador de Frases dos Santos**: Gera e exibe frases aleatórias dos santos.
- **Favoritar Frases**: Permite aos usuários favoritar frases e acessá-las posteriormente.
- **Compartilhamento Simples**: Facilita o compartilhamento de frases nas redes sociais ou por mensagem.
## Testes do Sistema

O projeto **Dicta Sanctorum** segue uma abordagem robusta de testes em vários níveis para garantir a qualidade e a consistência do sistema. Abaixo estão descritos os níveis de testes e cenários para cada funcionalidade.

### 1. Cadastro no Sistema

#### Testes Unitários:
- Validação de campos obrigatórios (ex.: nome, e-mail, senha).
- Teste de e-mail já registrado com erro adequado.
- Verificação das regras de segurança de senha.

#### Testes de Integração:
- Salvamento correto dos dados no banco de dados.
- Integração com serviço de confirmação de e-mail.
  
#### Testes de UI/UX:
- Usabilidade do formulário de cadastro (foco, mensagens de erro).
- Responsividade do design em diferentes dispositivos.

#### Testes de Sistema:
- Desempenho ao simular múltiplos cadastros simultâneos.
  
#### Testes de Aceitação:
- Confirmação de que o processo de cadastro é claro e intuitivo.



### 2. Login no Sistema

#### Testes Unitários:
- Sucesso com credenciais corretas e falha com incorretas.
- Teste de bloqueio após várias tentativas de login.
  
#### Testes de Integração:
- Criação correta de sessões de usuário.
- Integração com autenticação (ex.: JWT).

#### Testes de UI/UX:
- Mensagens de erro claras e interface intuitiva.
- Layout responsivo e acessível.

#### Testes de Sistema:
- Desempenho do login com múltiplos usuários simultâneos.
  
#### Testes de Aceitação:
- Confirmação de que o processo de login é rápido e intuitivo.



### 3. Listagem dos Santos Cadastrados

#### Testes Unitários:
- Exibição correta de todos os santos cadastrados.
- Funcionalidade correta dos filtros por nome, data de festa e nacionalidade.

#### Testes de Integração:
- Integração entre o frontend e o backend para carregamento da lista de santos.
- Verificação de consultas corretas no banco de dados.

#### Testes de UI/UX:
- Usabilidade e responsividade da página de listagem.
  
#### Testes de Sistema:
- Desempenho da página com grande volume de santos cadastrados.

#### Testes de Aceitação:
- Navegação intuitiva e uso fácil dos filtros.



### 4. Página sobre os Santos

#### Testes Unitários:
- Exibição correta das informações detalhadas de cada santo.

#### Testes de Integração:
- Recuperação correta das informações do banco de dados.

#### Testes de UI/UX:
- Verificação do layout e responsividade da página.

#### Testes de Sistema:
- Desempenho da página sob alta carga de acessos simultâneos.

#### Testes de Aceitação:
- Conteúdo claro e apresentação satisfatória para o usuário final.



### 5. Gerador de Frases dos Santos

#### Testes Unitários:
- Geração e exibição correta de uma frase aleatória.
- Verificação de comportamento caso não haja frases disponíveis.

#### Testes de Integração:
- Integração com o banco de dados para recuperação de frases.

#### Testes de UI/UX:
- Botão de gerar frase intuitivo e fácil de usar.

#### Testes de Sistema:
- Desempenho da geração de frases com múltiplos usuários simultâneos.

#### Testes de Aceitação:
- Feedback positivo dos usuários sobre a geração de frases.



### 6. Favoritar Frases

#### Testes Unitários:
- Verificação da marcação de frases como favoritas.
- Teste da exibição da lista de frases favoritas.

#### Testes de Integração:
- Salvamento e recuperação corretos das frases favoritas no banco de dados.

#### Testes de UI/UX:
- Interface de favoritar frases clara e fácil de usar.

#### Testes de Sistema:
- Desempenho ao salvar frases favoritas com vários usuários simultâneos.

#### Testes de Aceitação:
- Avaliação dos usuários sobre a utilidade da função de favoritar frases.



### 7. Compartilhamento Simples

#### Testes Unitários:
- Preparação correta do conteúdo para compartilhamento.

#### Testes de Integração:
- Integração com APIs de redes sociais para compartilhamento.

#### Testes de UI/UX:
- Botão de compartilhamento intuitivo e fácil de usar.

#### Testes de Sistema:
- Teste de compartilhamento em diferentes plataformas (WhatsApp, Facebook, etc.).

#### Testes de Aceitação:
- Confirmação de que o compartilhamento é simples e eficaz para os usuários finais.