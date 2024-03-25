/* 1) afisam nr de comenzi plasate de un client*/
SELECT C.ClientID, COUNT(C.ComandaID) AS NrComenziPlasate
FROM Comanda C INNER JOIN Client CL ON C.ClientID=cl.ClientID
GROUP BY C.ClientID

/*2) afisam cate produse au fost comandate*/
SELECT P.NumeProdus,SUM(DC.Cantitate) AS NrBucatiComandate
FROM DetaliiComanda DC INNER JOIN Produs P ON P.ProdusID=dc.ProdusID
GROUP BY P.NumeProdus

/*3) afisam toate produsele de la firma  Pedigree*/
SELECT NumeProdus
FROM Produs
WHERE Firma='Pedigree'

/*4) afisam toati clientii ale caror comenzi sunt sunt in curs de procesare*/
SELECT cl.Nume+' '+cl.Prenume AS NumePrenume,co.ComandaID
FROM Comanda co INNER JOIN Client cl ON CO.ClientID=CL.ClientID
WHERE co.Stare='In procesare'

/* 5) afisam toate comenzile ale persoanelor cu numele 'Hristu' sau care locuiesc in bucuresti*/
SELECT ComandaID
FROM Comanda C,Client CL
WHERE cl.ClientID=c.ClientID AND CL.Nume='Hristu' 

UNION

SELECT C.ComandaID
FROM Comanda C, Adresa A
WHERE C.ClientID=A.ClientID AND A.Localitate='Bucuresti'

/* 6) afisam produsele in functie de pret*/
SELECT NumeProdus
FROM Produs
ORDER BY PretBuc

/* 7) afisam cate produse apartin comenzilor in stare de in curs de livrare*/
SELECT I.NumeProdus,I.Cantitate 
FROM (SELECT P.NumeProdus,SUM(DC.Cantitate) AS Cantitate
	 FROM DetaliiComanda DC INNER JOIN 
			(SELECT D.ComandaID
			FROM DetaliiComanda D INNER JOIN StatusComanda S ON D.ComandaID=S.ComandaID
			WHERE S.StareComanda='In curs de livrare'
			) AS LC ON DC.ComandaID=LC.ComandaID
			INNER JOIN Produs P ON P.ProdusID=DC.ProdusID
	 GROUP BY P.NumeProdus
	 ) AS I
GROUP BY I.Cantitate,I.NumeProdus

/* 8) numele ID-ul comenzilor cu un total mai mare de 500 de lei*/
SELECT DC.ComandaID
FROM DetaliiComanda DC
WHERE 500>(SELECT SUM(P.Total)
			FROM DetaliiComanda P 
			WHERE P.ComandaID=DC.ComandaID) 

/* 9) numele produselor ce tb livrate in cLUJ*/
SELECT P.NumeProdus
FROM Produs P INNER JOIN DetaliiComanda DC ON P.ProdusID=DC.ProdusID 
			  INNER JOIN Comanda C ON DC.ComandaID=C.ComandaID
			  INNER JOIN Client CL ON CL.ClientID=C.ClientID
			  INNER JOIN Adresa A ON A.ClientID=CL.ClientID 
WHERE A.Judet='Cluj'
GROUP BY P.NumeProdus