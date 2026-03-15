\# Raport z wykonania ćwiczenia 1 - Git i GitHub

\*\*Imię i nazwisko:\*\* Tymur Katalnikov

\*\*Numer indeksu:\*\* s33742



\## Odpowiedzi na pytania:



\### 1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?

\- \*\*Fast-forward:\*\* Występuje wtedy, gdy gałąź docelowa (np. main) nie przesunęła się do przodu od momentu utworzenia nowej gałęzi. Git po prostu przesuwa wskaźnik na ostatni commit nowej gałęzi.

\- \*\*Merge commit:\*\* Powstaje, gdy obie gałęzie rozeszły się (w obu gałęziach pojawiły się nowe, unikalne commity). Git musi stworzyć specjalny commit łączący obie historie.



\### 2. Czym w praktyce różni się merge od rebase?

\- \*\*Merge:\*\* Zachowuje pełną strukturę historyczną drzewa. Widać dokładnie, kiedy gałąź została utworzona i kiedy połączona.

\- \*\*Rebase:\*\* „Przepisuje” historię tak, aby wyglądała na liniową. Commity z gałęzi są przenoszone na koniec aktualnego maina, co sprawia, że historia jest czytelniejsza, ale traci informację o rzeczywistym przebiegu prac w czasie.



\### 3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?

Konflikt wystąpił w pliku `Program.cs` w linii wypisującej komunikat do konsoli. Został on rozwiązany ręcznie poprzez:

1\. Usunięcie znaczników konfliktu (`<<<<<<<`, `=======`, `>>>>>>>`).

2\. Wybranie finalnej wersji komunikatu, która łączy informacje z obu wersji.

3\. Ponowne dodanie pliku do indeksu i wykonanie commita kończącego merge.

