use RostrosEF

ALTER TABLE Servicios
ADD CONSTRAINT FK_Servicios_Clientes
FOREIGN KEY (ClienteId)
REFERENCES Clientes(Id);