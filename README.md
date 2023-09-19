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
