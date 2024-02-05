Analizator9000 - README

0. SPIS ZAWARTOŚCI
==================

    1. Wprowadzenie
    2. Wymagania systemowe
    3. Instalacja
    4. Podręcznik użycia
    5. Kod źródłowy
    6. Autorzy
    7. Wsparcie i informacje kontaktowe
    8. Historia zmian
    9. Licencja

1. WPROWADZENIE
===============

Analizator9000 jest aplikacją oferującą graficzny interfejs użytkownika dla
analizy statystycznej liczby lew w rozdaniach brydżowych wygenerowanych na
podstawie określonych warunków.

Program stanowi interfejs dla programu Dealer oraz dla biblioteki libbcalcDDS,
będącej częścią projektu BCalc. Aby dowiedzieć się więcej o tych programach,
skieruj się do sekcji "AUTORZY".

2. WYMAGANIA SYSTEMOWE
======================

Analizator9000 działa w środowisku .NET 3.5 Client Profile i jako taki wymaga
platformy kompatybilnej ze środowiskiem .NET 3.5.

Wymagania sprzętowe platformy .NET 3.5:

    * system operacyjny Windows XP/Vista/Server 2003/Server 2008/7/8 lub nowszy
     (systemy Windows 7, Windows Server 2008 R2 oraz Windows 8 i nowsze
      dostarczają .NET 3.5 wraz z podstawową instalacją systemu)
    * procesor: równoważny Pentium 400MHz (minimalny); Pentium 1GHz (zalecany)
    * pamięć RAM: 96MB (minimalna); 256MB (zalecana)

Wymagania specyficzne dla aplikacji:

    * ekran: minimalna rozdzielczość 1024x600px; kolory 16-bit
    * wolne miejsce na dysku: minimum 500MB (.NET 3.5) + 5MB (Analizator9000)
    * dodatkowe miejsce na dysku: 1MB na pełną analizę każdego tysiąca rozdań

UWAGA!
    Aplikacja może potrzebować bardzo dużej ilości zasobów systemowych w
zależności od rozmiaru wykonywanego zadania. Nieodpowiedzialny dobór parametrów
generowania rozdań/analizy może doprowadzić do znacząco długiego czasu
wykonywania programu, zawieszenia jego działania bądź, w przypadkach skrajnych,
do ograniczenia jakości korzystania z systemu użytkownika. Autor zaleca
ostrożny dobór parametrów uruchomienia w celu rozpoznania wydajności aplikacji
i systemu użytkownika.

3. INSTALACJA
=============

Program jest gotowy do użycia po rozpakowaniu go do dowolnego katalogu na
lokalnym dysku twardym.

Aktualną wersję programu można pobrać ze strony domowej projektu:
    https://github.com/emkael/an9k/releases/

Program po rozpakowaniu niezbędnie wymaga obecności dwóch katalogów
(dostarczonych w archiwum):

    * katalogu bin/ - zawierającego programy zewnętrzne używane przez analizator
      (plik lbcalcdds.dll należący do projektu BCalc, plik wykonywalny
       dealer.exe, należący do projektu Dealer oraz bibliotekę cygwin1.dll,
       wymaganą do uruchomienia programu Dealer)
    * pustego katalogu files/ - do którego zapisywane są wyniki działania
      programu

4. PODRĘCZNIK UŻYCIA
====================

Opis użycia programu wraz ze zrzutami ekranu oraz przykładowymi wynikami
dostępny jest na stronie domowej programu:
    http://an9k.emkael.info/manual/

5. KOD ŹRÓDŁOWY
===============

P: W jakim języku programowania napisany jest Analizator9000?
O: C#.

P: Czy mogę zobaczyć kod źródłowy programu?
O: Oczywiście!

P: Skąd mogę go pobrać?
O: Z repozytorium Subversion dostępnego pod adresem:
    https://github.com/emkael/an9k/

P: Czy kod jest udokumentowany?
O: Starałem się, jak mogłem. Dokumentacja kodu w formie HTML oraz plikach MSHC/MSHA
   dostępna jest na stronie internetowej aplikacji:
    http://ank9.emkael.info/code/

P: W jakim środowisku powstał program?
O: Microsoft Visual Studio/Visual C# 2010 i 2022.

P: Czy mogę prosić o dopisanie kodu dla funkcjonalności X?
O: Proście, a będzie Wam dane.

P: Dopisałem do kodu funkcjonalność X. Czy możesz dołączyć ją do swojej edycji
   programu?
O: Jeśli jest sensowna i będę w stanie zrozumieć jej kod źródłowy bez
   konieczności uciekania się do napojów alkoholowych powyżej 8% zawartości,
   oczywiście.

6. AUTORZY
==========

Analizator9000:
    Michał Klichowicz (mkl/emkael)
    WWW: http://emkael.info
    e-mail: emkael@tlen.pl

Dealer:
    Obecny zarządca kodu: Henk Uijterwaal
    WWW: http://henku.home.xs4all.nl/html/dealer/authors.html

Bridge Calculator (bcalc):
    Piotr Beling
    WWW: http://bcalc.w8.pl/

Ikona programu:
    Tonev
    WWW: http://www.iconarchive.com/show/windows-7-icons-by-tonev.html

7. WSPARCIE I INFORMACJE KONTAKTOWE
===================================

Zgłoszenia błędów, sugestie usprawnień oraz wszelkie komentarze natury ogólnej
należy kierować bezpośrednio do autora, drogą elektroniczną.
Najłatwiej skontaktować się z autorem poprzez pocztę elektroniczną:
    emkael@tlen.pl
