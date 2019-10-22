Feature: Prateleira
	Pendurar uma Prateleira

@mytag
Scenario: Montagem de Prateleira
	Given Possuo 1 Regua Grande
	And 1 Nivel
	And 4 Parafusos e Buchas
	And 1 Chave de Fenda
	And 1 Furadeira
	And 1 Lapis
	And 1 Prateleira
	When Com o Nivel, nivelar os furos e medir com a Regua Grande, e marcar com o Lapis
	When Feito procedimento, pegue a furadeira aonde está marcado com o lapis e faça os furos
	When Feito os furos, coloque as Buchas
	When Coloque a prateleira, e pegue os 4 parafusos e a chave de fenda, parafuse.
	Then Prateleira foi pendura
