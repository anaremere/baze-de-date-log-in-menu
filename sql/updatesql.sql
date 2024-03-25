UPDATE Client SET Parola='$Parola',Nume='$Nume',Prenume='$Prenume',Telefon='$Telefon',Email='$Email',AdresaLivrare='$AdresaLivrare',AdresaFacturare='$AdresaFacturare'
WHERE ClientID='$ClientID'

UPDATE Adresa SET Telefon='$Telefon',TipAdresa='$TipAdresa',Judet='$Judet',Localitate='$Localitate',Strada=='$Strada',Numar='$Numar',CodPostal='$CodPostal',[Implicit?]='$[Implicit?]'
WHERE ClientID='$CliendID'

UPDATE Comanda SET ClientID='$ClientID',Stare='$Stare',ModPlata='$ModPlata',PretTotal='$PretTotal',DataPlasare='$DataPlasare',AdresaLivrare='$AdresaLivrare',AdresaFacturare='$AdresaFacturare'
WHERE ComandaID='$ComandaID'

UPDATE DetaliiComanda SET ProdusID='$ProdusID', Cantitate='$Cantitate',Total='$Total',Stare='$Stare' 
WHERE ComandaID='$ComandaID'

UPDATE StatusComanda SET StareComanda='$StareComanda',DataPlasare='$DataPlasare',ModPlata='$ModPlata',StarePlata='$StarePlata',DataLivrare='$DataLivrare'
WHERE ComandaID='$ComandaID'

UPDATE Produs SET NumeProdus='$NumeProdus',Categorie='$Categorie',Firma='$Firma',PretBuc='$PretBuc'
WHERE ProdusID='$ProdusID'