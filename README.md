# Inicijalne upute za izradu zadaća
Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno kreirali **repozitorij** koji ćete koristiti za izradu vašeg projekta, tj. za pisanje vaših triju zadaća. To će uključivati izradu dokumentacije i programskog kôda.

Molim vas izmijenite ovaj dokument kako biste u njemu naveli naziv i kratak opis projekta koji obrađujete u vašim zadaćama, kao i vaše osobne podatke. Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanja vaše projektne dokumentacije obavezno pogledajte upute o sintaksi koje su dostupne na Moodleu, a dodatno i [ovaj link](https://guides.github.com/features/mastering-markdown/).

A sada, vrijeme je za prvi korak rada na vašem projektu. 🙂 Za upis/opis vašeg programskog proizvoda molimo vas koristite **predložak** koji je naveden u nastavku. Započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta te izbrišite sve što je iznad _Naziva projekta_, kao i sve upute koje su navedene u zagradama u predlošku ispod.

# Softver za nadgledanje potrošnje energije javnih zgrada

## Podaci o studentu

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Jakov Ferko | jferko21@student.foi.hr | 0016153865 | jferko21


## Opis domene
Trenutni problem gradskog ureda za energetiku je to što nema automatsko praćenje kvalitete i kvaniteta energetske opskrbe, energetske potrošnje i pokazatelja na području grada.
Ideja rješenja tog problema je da se uvede sustav koji će pratit i prikupljat navedene podatke, imat mogućnost ispisa i generiranja podataka radi planiranja i reagiranja na neuobičajene potrošnje i situacije. 

## Specifikacija projekta
* Praćenje kvalitete i kvaniteta energetske opskrbe
* Praćenje energetske potrošnje
* Praćenje pokazazelja na području grada
* Izrada Centralne računalne aplikacije koja nam omogućuje prikupljanje i praćenje tih podataka (svih energenata i vode), te generiranje dokumenta
* Automatsko mjesečno generiranje računa (CRU)

<br/>

* CRU će biti glavni dio ISa, a ostale funkcije će biti implementirane preko modula koji prikupljaju podatke:
  * **Modul podaci** - Prikupljanje statičkih i dinamičkih podataka o zgradama i proizvodnim objektima, te o potrošnji energenata. Podaci o zgrada se unose rulno, a potrošnja energenata se unosi ručno ili automatski (potrebna simulacija kod automatskog)
  * **Modul pračenja** - Omogućuje ispis trenutne potrošnje u svrhu pravovremenog reagiranja i odlučivanja, te prepoznavanje neuobičajene potrošnje.
  * **Modul planiranje** - Planiranje potrebnih financijskih sredstavana za portrošnju energije i energenata temeljem stvarnih podataka, te planiranje potrošnje za sljedeću godinu
  * **Modul podrška** - Uključuje aplikacijsku podršku, dokumentaciju, te bazu znanja.
  

## Zadatak
[Korisnički zahtjevi - nadgledanje potrošnje energije javnih zgrada.pdf](/korisnicki_zahtjevi_nadgledanje_potrošnje_energije_javnih_zgrada.pdf)

## Resursi

Svi resursi nalaze se u mapi _Documentation_.
