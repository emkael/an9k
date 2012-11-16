Analizator9000 - README

0. SPIS ZAWARTOåCI
==================

    1. Wprowadzenie
    2. Wymagania systemowe
    3. Instalacja
    4. PodrÍcznik uøycia
    5. Kod ürÛd≥owy
    6. Autorzy
    7. Wsparcie i informacje kontaktowe
    8. Historia zmian
    9. Licencja

1. WPROWADZENIE
===============

Analizator9000 jest aplikacjπ oferujπcπ graficzny interfejs uøytkownika dla
analizy statystycznej liczby lew w rozdaniach brydøowych wygenerowanych na
podstawie okreúlonych warunkÛw.

Program stanowi interfejs dla programu Dealer oraz dla biblioteki libbcalcDDS,
bÍdπcej czÍúciπ projektu BCalc. Aby dowiedzieÊ siÍ wiÍcej o tych programach,
skieruj siÍ do sekcji "AUTORZY".

2. WYMAGANIA SYSTEMOWE
======================

Analizator9000 dzia≥a w úrodowisku .NET 3.5 Client Profile i jako taki wymaga
platformy kompatybilnej ze úrodowiskiem .NET 3.5.

Wymagania sprzÍtowe platformy .NET 3.5:

    * system operacyjny Windows XP/Vista/Server 2003/Server 2008/7/8 lub nowszy
     (systemy Windows 7, Windows Server 2008 R2 oraz Windows 8 i nowsze
      dostarczajπ .NET 3.5 wraz z podstawowπ instalacjπ systemu)
    * procesor: rÛwnowaøny Pentium 400MHz (minimalny); Pentium 1GHz (zalecany)
    * pamiÍÊ RAM: 96MB (minimalna); 256MB (zalecana)

Wymagania specyficzne dla aplikacji:

    * ekran: minimalna rozdzielczoúÊ 1024x600px; kolory 16-bit
    * wolne miejsce na dysku: minimum 500MB (.NET 3.5) + 5MB (Analizator9000)
    * dodatkowe miejsce na dysku: 1MB na pe≥nπ analizÍ kaødego tysiπca rozdaÒ

UWAGA!
    Aplikacja moøe potrzebowaÊ bardzo duøej iloúci zasobÛw systemowych w
zaleønoúci od rozmiaru wykonywanego zadania. Nieodpowiedzialny dobÛr parametrÛw
generowania rozdaÒ/analizy moøe doprowadziÊ do znaczπco d≥ugiego czasu
wykonywania programu, zawieszenia jego dzia≥ania bπdü, w przypadkach skrajnych,
do ograniczenia jakoúci korzystania z systemu uøytkownika. Autor zaleca
ostroøny dobÛr parametrÛw uruchomienia w celu rozpoznania wydajnoúci aplikacji
i systemu uøytkownika.

3. INSTALACJA
=============

Program jest gotowy do uøycia po rozpakowaniu go do dowolnego katalogu na
lokalnym dysku twardym.

Aktualnπ wersjÍ programu moøna pobraÊ ze strony domowej projektu:
    http://emkael.info/brydz/an9k/

Program po rozpakowaniu niezbÍdnie wymaga obecnoúci dwÛch katalogÛw
(dostarczonych w archiwum):

    * katalogu bin/ - zawierajπcego programy zewnÍtrzne uøywane przez analizator
      (plik lbcalcdds.dll naleøπcy do projektu BCalc, plik wykonywalny
       dealer.exe, naleøπcy do projektu Dealer oraz bibliotekÍ cygwin1.dll,
       wymaganπ do uruchomienia programu Dealer)
    * pustego katalogu files/ - do ktÛrego zapisywane sπ wyniki dzia≥ania
      programu

4. PODR CZNIK UØYCIA
====================

Opis uøycia programu wraz ze zrzutami ekranu oraz przyk≥adowymi wynikami
dostÍpny jest na stronie domowej programu:
    http://emkael.info/brydz/an9k/manual/

5. KOD èR”D£OWY
===============

P: W jakim jÍzyku programowania napisany jest Analizator9000?
O: C#.

P: Czy mogÍ zobaczyÊ kod ürÛd≥owy programu?
O: Oczywiúcie!

P: Skπd mogÍ go pobraÊ?
O: Z repozytorium Subversion dostÍpnego pod adresem:
    https://emkael.info/svn/an9k/

