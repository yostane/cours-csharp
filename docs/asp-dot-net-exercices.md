# Exercices ASP.NET

1. Créer un endpoint `/palindrome/{word}` qui retourne `Est un palindrome` si `word` est un palindrome, sinon `N'est pas un palindrome`
    - Par exemple, `GET /palindrome/toto` retourne `N'est pas un palindrome`, et `GET /palindrome/totot` retourne `Est un palindrome`
1. Créer un endpoint `/schtroumpf/{nb1}/{nb2}` qui retourne le schtroumpf d'un tableau de `nb1` éléments aléatoires et d'un tableau de `nb2` éléments aléatoires. Les valeurs des deux tableaux sont comprises entre 1 et 12 
    - voir définition dans [les exos C#](./csharp-exercices.md)
    - Par exemple, `GET /schtroumpf/4/2` avec les tableaux aléatoire `[4, 8, 7, 12]` et `[3, 6]`, le résultat sera `279`
1. Créer un endpoint `/notes` qui génère 10 notes aléatoires et renvoie un json listant les notes, la moyenne et le nombre de notes supérieures à la moyenne.
    - Exemple
        ```json
        {
            "notes": [12, 15, 8, 10, 18, 14, 9, 11, 13, 16],
            "moyenne": 12.6,
            "nbNotesSupMoyenne": 5
        }
        ```
1. Créer un endpoint `/notes/{nb}` qui génère `nb` notes aléatoires et renvoie un json listant les notes, la moyenne et le nombre de notes supérieurs à la moyenne.
    - Exemple: `/notes/10`
        ```json
        {
            "notes": [12, 15, 8, 10, 18, 14, 9, 11, 13, 16],
            "moyenne": 12.6,
            "nbNotesSupMoyenne": 5
        }
        ```

??? "Solutions"
    ```cs
    --8<--
    aspdotnet/ExercisesApi/Program.cs
    --8<--
    ```