Można również odwiedzić ForumBridge.pl i podrzucić prywatną wiadomość
użytkownikowi mkl:
    http://www.forumbridge.pl/private.php?do=newpm&u=360
bądź odnaleźć na Forum odpowiedni wątek i dodać w nim wiadomość.

Zgłaszane błędy będą badane oraz poprawiane w miarę możliwości autora, przy
czym oczekuje się, że wraz ze zgłoszeniem błędu użytkownik będzie w stanie
dostarczyć podstawowych informacji służących do odtworzenia błędu bądź będzie
dysponować wystarczającymi umiejętnościami z zakresu ogólnej obsługi komputera,
by te informacje zebrać na prośbę autora.

Autor zastrzega sobie prawo do traktowania propozycji ulepszeń oraz zmian
funkcjonalnych z dowolnie dobraną dozą sceptycyzmu.

Jeśli znajdujesz mój program użytecznym, i chciałbyś mi za niego podziękować,
możesz napisać do mnie maila i dać mi znać, że Ci się spodobał.
Jeśli chciałbyś go przerobić, użyć jako część większego projektu lub
zaproponować jakiekolwiek inne jego zastosowanie poza hobbystycznymi analizami,
również napisz do mnie maila, zobaczymy, co się da zrobić.
Jeśli za pomocą mojego programu odkryłeś jakieś ciekawe wyniki bądź doszedłeś
do zaskakujących wniosków, tym bardziej napisz maila.
Jeśli nie jesteś pewien, czy napisać do mnie w jakiejś sprawie związanej z
programem, napisz maila. Lubię czytać maile.

Jeśli znajdujesz mój program na tyle użytecznym, żeby chcieć podziękować mi za
niego materialnie, masz pecha. Nie przyjmuję dotacji pieniężnych, a program
jest w pełni darmowy i niekomercyjny. Lubię za to również interesujące książki
i dobre piwo.

8. HISTORIA ZMIAN
=================

2024.02 - 0.13
    * poprawka błędu: program nie analizuje kontraktów, których częstość jest wyzerowana

2021.02 - 0.12
    * chińskie tłumaczenie, autorstwa Li Ruisheng
    * kosmetyka wyświetlania wyników/max/IMP względem rozgrywającego
    
2015.12 - 0.11
    * odświeżony interfejs
    * tłumaczenie interfejsu
    * pasek menu
    * zapis rozdań do PBN
    
2014.12 - 0.10
    * zakładka analizy kontraktów

2013.04 - 0.9.1
    * wymuszenie 32-bitowego formatu binariów (kompatybilność z 32-bitową DLL)

2012.11 - 0.9
    * pierwotna wersja programu

9. LICENCJA
===========

Licencja BSD (dwuklauzulowa)

Copyright (c) 2012-2024, Michał Klichowicz
Wszystkie prawa zastrzeżone

Redystrybucja i używanie, czy to w formie kodu źródłowego, czy w formie kodu
wykonywalnego, jest dozwolone pod warunkiem spełnienia poniższych warunków:

    * Redystrybucja kodu źródłowego musi zawierać powyższą notę o prawach
    autorskich, niniejszą listę warunków oraz poniższe oświadczenie o wyłączeniu
    odpowiedzialności.

    * Redystrybucja kodu wykonywalnego musi zawierać powyższą notę o prawach
    autorskich, niniejszą listę warunków oraz poniższe oświadczenie o wyłączeniu
    odpowiedzialności w dokumentacji i/lub w innych materiałach dostarczanych
    wraz z kopią oprogramowania.

TO OPROGRAMOWANIE JEST DOSTARCZONE PRZEZ MICHAŁA KLICHOWICZA "TAKIM, JAKIE
JEST". KAŻDA DOROZUMIANA LUB BEZPOŚREDNIO WYRAŻONA GWARANCJA, NIE WYŁĄCZAJĄC
DOROZUMIANEJ GWARANCJI PRZYDATNOŚCI HANDLOWEJ I PRZYDATNOŚCI DO OKREŚLONEGO
ZASTOSOWANIA, JEST WYŁĄCZONA. W ŻADNYM WYPADKU POSIADACZE PRAW AUTORSKICH NIE
MOGĄ BYĆ ODPOWIEDZIALNI ZA JAKIEKOLWIEK BEZPOŚREDNIE, POŚREDNIE, PRZYPADKOWE,
SPECJALNE, UBOCZNE I WTÓRNE SZKODY (NIE WYŁĄCZAJĄC OBOWIĄZKU DOSTARCZENIA
PRODUKTU ZASTĘPCZEGO LUB SERWISU, ODPOWIEDZIALNOŚCI Z TYTUŁU UTRATY
UŻYTECZNOŚCI, UTRATY DANYCH LUB KORZYŚCI, A TAKŻE PRZERW W PRACY
PRZEDSIĘBIORSTWA), SPOWODOWANE W JAKIKOLWIEK SPOSÓB, I W JAKIMKOLWIEK MODELU
ODPOWIEDZIALNOŚCI, KONTRAKTOWEJ, CAŁKOWITEJ LUB DELIKTOWEJ (WYNIKŁEJ ZARÓWNO Z
NIEDBALSTWA JAK INNYCH POSTACI WINY), POWSTAŁE W JAKIKOLWIEK SPOSÓB W WYNIKU
UŻYWANIA LUB MAJĄCE ZWIĄZEK Z UŻYWANIEM OPROGRAMOWANIA, NAWET JEŚLI O MOŻLIWOŚCI
POWSTANIA TAKICH SZKÓD OSTRZEŻONO.

===

Who needs patience anymore, when all our pleasure's virtual?
