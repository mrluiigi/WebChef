Use WebChef;

INSERT INTO Receita (id_receita, nome, descricao, informacao_nutricional, duracao_prevista, link_ajuda, imagem, nr_pessoas, dificuldade, categoria)
	VALUES 
		(1, 'Bifinhos', 'com cogumelos', '50Kcal', '00:20:00.0000000', 'https://youtu.be/gS2WtZHvvWk?t=', '~/Images/sopaAgriao.jpg', 2, 'facil', 'carne'),
		(2, 'Massa', 'bolonhesa', '60Kcal', '00:40:00.0000000', 'www.ajuda.com', 'massa.jpg', 4, 'média', 'carne');


Insert into Acao (id_acao, nome, descricao)
	VALUES
		(1, 'cozer', 'meter na agua quente'),
		(2, 'fritar', 'meter em oleo quente');


Insert into Passo (id_passo, descricao, timestamp, id_acao)
	VALUES
		(1, 'Meter ovos a cozer', '0073', 1),
		(2, 'Fritas os bifes', '0010', 2),
		(3, 'Fritar os cogumelos', '0017', 2);


Insert into ReceitaPasso (id_passo, id_receita, numero)
	VALUES
		(2, 1, 1),
		(1, 1, 2),
		(3, 1, 3);


Insert into Ingrediente (id_ingrediente, designacao, imagem)
	VALUES
		(1, 'cogumelo', '~/Images/cogumelos.jpg'),
		(2, 'bife', '~/Images/bife.jpg'),
		(3, 'óleo', '~/Images/oleo.jpg');


Insert into PassoIngrediente (id_passo, id_ingrediente, quantidade)
	VALUES
		(3, 1, 16),
		(2, 2, 2),
		(2, 3, 1);







SELECT * FROM Utilizador;

Delete from Ingrediente;


SELECT * FROM Receita;

Delete from Receita;





select * from ReceitaPasso;

delete from ReceitaPasso;
delete from Passo;

