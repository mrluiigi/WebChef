Use WebChef;

INSERT INTO Receita (id_receita, nome, descricao, informacao_nutricional, duracao_prevista, link_ajuda, imagem, nr_pessoas, dificuldade, categoria)
	VALUES 
		(1, 'Bifinhos', 'com cogumelos', '50Kcal', '00:20:00.0000000', 'www.google.com', 'coise', 2, 'facil', 'carne'),
		(2, 'Massa', 'bolonhesa', '60Kcal', '00:40:00.0000000', 'www.ajuda.com', 'massa.jpg', 4, 'média', 'carne');


SELECT * FROM Receita;

Delete from Receita;




select * from ReceitaPasso;

delete from ReceitaUtilizador;


Insert into Acao (id_acao, nome, descricao)
	VALUES
		(1, 'cozer', 'meter na agua quente'),
		(2, 'fritar', 'meter em oleo quente');


Insert into Passo (id_passo, descricao, timestamp, id_acao)
	VALUES
		(1, 'Meter ovos a cozer', '00:05:00.0000000', 1),
		(2, 'Fritas os bifes', '00:05:00.0000000', 2),
		(3, 'Fritar os cogumelos', '00:05:00.0000000', 3),;


Insert into ReceitaPasso (id_passo, id_receita, numero)
	VALUES
		(2, 1, 1),
		(1, 1, 2),
		(3, 1, 3);



SELECT * FROM Utilizador;

Delete from Utilizador;



