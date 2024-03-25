DELETE FROM Client WHERE ClientID='$ClientID'

DELETE FROM Adresa WHERE ClientID='$ClientID'

DELETE FROM Comanda WHERE ComandaID='$ComandaID'

DELETE FROM DetaliiComanda WHERE ComandaID='$ComandaID'

DELETE FROM StatusComanda WHERE ComandaID='$ComandaID'

DELETE FROM Produs WHERE ProdusID='$ProdusID'