Use WebChef;

Insert into Acao (nome, descricao)
	VALUES
		('Cortar aos cubos', 'Cortar em cubinhos um alimento'), -- 1
		('Espremer', ' Extrair, por compressão, o suco ou o líquido de um fruto ou de qualquer outro alimento'),
		('Marinar', 'Colocar um alimento, numa mistura de um líquido e temperos, durante um intervalo de tempo variado'),
		('Cortar', 'Cortar um alimento'),
		('Descascar', 'Tirar a casca de um alimento'), -- 5
		('Ferver água', 'Colocar uma panela com água ao lume e esperar que esta ferva'),
		('Adicionar à água ao lume', 'Adicionar algum alimento à água que está a ferver'),
		('Picar', 'Cortar em pedaços muito pequeninos qualquer tipo de alimento'),
		('Partir os ovos', 'Partir a casca do ovo de modo a aproveitar o conteúdo'),
		('Escalfar', 'Deixar estar algum tempo em água muito quente (a ferver)'), -- 10
		('Ralar', 'Raspar com o ralador; esmagar; moer; triturar'),
		('Polvilhar', 'Cobrir ou salpicar com uma especiaria ou alimento'),
		('Servir', 'Pôr na mesa num recipiente apropriado'); -- 13
-- SELECT * FROM Acao;
-- Delete from Acao;


Insert into Ingrediente (designacao, imagem)
	VALUES
		('Água', '~/Images/agua.jpg'),
		('Cebola', '~/Images/cebola.jpg'),
		('Tofu', '~/Images/tofu.jpg'),
		('Agrião', '~/Images/agriao.jpg'),
		('Ovo', '~/Images/ovo.jpg'),
		('Semente de sésamo', '~/Images/sementeSesamo.jpg'),
		('Alho', '~/Images/alho.jpg'),
		('Molho de soja', '~/Images/molhoSoja.jpg'),
		('Folha de louro', '~/Images/folhaLouro.jpg'),
		('Pimenta', '~/Images/pimenta.jpg'),
		('Lima', '~/Images/lima.jpg'),
		('Coentros', '~/Images/coentros.jpg'),
		('Alho-francês', '~/Images/alhoFrances.jpg'),
		('Gengibre', '~/Images/gengibre.jpg'),
		('Alho-Francês em tiras', '~/Images/alhoFrancesTiras.jpg'),
		('Casca de lima', '~/Images/cascaLima.jpg'),
		('Cebola cortada', '~/Images/cebolaCortada.jpg'),
		('Cebola descascada', '~/Images/cebolaDescascada.jpg'),
		('Coentros picados', '~/Images/coentrosPicada.jpg'),
		('Dentes de alho', '~/Images/dentesAlho.jpg'),
		('Gengibre ralado', '~/Images/gengibreRalado.jpg'),
		('Ovo escalfado', '~/Images/ovoEscalfado.jpg'),
		('Sumo de lima', '~/Images/sumoLima.jpg'),
		('Ovo sem casca', '~/Images/ovoAberto.jpg'),
		('Marinada', '~/Images/marinada.jpg');
-- SELECT * FROM Ingrediente;
-- Delete from Ingrediente;


Insert into Localizacao (id_localizacao, nome, coordenadas)
	VALUES
		(1, 'Jumbo', 'Ali'),
		(2, 'Pingo Doce', 'Aqui');
-- SELECT * FROM Localizacao;
-- Delete from Localizacao;


Insert into Passo (id_passo, descricao, timestamp, id_acao, duracao)
	VALUES
		(1, 'Cortar aos cubos', '0073', 1, null),
		(2, 'Espremer', '0010', 2, null),
		(3, 'Marinar', '0010', 3, 7200),
		(4, 'Cortar casca', '0010', 4, null),
		(5, 'Descascar', '0010', 5, null),
		(6, 'Descascar', '0010', 5, null),
		(7, 'Cortar', '0010', 4, null),
		(8, 'Ferver água ao lume', '0010', 6, null),
		(9, 'Adicionar à água ao lume', '0010', 7, null),
		(10, 'Cortar em tiras', '0010', 4, null),
		(11, 'Picar', '0010', 8, null),
		(12, 'Adicionar à água ao lume', '0010', 7, null),
		(13, 'Partir os ovos', '0010', 9, null),
		(14, 'Escalfar', '0010', 10, 180),
		(15, 'Servir', '0010', 13, null),
		(16, 'Ralar', '0010', 11, null),
		(17, 'Polvilhar', '0010', 12, null),
		(18, 'Polvilhar', '0017', 12, null);
-- SELECT * FROM Passo;
-- Delete from Passo;


