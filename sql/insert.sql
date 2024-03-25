INSERT INTO Client(ClientID,Parola,Nume,Prenume,Telefon,Email,AdresaLivrare,AdresaFacturare)
VALUES ('$ClientID','$Parola','$Nume','$Prenume','$Telefon','$Email','$AdresaLivrare','$AdresaFacturare')

INSERT INTO Adresa(ClientID,Telefon,TipAdresa,Judet,Localitate,Strada,Numar,CodPostal,[Implicit?])
VALUES('$ClientID','$Telefon','$TipAdresa','$Judet','$Localitate','$Strada','$Numar','$CodPostal','$[Implicit?]')

INSERT INTO Comanda(ComandaID,ClientID,Stare,ModPlata,PretTotal,DataPlasare,AdresaLivrare,AdresaFacturare)
VALUES('$ComandaID','$ClientID','$Stare','$ModPlata','$PretTotal','$DataPlasare','$AdresaLivrare','$AdresaFacturare')

INSERT INTO DetaliiComanda(ComandaID,ProdusID,Cantitate,Total,Stare)
VALUES('$ComandaID','$ProdusID','$Cantitate','$Total','$Stare')

INSERT INTO StatusComanda(ComandaID,StareComanda,DataPlasare,ModPlata,StarePlata,DataLivrare)
VALUES('$ComandaID','$StareComanda','$DataPlasare','$ModPlata','$StarePlata','$DataLivrare')

INSERT INTO Produs(ProdusID,NumeProdus,Categorie,Firma,PretBuc)
VALUES('$ProdusID','$NumeProdus','$Categorie','$Firma','$PretBuc')