P: Dlaczego przy prÛbie pobrania kodu ürÛd≥owego otrzymujÍ komunikat b≥Ídu o
   nieprawid≥owym certyfikacie HTTPS?
O: Bo jestem skπpym i leniwym bydlakiem, ktÛremu nie chce siÍ wykupiÊ
   porzπdnego certyfikatu SSL. Odcisk palca serwera:
    7c:48:1d:9a:73:d0:e6:2d:36:10:4d:d0:dc:f6:da:96:fb:3a:33:c7

P: Ale czy to nie znaczy, øe ktoú moøe podszyÊ siÍ pod serwer, na ktÛrym
   znajduje siÍ kod ürÛd≥owy, podmieniÊ odcisk palca serwera na w≥asny, a potem
   podstawiÊ mi z≥oúliwy kod ürÛd≥owy, ktÛry skompilujÍ, uruchomiÍ, a mÛj
   komputer ukradnie mi dane moich wszystkich kart kredytowych, nakupi mnÛstwo
   úmieci na Allegro, a potem wybuchnie, kiedy bÍdÍ potrzebowaÊ pilnie
   wydrukowaÊ zeznanie podatkowe?
O: Dok≥adnie tak. Co wiÍcej, ninejszy dokument dystrybuowany jest za
   poúrednictwem nieuwietrzytelnionego po≥πczenie HTTP, wiÍc nic nie stoi na
   przeszkodzie, øe juø siÍ sta≥o, a to pytanie jest tu tylko dla niepoznaki.

P: W jakim úrodowisku powsta≥ program?
O: Microsoft Visual Studio/Visual C# 2010.

P: Czy mogÍ prosiÊ o dopisanie kodu dla funkcjonalnoúci X?
O: Proúcie, a bÍdzie Wam dane.

P: Dopisa≥em do kodu funkcjonalnoúÊ X. Czy moøesz do≥πczyÊ jπ do swojej edycji
   programu?
O: Jeúli jest sensowna i bÍdÍ w stanie zrozumieÊ jej kod ürÛd≥owy bez
   koniecznoúci uciekania siÍ do napojÛw alkoholowych powyøej 8% zawartoúci,
   oczywiúcie.

6. AUTORZY
==========

Analizator9000:
    Micha≥ Klichowicz (mkl/emkael)
    WWW: http://emkael.info
    e-mail: emkael@tlen.pl

Dealer:
    Obecny zarzπdca kodu: Henk Uijterwaal
    WWW: http://henku.home.xs4all.nl/html/dealer/authors.html

Bridge Calculator (bcalc):
    Piotr Beling
    WWW: http://bcalc.w8.pl/

Ikona programu:
    Tonev
    WWW: http://www.iconarchive.com/show/windows-7-icons-by-tonev.html

7. WSPARCIE I INFORMACJE KONTAKTOWE
===================================

Zg≥oszenia b≥ÍdÛw, sugestie usprawnieÒ oraz wszelkie komentarze natury ogÛlnej
naleøy kierowaÊ bezpoúrednio do autora, drogπ elektronicznπ.
Naj≥atwiej skontaktowaÊ siÍ z autorem poprzez pocztÍ elektronicznπ:
    emkael@tlen.pl
Moøna rÛwnieø odwiedziÊ ForumBridge.pl i podrzuciÊ prywatnπ wiadomoúÊ
uøytkownikowi mkl:
    http://www.forumbridge.pl/private.php?do=newpm&u=360
bπdü odnaleüÊ na Forum odpowiedni wπtek i dodaÊ w nim wiadomoúÊ.

Zg≥aszane b≥Ídy bÍdπ badane oraz poprawiane w miarÍ moøliwoúci autora, przy
czym oczekuje siÍ, øe wraz ze zg≥oszeniem b≥Ídu uøytkownik bÍdzie w stanie
dostarczyÊ podstawowych informacji s≥uøπcych do odtworzenia b≥Ídu bπdü bÍdzie
dysponowaÊ wystarczajπcymi umiejÍtnoúciami z zakresu ogÛlnej obs≥ugi komputera,
by te informacje zebraÊ na proúbÍ autora.

Autor zastrzega sobie prawo do traktowania propozycji ulepszeÒ oraz zmian
funkcjonalnych z dowolnie dobranπ dozπ sceptycyzmu.

