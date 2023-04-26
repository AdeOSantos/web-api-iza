-- SQLite Insert

INSERT INTO Products (productName, price, description, photo)
VALUES ( "T-Shirt", "15.00", "Adidas T-Shirt", 1);


INSERT INTO Products (productName, price, description, photo)
VALUES ( "T-Shirt", "13.00", "Nike T-Shirt", 2);

INSERT INTO Clients (clientName, email, password)
VALUES ( "Adalberto Santos", "adalberto@gmail.com", "12345");

INSERT INTO Clients (clientName, email, password)
VALUES ( "Pedro Silva", "pedro@gmail.com", "12345");

INSERT INTO Addresses (clientId, location, number, city, state, cep)
VALUES ( 1, "Rua Um", 21, "Americana", "SP", 54321);

INSERT INTO Addresses (clientId, location, number, city, state, cep)
VALUES ( 2, "Av. Paulista", 1001, "Sao Paulo", "SP", 54632);