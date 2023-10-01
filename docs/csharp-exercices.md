# Exercices en C#

!!! warning "Consignes"

    - Activer la null safety
    - Ne pas utiliser les fonctions de tri de .Net

1. Ecrire une fonction qui génère 2 entiers pseudo-aléatoires entre 0 et 50 et les affiche dans l'ordre croissant
1. Ecrire une fonction qui génère 3 entiers pseudo-aléatoires entre 0 et 50 et les affiche dans l'ordre croissant
1. Ecrire une fonction qui génère des entiers pseudo-aléatoires entre 10 et 20 et s'arrête lorsque le premier nombre généré apparaît une seconde fois
1. Ecrire un programme qui génère un nombre de départ entre 0 et 9, et qui ensuite écrit la table de multiplication de ce nombre, présentée comme suit (cas du nombre 5) :
1. Ecrire un programme qui génère un tableau 2D éparse de 4 lignes. Pour chaque ligne, le nombre de colonnes est un nombre pseudo-aléatoire. Remplir cette matrice par des nombres pseudo-aléatoires de valeur max 999
    - Afficher cette matrice comme sur excel. Conseil: utiliser la méthode `PadRight`
1. Ecrire un programme qui génère deux tableaux de tailles pseudo-aléatoires et de contenus pseudo-aléatoires. Calculer le schtroumpf des deux tableaux et afficher le détail. Les nombres aléatoires sont compris entre 0 et 10.
    - Pour calculer le schtroumpf, il faut multiplier chaque élément du tableau 1 par chaque élément du tableau 2, et additionner le tout.
    - Par exemple si l'on a : [4, 8, 7, 12] et [3, 6], le programme va afficher: `Le Schtroumpf sera : 3 x 4 + 3 x 8 + 3 x 7 + 3 x 12 + 6 x 4 + 6 x 8 + 6 x 7 + 6 x 12 = 279`
1. Ecrivez un programme permettant de générer aléatoirement 10 notes comprises entre 0 et 20. Le programme, renvoie la liste et le nombre de notes supérieures à la moyenne de la classe.
1. Ecrire une fonction IsPalindrome(string) qui permet de dire si une chaîne de caractères est un palindrome, et ce Sans utiliser de fonction reverse,
    - `IsPalindrome("toto")` -> false (car toto != otot)
    - `IsPalindrome("totot")` -> true
1. Ecrire une fonction IsPalindrome(int) qui permet de dire si un entier est un palindrome, et ce, sans transformer l'entier en String
    - `IsPalindrome(1234)` -> false
    - `IsPalindrome(12321)` -> true
    - `IsPalindrome(1221)` -> true
    - `IsPalindrome(1)` -> true
1. Modélisation des formes géométriques avec les `Record`
    1. Créer un record “Circle” qui prend en paramètre du constructeur un “Radius”
        - Ajouter les propriétés calculées publiques (en lecture seule): Area, Circumference et Diameter
        - Créer deux instances ayant le même rayon et affichez les dans la console, en utilisant le ToString() proposé par les record
        - Comparer les deux cercles avec l’opérateur ‘==’. Ensuite, comparez en enlevant la nature record de Cercle. Que remarquez-vous ?
    1. Créer un record abstract “Shape” avec un constructeur vide et les propriété en lecture seule abstraites: Area et Circumference
    1. Faire en sorte que “Circle” hérité de Shape
    1. Créer un record “Rectangle” qui hérite de share et prend en paramètre du constructeur (Width et Height)
        - Implémenter les propriétés calculées (en lecture seule): Area, Circumference (même si techniquement, ça devrait s’appeler Perimeter)
    1. Créer une fonction PrintShapeInfo qui prend un Shape en paramètre et qui utilise le pattern matching pour afficher des infos différentes selon le type du shape
    1. Créer une fonction qui génère aléatoirement une liste de shape de type Circle ou Rectangle avec des valeurs initiales aléatoires. Le nombre d’éléments à générer est passé en paramètre. Utiliser cette méthode pour générer une liste de 10 Shape
    1. Utiliser LINQ (Select, Where, Aggregate, etc.) pour générer un objet qui a deux champs: SumCircleArea et MaxRectangleWidth:
        - SumCircleArea: la somme des surfaces de tous les cercles. MaxRectangleWidth: la largeur maximale des rectangles
        - Faire en sorte que l’objet généré soit anonyme
    1. Utiliser LINQ pour calculer le nombre de cercles dans la liste
    1. Utiliser LINQ pour calculer le nombre de rectangles dont la superficie est > 10
    1. Utiliser LINQ pour calculer la circonférence moyenne des cercles (astuce: méthode average)
