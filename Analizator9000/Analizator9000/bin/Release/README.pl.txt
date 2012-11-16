Analizator9000 - README

0. SPIS ZAWARTO�CI
==================

    1. Wprowadzenie
    2. Wymagania systemowe
    3. Instalacja
    4. Podr�cznik u�ycia
    5. Kod �r�d�owy
    6. Autorzy
    7. Wsparcie i informacje kontaktowe
    8. Historia zmian
    9. Licencja

1. WPROWADZENIE
===============

Analizator9000 jest aplikacj� oferuj�c� graficzny interfejs u�ytkownika dla
analizy statystycznej liczby lew w rozdaniach bryd�owych wygenerowanych na
podstawie okre�lonych warunk�w.

Program stanowi interfejs dla programu Dealer oraz dla biblioteki libbcalcDDS,
b�d�cej cz�ci� projektu BCalc. Aby dowiedzie� si� wi�cej o tych programach,
skieruj si� do sekcji "AUTORZY".

2. WYMAGANIA SYSTEMOWE
======================

Analizator9000 dzia�a w �rodowisku .NET 3.5 Client Profile i jako taki wymaga
platformy kompatybilnej ze �rodowiskiem .NET 3.5.

Wymagania sprz�towe platformy .NET 3.5:

    * system operacyjny Windows XP/Vista/Server 2003/Server 2008/7/8 lub nowszy
     (systemy Windows 7, Windows Server 2008 R2 oraz Windows 8 i nowsze
      dostarczaj� .NET 3.5 wraz z podstawow� instalacj� systemu)
    * procesor: r�wnowa�ny Pentium 400MHz (minimalny); Pentium 1GHz (zalecany)
    * pami�� RAM: 96MB (minimalna); 256MB (zalecana)

Wymagania specyficzne dla aplikacji:

    * ekran: minimalna rozdzielczo�� 1024x600px; kolory 16-bit
    * wolne miejsce na dysku: minimum 500MB (.NET 3.5) + 5MB (Analizator9000)
    * dodatkowe miejsce na dysku: 1MB na pe�n� analiz� ka�dego tysi�ca rozda�

UWAGA!
    Aplikacja mo�e potrzebowa� bardzo du�ej ilo�ci zasob�w systemowych w
zale�no�ci od rozmiaru wykonywanego zadania. Nieodpowiedzialny dob�r parametr�w
generowania rozda�/analizy mo�e doprowadzi� do znacz�co d�ugiego czasu
wykonywania programu, zawieszenia jego dzia�ania b�d�, w przypadkach skrajnych,
do ograniczenia jako�ci korzystania z systemu u�ytkownika. Autor zaleca
ostro�ny dob�r parametr�w uruchomienia w celu rozpoznania wydajno�ci aplikacji
i systemu u�ytkownika.

3. INSTALACJA
=============

Program jest gotowy do u�ycia po rozpakowaniu go do dowolnego katalogu na
lokalnym dysku twardym.

Aktualn� wersj� programu mo�na pobra� ze strony domowej projektu:
    http://emkael.info/brydz/an9k/

Program po rozpakowaniu niezb�dnie wymaga obecno�ci dw�ch katalog�w
(dostarczonych w archiwum):

    * katalogu bin/ - zawieraj�cego programy zewn�trzne u�ywane przez analizator
      (plik lbcalcdds.dll nale��cy do projektu BCalc, plik wykonywalny
       dealer.exe, nale��cy do projektu Dealer oraz bibliotek� cygwin1.dll,
       wymagan� do uruchomienia programu Dealer)
    * pustego katalogu files/ - do kt�rego zapisywane s� wyniki dzia�ania
      programu

4. PODR�CZNIK U�YCIA
====================

Opis u�ycia programu wraz ze zrzutami ekranu oraz przyk�adowymi wynikami
dost�pny jest na stronie domowej programu:
    http://emkael.info/brydz/an9k/manual/

5. KOD �R�D�OWY
===============

P: W jakim j�zyku programowania napisany jest Analizator9000?
O: C#.

P: Czy mog� zobaczy� kod �r�d�owy programu?
O: Oczywi�cie!

