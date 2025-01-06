# Projekt na zaliczenie przedmiotu Algorytmy i Strukt. Danych

**Nazwa Projektu**: Lista Zadań

**Autor Projektu**: Bartłomiej Wasyluk (175214)


## Opis Projektu
**Wykorzystane struktury danych:**

* Lista Jednokierunkowa (Single Linked List)

Każde utworzone zadanie jest zapisana we własnej strukturze danych o nazwie NodeLZ, który zawiera łańcuch znaków
by opisać zadanie, Date by wyznaczyć limit czasu by go ukończyć oraz bool by poinformować czy dane zadanie ma priortyet czy nie.

Po jego utworzeniu jest dodany do listy jednokierunkowej, ze względu na cel tego oprogramowania lista zawiera tylko head do wyznaczania początku tego listu oraz count by poinformować ile elementów zawiera dana lista.
Nie dodano tail do listy ze względu na to, że najczęściej liczba elementów dla listy zadań jest mała w wyniku czego czas operacji jest bardzo mała, a dodanie go by niepotrzebnie zużywał więcej pamięci.

## Działanie programu

Przed dodaniem zadania do listy użytkownik może oznaczyć czy ma priorytet czy też nie. Jeżeli ma to dołączony jest znak "[!]" i jest zawsze dodany nad zadaniami, które w ogóle nie mają. Po utworzeniu zadania
jest on dodany do listy jednokierunkowej a następnie jego widok jest wyświetlony w listBox'ie, który też służy do operowania danej listy.

Usuwanie zadania działa następująco. Po wybraniu elementu i wciśnięciu przycisku Usuń, program wyszuka wybrany element w liście jednokierunkowej a następnie go usunie wraz z jego widoku. Wciskając na przycisk
Usuń bez zaznaczenia elementu, program usunie element z listy jednokierunkowej na podstawie pierwszej pozycji z listy widoku, działa też i odtwotnie gdzie usunie element na podstawie ostatniej pozycji z listy widoku
jeżeli wciśniesz przycisk Usuń mając przytrzymany klawisz Alt o ile nic nie zaznaczyłeś.

Program zawiera opcję wyszukiwania przez co można wyszukać listę po opisie, datę ukończenia tego zadania oraz czy uwzględnić zadania z priorytetem, bez priorytetu czy też bez różnicy. Program wyszukuje po liście
jednokierunkowej a wyniki będą wyświetlane w widoku. Przycisk Przywróć przywraca widok listy do stanu pierwotnego na podstawie kolejności listy jednokierunkowej.

Dany widok listy można posortować malejąco lub rosnąco wykorzystując datę ukończenia jako podstawę oraz opcjonalnie czy dane zadanie ma priorytet gdy jest włączona opcja "[!] Na Górze". Po zaznaczeniu tej opcji
program posortuje zadania z priorytetem i umieści je zawsze na górze na zadaniami bez priorytetu.

Przycisk Eksport służy do zapisywania widoku danej listy jako plik tekstowy z rozszerzeniem TXT.