INSERT INTO Receita (nome, descricao, informacao_nutricional, duracao_prevista, link_ajuda, imagem, nr_pessoas, dificuldade, categoria)
	VALUES 
		('Sopa de Agrião', 'Sopa de agrião', '50|15|2|13|23|4|2|3|', 1800, 'https://www.youtube.com/embed/gS2WtZHvvWk?start=', '~/Images/sopaAgriao.jpg', 4, 'Médio', 'Prato Principal'),
		('Massa', 'bolonhesa', '50|15|2|13|23|4|2|3|', 400, 'https://youtu.be/gS2WtZHvvWk?start=', '~/Images/oleo.jpg', 4, 'média', 'carne');
-- SELECT * FROM Receita;
-- Delete from Receita;


INSERT INTO Utilizador(nome, email, password)
	VALUES
		('admin', 'admin@gmail.com', '21232f297a57a5a743894a0e4a801fc3');
-- SELECT * FROM Utilizador;
-- Delete from Utilizador;


Insert into IngredienteLocalizacao (id_localizacao, id_ingrediente)
	VALUES
		(1, 1),
		(2, 2),
		(2, 3);
-- SELECT * FROM IngredienteLocalizacao;
-- Delete from IngredienteLocalizacao;


Insert into IngredientePreferidoUtilizador(id_ingrediente, id_utilizador, favorito)
	VALUES
		(1, 1, 's'),
		(2, 1, 'n');
-- SELECT * FROM IngredientePreferidoUtilizador;
-- Delete from IngredientePreferidoUtilizador;


Insert into PassoIngrediente (id_passo, id_ingrediente, quantidade)
	VALUES
		(1, 3, '200 g'),
		
		(2, 11, '1 unidade'),
		
		(3, 3, '200 g'),
		(3, 23, null),
		(3, 8, '1 colher de chá'),
		(3, 10, '1 colher de café'),

		(4, 11, '1 unidade'),
		
		(5, 7, '1 unidade'),
		
		(6, 2, '125 g'),
		
		(7, 18, null),
		
		(8, 1, '800 ml'),

		(9, 17, null),
		(9, 9, '1 unidade'),
		(9, 20, '4 unidades'),
		(9, 16, null),

		(10, 13, '100 g'),

		(11, 12, '20 g'),

		(12, 15, null),
		(12, 4, '600 g'),
		(12, 3, '200 g'),
		(12, 25, null),
		(12, 19, null),

		(13, 5, '4 unidades'),

		(14, 24, '4 unidade'),

		(15, 1, null),

		(16, 14, '10 g'),

		(17, 21, null),

		(18, 6, null);
-- SELECT * FROM PassoIngrediente;
-- Delete from PassoIngrediente;


Insert into ReceitaIngrediente (id_receita, id_ingrediente, quantidade)
	VALUES
		(1, 1, '800 ml'),
		(1, 2, '125 g'),
		(1, 3, '200 g'),
		(1, 4, '600 g'),
		(1, 5, '4 unidades'),
		(1, 6, '1 colher de sopa'),
		(1, 7, '4 unidades'),
		(1, 8, '1 colher de chá'),
		(1, 9, '1 unidade'),
		(1, 10, '1 colher de café'),
		(1, 11, '1 unidade'),
		(1, 12, '20 g'),
		(1, 13, '100 g'),
		(1, 14, '10 g');
-- SELECT * FROM ReceitaIngrediente;
-- Delete from ReceitaIngrediente;


Insert into ReceitaPasso (id_passo, id_receita, numero)
	VALUES
		(1, 1, 1),
		(2, 1, 2),
		(3, 1, 3),
		(4, 1, 4),
		(5, 1, 5),
		(6, 1, 6),
		(7, 1, 7),
		(8, 1, 8),
		(9, 1, 9),
		(10, 1, 10),
		(11, 1, 11),
		(12, 1, 12),
		(13, 1, 13),
		(14, 1, 14),
		(15, 1, 15),
		(16, 1, 16),
		(17, 1, 17),
		(18, 1, 18);
-- SELECT * FROM ReceitaPasso;
-- Delete from ReceitaPasso;


Insert into ReceitaUtilizador(id_receita, id_utilizador, duracao, favorita, avaliacao_dificuldade, dia_da_semana, classificacao, data_realizacao, anotacao, refeicao, timeInicio)
	VALUES
		(1, 1, NULL, 's', 'Fácil', NULL, 4, NULL, 'Muito bom', NULL, NULL);
-- SELECT * FROM ReceitaUtilizador;
-- Delete from ReceitaUtilizador;		