P: Sk�d mog� go pobra�?
O: Z repozytorium Subversion dost�pnego pod adresem:
    https://emkael.info/svn/an9k/

P: Dlaczego przy pr�bie pobrania kodu �r�d�owego otrzymuj� komunikat b��du o
   nieprawid�owym certyfikacie HTTPS?
O: Bo jestem sk�pym i leniwym bydlakiem, kt�remu nie chce si� wykupi�
   porz�dnego certyfikatu SSL. Odcisk palca serwera:
    7c:48:1d:9a:73:d0:e6:2d:36:10:4d:d0:dc:f6:da:96:fb:3a:33:c7

P: Ale czy to nie znaczy, �e kto� mo�e podszy� si� pod serwer, na kt�rym
   znajduje si� kod �r�d�owy, podmieni� odcisk palca serwera na w�asny, a potem
   podstawi� mi z�o�liwy kod �r�d�owy, kt�ry skompiluj�, uruchomi�, a m�j
   komputer ukradnie mi dane moich wszystkich kart kredytowych, nakupi mn�stwo
   �mieci na Allegro, a potem wybuchnie, kiedy b�d� potrzebowa� pilnie
   wydrukowa� zeznanie podatkowe?
O: Dok�adnie tak. Co wi�cej, ninejszy dokument dystrybuowany jest za
   po�rednictwem nieuwietrzytelnionego po��czenie HTTP, wi�c nic nie stoi na
   przeszkodzie, �e ju� si� sta�o, a to pytanie jest tu tylko dla niepoznaki.

P: W jakim �rodowisku powsta� program?
O: Microsoft Visual Studio/Visual C# 2010.

P: Czy mog� prosi� o dopisanie kodu dla funkcjonalno�ci X?
O: Pro�cie, a b�dzie Wam dane.

P: Dopisa�em do kodu funkcjonalno�� X. Czy mo�esz do��czy� j� do swojej edycji
   programu?
O: Je�li jest sensowna i b�d� w stanie zrozumie� jej kod �r�d�owy bez
   konieczno�ci uciekania si� do napoj�w alkoholowych powy�ej 8% zawarto�ci,
   oczywi�cie.

6. AUTORZY
==========

Analizator9000:
    Micha� Klichowicz (mkl/emkael)
    WWW: http://emkael.info
    e-mail: emkael@tlen.pl

Dealer:
    Obecny zarz�dca kodu: Henk Uijterwaal
    WWW: http://henku.home.xs4all.nl/html/dealer/authors.html

Bridge Calculator (bcalc):
    Piotr Beling
    WWW: http://bcalc.w8.pl/

Ikona programu:
    Tonev
    WWW: http://www.iconarchive.com/show/windows-7-icons-by-tonev.html

7. WSPARCIE I INFORMACJE KONTAKTOWE
===================================

Zg�oszenia b��d�w, sugestie usprawnie� oraz wszelkie komentarze natury og�lnej
nale�y kierowa� bezpo�rednio do autora, drog� elektroniczn�.
Naj�atwiej skontaktowa� si� z autorem poprzez poczt� elektroniczn�:
    emkael@tlen.pl
Mo�na r�wnie� odwiedzi� ForumBridge.pl i podrzuci� prywatn� wiadomo��
u�ytkownikowi mkl:
    http://www.forumbridge.pl/private.php?do=newpm&u=360
b�d� odnale�� na Forum odpowiedni w�tek i doda� w nim wiadomo��.

Zg�aszane b��dy b�d� badane oraz poprawiane w miar� mo�liwo�ci autora, przy
czym oczekuje si�, �e wraz ze zg�oszeniem b��du u�ytkownik b�dzie w stanie
dostarczy� podstawowych informacji s�u��cych do odtworzenia b��du b�d� b�dzie
dysponowa� wystarczaj�cymi umiej�tno�ciami z zakresu og�lnej obs�ugi komputera,
by te informacje zebra� na pro�b� autora.

Autor zastrzega sobie prawo do traktowania propozycji ulepsze� oraz zmian
funkcjonalnych z dowolnie dobran� doz� sceptycyzmu.