Jeúli znajdujesz mÛj program uøytecznym, i chcia≥byú mi za niego podziÍkowaÊ,
moøesz napisaÊ do mnie maila i daÊ mi znaÊ, øe Ci siÍ spodoba≥.
Jeúli chcia≥byú go przerobiÊ, uøyÊ jako czÍúÊ wiÍkszego projektu lub
zaproponowaÊ jakiekolwiek inne jego zastosowanie poza hobbystycznymi analizami,
rÛwnieø napisz do mnie maila, zobaczymy, co siÍ da zrobiÊ.
Jeúli za pomocπ mojego programu odkry≥eú jakieú ciekawe wyniki bπdü doszed≥eú
do zaskakujπcych wnioskÛw, tym bardziej napisz maila.
Jeúli nie jesteú pewien, czy napisaÊ do mnie w jakiejú sprawie zwiπzanej z
programem, napisz maila. LubiÍ czytaÊ maile.

Jeúli znajdujesz mÛj program na tyle uøytecznym, øeby chcieÊ podziÍkowaÊ mi za
niego materialnie, masz pecha. Nie przyjmujÍ dotacji pieniÍønych, a program
jest w pe≥ni darmowy i niekomercyjny. LubiÍ za to rÛwnieø interesujπce ksiπøki
i dobre piwo.

8. HISTORIA ZMIAN
=================

2012.11 - 0.9
    * pierwotna wersja programu

9. LICENCJA
===========

Licencja BSD (dwuklauzulowa)

Copyright (c) 2012, Micha≥ Klichowicz
Wszystkie prawa zastrzeøone

Redystrybucja i uøywanie, czy to w formie kodu ürÛd≥owego, czy w formie kodu
wykonywalnego, jest dozwolone pod warunkiem spe≥nienia poniøszych warunkÛw:

    * Redystrybucja kodu ürÛd≥owego musi zawieraÊ powyøszπ notÍ o prawach
    autorskich, niniejszπ listÍ warunkÛw oraz poniøsze oúwiadczenie o wy≥πczeniu
    odpowiedzialnoúci.

    * Redystrybucja kodu wykonywalnego musi zawieraÊ powyøszπ notÍ o prawach
    autorskich, niniejszπ listÍ warunkÛw oraz poniøsze oúwiadczenie o wy≥πczeniu
    odpowiedzialnoúci w dokumentacji i/lub w innych materia≥ach dostarczanych
    wraz z kopiπ oprogramowania.

TO OPROGRAMOWANIE JEST DOSTARCZONE PRZEZ MICHA£A KLICHOWICZA "TAKIM, JAKIE
JEST". KAØDA DOROZUMIANA LUB BEZPOåREDNIO WYRAØONA GWARANCJA, NIE WY£•CZAJ•C
DOROZUMIANEJ GWARANCJI PRZYDATNOåCI HANDLOWEJ I PRZYDATNOåCI DO OKREåLONEGO
ZASTOSOWANIA, JEST WY£•CZONA. W ØADNYM WYPADKU POSIADACZE PRAW AUTORSKICH NIE
MOG• BY∆ ODPOWIEDZIALNI ZA JAKIEKOLWIEK BEZPOåREDNIE, POåREDNIE, PRZYPADKOWE,
SPECJALNE, UBOCZNE I WT”RNE SZKODY (NIE WY£•CZAJ•C OBOWI•ZKU DOSTARCZENIA
PRODUKTU ZAST PCZEGO LUB SERWISU, ODPOWIEDZIALNOåCI Z TYTU£U UTRATY
UØYTECZNOåCI, UTRATY DANYCH LUB KORZYåCI, A TAKØE PRZERW W PRACY
PRZEDSI BIORSTWA), SPOWODOWANE W JAKIKOLWIEK SPOS”B, I W JAKIMKOLWIEK MODELU
ODPOWIEDZIALNOåCI, KONTRAKTOWEJ, CA£KOWITEJ LUB DELIKTOWEJ (WYNIK£EJ ZAR”WNO Z
NIEDBALSTWA JAK INNYCH POSTACI WINY), POWSTA£E W JAKIKOLWIEK SPOS”B W WYNIKU
UØYWANIA LUB MAJ•CE ZWI•ZEK Z UØYWANIEM OPROGRAMOWANIA, NAWET JEåLI O MOØLIWOåCI
POWSTANIA TAKICH SZK”D OSTRZEØONO.

===

Who needs patience anymore, when all our pleasure's virtual?