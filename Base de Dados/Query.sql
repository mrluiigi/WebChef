Use WebChef;

INSERT INTO Utilizador(nome, email, password)
	VALUES
		('admin', 'admin@gmail.com', '21232f297a57a5a743894a0e4a801fc3');


INSERT INTO Receita (nome, descricao, informacao_nutricional, duracao_prevista, link_ajuda, imagem, nr_pessoas, dificuldade, categoria)
	VALUES 
		('Sopa de Agrião', 'Sopa de agrião', '50|15|2|13|23|4|2|3|', 200, 'https://youtu.be/gS2WtZHvvWk?t=', '~/Images/sopaAgriao.jpg', 2, 'facil', 'Prato Principal'),
		('Massa', 'bolonhesa', '50|15|2|13|23|4|2|3|', 400, 'https://youtu.be/gS2WtZHvvWk?t=', '~/Images/oleo.jpg', 4, 'média', 'carne');

Insert into Acao (nome, descricao)
	VALUES
		('cozer', 'meter na agua quente'),
		('fritar', 'meter em oleo quente');


Insert into Passo (id_passo, descricao, timestamp, id_acao, duracao)
	VALUES
		(1, 'Meter ovos a cozer', '0073', 1, 300),
		(2, 'Fritas os bifes', '0010', 2, 450),
		(3, 'Fritar os cogumelos', '0017', 2, null);


Insert into ReceitaPasso (id_passo, id_receita, numero)
	VALUES
		(2, 1, 1),
		(1, 1, 2),
		(3, 1, 3);


Insert into Ingrediente (designacao, imagem)
	VALUES
		('cogumelo', '~/Images/cogumelos.jpg'),
		('bife', '~/Images/bife.jpg'),
		('óleo', '~/Images/oleo.jpg');


Insert into PassoIngrediente (id_passo, id_ingrediente, quantidade)
	VALUES
		(3, 1, 16),
		(2, 2, 2),
		(2, 3, 1);


Insert into ReceitaIngrediente (id_receita, id_ingrediente, quantidade)
	VALUES
		(1, 1, 16),
		(1, 2, 4),
		(1, 3, 1);




Insert into Localizacao (id_localizacao, nome, coordenadas)
	VALUES
		(1, 'Jumbo', 'Ali'),
		(2, 'Pingo Doce', 'Aqui');


Insert into IngredienteLocalizacao (id_localizacao, id_ingrediente)
	VALUES
		(1, 1),
		(2, 2),
		(2, 3);



SELECT * FROM ReceitaUtilizador;
Delete from ReceitaUtilizador;
Delete from ReceitaIngrediente;

SELECT * FROM PassoIngrediente;
DELETE FROM PassoIngrediente;

SELECT * FROM Ingrediente;
DELETE FROM Ingrediente;

SELECT * FROM Acao;
DELETE FROM Acao;



Select * from Utilizador;
Delete from Utilizador;

SELECT * FROM  Receita;
DELETE FROM Receita;


SELECT * FROM ReceitaPasso;
DELETE FROM ReceitaPasso;
