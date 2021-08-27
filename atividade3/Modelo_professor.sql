CREATE DATABASE Modelo_prof;
CREATE TABLE usuario(
    idUsuario INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR (50) NOT NULL,
    idade SMALLINT,
    email VARCHAR (30) NOT NULL,
    senha VARCHAR (50) NOT NULL, 
);
-- not null é pra não deixar em branco
SELECT * FROM usuario;

SELECT nome FROM usuario;

SELECT * FROM usuario WHERE nome = 'Guilherme Mello';

SELECT * FROM usuario WHERE senha = '123456';

SELECT * FROM usuario WHERE login = 'Guilherme' AND senha = '123456';

DELETE FROM usuario WHERE nome = 'Fulano de Tal';

INSERT INTO usuario (nome, idade, email, senha) VALUES (
    'Fulano de Tal', 37, 'fulano@gmail.com', '12345'
);