Use WebChef;

INSERT INTO Receita (id_receita, nome, descricao, informacao_nutricional, duracao_prevista, link_ajuda, imagem, nr_pessoas, dificuldade, categoria)
	VALUES 
		(1, 'Bifinhos', 'com cogumelos', '50Kcal', '00:20:00.0000000', 'https://youtu.be/gS2WtZHvvWk?t=', '~/Images/sopaAgriao.jpg', 2, 'facil', 'carne'),
		(2, 'Massa', 'bolonhesa', '60Kcal', '00:40:00.0000000', 'www.ajuda.com', 'massa.jpg', 4, 'média', 'carne');
SELECT * FROM  Receita;
DELETE FROM Receita;



Insert into Acao (id_acao, nome, descricao)
	VALUES
		(1, 'cozer', 'meter na agua quente'),
		(2, 'fritar', 'meter em oleo quente');
SELECT * FROM Acao;
DELETE FROM Acao;



Insert into Passo (id_passo, descricao, timestamp, id_acao, duracao)
	VALUES
		(1, 'Meter ovos a cozer', '0073', 1, 300),
		(2, 'Fritas os bifes', '0010', 2, 450),
		(3, 'Fritar os cogumelos', '0017', 2, null);
SELECT * FROM Passo;
DELETE FROM Passo;



Insert into ReceitaPasso (id_passo, id_receita, numero)
	VALUES
		(2, 1, 1),
		(1, 1, 2),
		(3, 1, 3);
SELECT * FROM ReceitaPasso;
DELETE FROM ReceitaPasso;



Insert into Ingrediente (id_ingrediente, designacao, imagem)
	VALUES
		(1, 'cogumelo', '~/Images/cogumelos.jpg'),
		(2, 'bife', '~/Images/bife.jpg'),
		(3, 'óleo', '~/Images/oleo.jpg');
SELECT * FROM Ingrediente;
DELETE FROM Ingrediente;



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



SELECT * FROM PassoIngrediente;
DELETE FROM PassoIngrediente;






