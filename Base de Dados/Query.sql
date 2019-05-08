Use WebChef;

INSERT INTO Receita (id_receita, nome, descricao, informacao_nutricional, duracao_prevista, link_ajuda, imagem, nr_pessoas, dificuldade, categoria)
	VALUES 
		(1, 'Bifinhos', 'com cogumelos', '50Kcal', '00:20:00.0000000', 'www.google.com', 'coise', 2, 'facil', 'carne'),
		(2, 'Massa', 'bolonhesa', '60Kcal', '00:40:00.0000000', 'www.ajuda.com', 'massa.jpg', 4, 'média', 'carne');


SELECT * FROM Receita;

Delete from Receita;



Insert into ReceitaUtilizador (id_receita, id_utilizador, duracao, favorita, avaliacao_dificuldade, dia_da_semana, classificacao,
								data_realizacao, anotacao)
		values
				(1,1, '00:20:00.0000000', 'S', 'facil', 'segunda', 3, '2019-04-03', 'oiii');

select * from ReceitaUtilizador;

delete from ReceitaUtilizador;




SELECT * FROM Utilizador;

Delete from Utilizador;