Je�li znajdujesz m�j program u�ytecznym, i chcia�by� mi za niego podzi�kowa�,
mo�esz napisa� do mnie maila i da� mi zna�, �e Ci si� spodoba�.
Je�li chcia�by� go przerobi�, u�y� jako cz�� wi�kszego projektu lub
zaproponowa� jakiekolwiek inne jego zastosowanie poza hobbystycznymi analizami,
r�wnie� napisz do mnie maila, zobaczymy, co si� da zrobi�.
Je�li za pomoc� mojego programu odkry�e� jakie� ciekawe wyniki b�d� doszed�e�
do zaskakuj�cych wniosk�w, tym bardziej napisz maila.
Je�li nie jeste� pewien, czy napisa� do mnie w jakiej� sprawie zwi�zanej z
programem, napisz maila. Lubi� czyta� maile.

Je�li znajdujesz m�j program na tyle u�ytecznym, �eby chcie� podzi�kowa� mi za
niego materialnie, masz pecha. Nie przyjmuj� dotacji pieni�nych, a program
jest w pe�ni darmowy i niekomercyjny. Lubi� za to r�wnie� interesuj�ce ksi��ki
i dobre piwo.

8. HISTORIA ZMIAN
=================

2012.11 - 0.9
    * pierwotna wersja programu

9. LICENCJA
===========

Licencja BSD (dwuklauzulowa)

Copyright (c) 2012, Micha� Klichowicz
Wszystkie prawa zastrze�one

Redystrybucja i u�ywanie, czy to w formie kodu �r�d�owego, czy w formie kodu
wykonywalnego, jest dozwolone pod warunkiem spe�nienia poni�szych warunk�w:

    * Redystrybucja kodu �r�d�owego musi zawiera� powy�sz� not� o prawach
    autorskich, niniejsz� list� warunk�w oraz poni�sze o�wiadczenie o wy��czeniu
    odpowiedzialno�ci.

    * Redystrybucja kodu wykonywalnego musi zawiera� powy�sz� not� o prawach
    autorskich, niniejsz� list� warunk�w oraz poni�sze o�wiadczenie o wy��czeniu
    odpowiedzialno�ci w dokumentacji i/lub w innych materia�ach dostarczanych
    wraz z kopi� oprogramowania.

TO OPROGRAMOWANIE JEST DOSTARCZONE PRZEZ MICHA�A KLICHOWICZA "TAKIM, JAKIE
JEST". KA�DA DOROZUMIANA LUB BEZPO�REDNIO WYRA�ONA GWARANCJA, NIE WY��CZAJ�C
DOROZUMIANEJ GWARANCJI PRZYDATNO�CI HANDLOWEJ I PRZYDATNO�CI DO OKRE�LONEGO
ZASTOSOWANIA, JEST WY��CZONA. W �ADNYM WYPADKU POSIADACZE PRAW AUTORSKICH NIE
MOG� BY� ODPOWIEDZIALNI ZA JAKIEKOLWIEK BEZPO�REDNIE, PO�REDNIE, PRZYPADKOWE,
SPECJALNE, UBOCZNE I WT�RNE SZKODY (NIE WY��CZAJ�C OBOWI�ZKU DOSTARCZENIA
PRODUKTU ZAST�PCZEGO LUB SERWISU, ODPOWIEDZIALNO�CI Z TYTU�U UTRATY
U�YTECZNO�CI, UTRATY DANYCH LUB KORZY�CI, A TAK�E PRZERW W PRACY
PRZEDSI�BIORSTWA), SPOWODOWANE W JAKIKOLWIEK SPOS�B, I W JAKIMKOLWIEK MODELU
ODPOWIEDZIALNO�CI, KONTRAKTOWEJ, CA�KOWITEJ LUB DELIKTOWEJ (WYNIK�EJ ZAR�WNO Z
NIEDBALSTWA JAK INNYCH POSTACI WINY), POWSTA�E W JAKIKOLWIEK SPOS�B W WYNIKU
U�YWANIA LUB MAJ�CE ZWI�ZEK Z U�YWANIEM OPROGRAMOWANIA, NAWET JE�LI O MO�LIWO�CI
POWSTANIA TAKICH SZK�D OSTRZE�ONO.

===

Who needs patience anymore, when all our pleasure's virtual?