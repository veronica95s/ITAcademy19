--1.	Qual a quantidade de endereços por estado?

SELECT estados.uf, COUNT(*)
FROM estados
-- junção entre as tabelas estados e cidades usando a coluna uf 
JOIN cidades ON estados.uf = cidades.uf
-- junçãoentre as tabelas cidades e enderecos usando a coluna cod_cidade
JOIN enderecos ON cidades.cod_cidade = enderecos.cod_cidade
-- Agrupa os dados com base nos valores únicos na coluna uf
GROUP BY estados.uf;


--2.	Qual a quantidade de clientes de cada estado?
SELECT estados.uf, COUNT(DISTINCT clientes.cod_cliente)
FROM estados
JOIN cidades ON estados.uf = cidades.uf
JOIN enderecos ON cidades.cod_cidade = enderecos.cod_cidade
JOIN clientes_enderecos ON enderecos.cod_endereco = clientes_enderecos.cod_endereco
JOIN clientes ON clientes_enderecos.cod_cliente = clientes.cod_cliente
GROUP BY estados.uf;


--3.	Qual o ranking de estados por quantidade de clientes, ou seja, em ordem decrescente de quantidade de clientes?
SELECT estados.uf, COUNT(DISTINCT clientes.cod_cliente)
FROM estados
JOIN cidades ON estados.uf = cidades.uf
JOIN enderecos ON cidades.cod_cidade = enderecos.cod_cidade
JOIN clientes_enderecos ON enderecos.cod_endereco = clientes_enderecos.cod_endereco
JOIN clientes ON clientes_enderecos.cod_cliente = clientes.cod_cliente
GROUP BY estados.uf
ORDER BY COUNT(DISTINCT clientes.cod_cliente) DESC;


--4.	Qual o ranking de regiões por quantidade de clientes, ou seja, em ordem decrescente de quantidade de clientes?
SELECT regiao, COUNT(DISTINCT clientes.cod_cliente)
FROM estados
JOIN cidades USING(uf)
JOIN enderecos USING(cod_cidade)
JOIN clientes_enderecos USING(cod_endereco)
JOIN clientes USING(cod_cliente)
GROUP BY regiao
ORDER BY COUNT(DISTINCT cod_cliente) DESC;


--5.	Qual a quantidade de pedidos por região?
SELECT regiao, COUNT(pedidos.num_pedido)
FROM estados
JOIN cidades ON estados.uf = cidades.uf
JOIN enderecos ON cidades.cod_cidade = enderecos.cod_cidade
JOIN clientes_enderecos ON enderecos.cod_endereco = clientes_enderecos.cod_endereco
JOIN pedidos ON clientes_enderecos.cod_cliente = pedidos.cod_cliente AND clientes_enderecos.cod_endereco = pedidos.cod_endereco
GROUP BY regiao
ORDER BY COUNT(pedidos.num_pedido) DESC;


--6.	Qual a quantidade de pedidos por ano e por região, considerando apenas os pedidos feitos nos anos de 2000 até 2004?
SELECT TO_CHAR(pedidos.data_emissao, 'yyyy'), estados.regiao, COUNT(pedidos.num_pedido)
FROM estados
JOIN cidades ON estados.uf = cidades.uf
JOIN enderecos ON cidades.cod_cidade = enderecos.cod_cidade
JOIN clientes_enderecos ON enderecos.cod_endereco = clientes_enderecos.cod_endereco
JOIN pedidos ON clientes_enderecos.cod_cliente = pedidos.cod_cliente AND clientes_enderecos.cod_endereco = pedidos.cod_endereco
WHERE TO_CHAR(pedidos.data_emissao, 'yyyy') BETWEEN '2000' AND '2004'
GROUP BY TO_CHAR(pedidos.data_emissao, 'yyyy'), estados.regiao
ORDER BY TO_CHAR(pedidos.data_emissao, 'yyyy'), estados.regiao;


--7.	Qual o valor total gasto por cliente, ordenado em ordem decrescente de valor total?
select cod_cliente, sum(quantidade * valor_unitario) 
from estados 
JOIN cidades ON estados.uf = cidades.uf
JOIN enderecos ON cidades.cod_cidade = enderecos.cod_cidade
JOIN clientes_enderecos ON enderecos.cod_endereco = clientes_enderecos.cod_endereco
JOIN pedidos ON clientes_enderecos.cod_cliente = pedidos.cod_cliente AND clientes_enderecos.cod_endereco = pedidos.cod_endereco
JOIN pedidos_produtos ON pedidos.num_pedido = pedidos_produtos.num_pedido
group by cod_cliente
order by sum(quantidade * valor_unitario) desc;

--8.	Qual o valor total gasto por cliente, ordenado em ordem decrescente de valor total, considerando apenas os clientes do Rio Grande do Sul?
select cod_cliente, sum(quantidade * valor_unitario)
from estados
JOIN cidades ON estados.uf = cidades.uf
JOIN enderecos ON cidades.cod_cidade = enderecos.cod_cidade
JOIN clientes_enderecos ON enderecos.cod_endereco = clientes_enderecos.cod_endereco
JOIN pedidos ON clientes_enderecos.cod_cliente = pedidos.cod_cliente AND clientes_enderecos.cod_endereco = pedidos.cod_endereco
JOIN pedidos_produtos ON pedidos.num_pedido = pedidos_produtos.num_pedido
where uf = 'RS'
group by cod_cliente
order by sum(quantidade * valor_unitario) desc;

--9.	Qual o valor total vendido por autor?
select cod_autor, sum( quantidade * valor_unitario )
from autores
JOIN autores_produtos ON autores.cod_autor = autores_produtos.cod_autor
JOIN produtos ON autores_produtos.cod_produto = produtos.cod_produto
JOIN pedidos_produtos ON produtos.cod_produto = pedidos_produtos.cod_produto
group by cod_autor;

--10.	Qual o valor médio faturado com as vendas por produto?
select cod_produto, avg( quantidade * valor_unitario )
from produtos
JOIN pedidos_produtos ON produtos.cod_produto = pedidos_produtos.cod_produto
group by cod_produto;

--11.	Qual o valor total de cada pedido?
select num_pedido, sum( quantidade * valor_unitario )
from pedidos
OIN pedidos_produtos ON pedidos.num_pedido = pedidos_produtos.num_pedid
group by num_pedido;

--12.	Qual o valor médio dos pedidos por estado?
select uf, sum(quantidade * valor_unitario) / count(distinct num_pedido)
from estados 
JOIN cidades ON estados.uf = cidades.uf
JOIN enderecos ON cidades.cod_cidade = enderecos.cod_cidade
JOIN clientes_enderecos ON enderecos.cod_endereco = clientes_enderecos.cod_endereco
JOIN pedidos ON clientes_enderecos.cod_cliente = pedidos.cod_cliente AND clientes_enderecos.cod_endereco = pedidos.cod_endereco
JOIN pedidos_produtos ON pedidos.num_pedido = pedidos_produtos.num_pedido
group by uf;
