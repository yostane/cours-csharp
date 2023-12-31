# Exercices

!!! warning "Consignes"

    - Activer la null safety
    - Ne pas utiliser les fonctions de tri de .Net

## Série 1 (Fichiers)

1. Utiliser les `StreamReader` et / ou `StreamWriter` pour lire et un fichier et:
    - Afficher le nombre de caractères de chaque ligne de ce fichier
    - Génère un fichier qui ajoute un point à la fin de chaque ligne du fichier d'origine si elle n'est pas déjà présente
    - Génère un fichier qui contient la ligne qui a le plus de caractères dans le fichier lu
    - Génère un fichier qui contient les lignes du fichier lu triés par ordre croissant le nombre de caractères de la ligne
    - Génère un fichier qui contient les lignes du fichier lu triés par ordre croissant du dictionnaire
1. Utiliser un `StreamWriter` pour écrire dans un fichier le contenu d'une chaîne de caractères au format pyramidal. Par exemple "Je-fais-des-exos-de-C#" donne le fichier (le dernier caractère sera ignoré car il ne permet pas de faire une pyramide):

    ```txt
    J
    e-
    fai
    s-de
    s-exo
    s-de-C
    ```

1. Définir votre propose classe de journalisation (`Logger`) qui va servrir à écrire des logs dans un fichier.
    - La classe prend en argument du constructeur le nom du fichier de logs
    - La classe propose les méthodes: `Info(String message)` et `Warn(String message)`. Chacune des méthodes ajoute une ligne au fichier avec le format:
        - Si c'est une Info: `{date et heure actuelle} ℹ️ {message}`
        - Si c'est un Warn: `{date et heure actuelle} ⚠️ {message}`
    - ⚠️: Attention à bien fermer le fichier une fois l'écriture du log faite (pour le libérer)
    - Créer une instance de la classe `Logger` et ajouter quelques logs
    - Ajouter les méthodes `Error(String message)` et `Debug(String message)` avec un format adapté et basé sur le même principe que les méthodes définies plus haut.
    - Définir une méthode `ShowAllWarnings()` qui affiche tous les logs de type `Warn` présents dans le fichier de log.
    - Est-ce que vous voyez des inconvénients / contraintes avec cette méthode de journalisation ?

## Corrections série 1

```cs title="Correction"
--8<--
file_exo/Program.cs
--8<--
```

## Série 2 (programmation asynchrone)

En C#, la méthode recommandée pour exécuter des traitements asynchrones (qui sont mis en oeuvre habituellement avec les threads et les process) consiste à utiliser “Task.Run(() => { // traitement async })”. On dit que c’est une programmation asynchrone basée sur les tâches.

1. Créer deux tâches asynchrones (en faisant deux Task.Run)
    - La première affiche un valeur qui s’incrémente de 1 à 1000 (une boucle for qui affiche i à chaque itération)
    - La deuxième affiche un valeur qui va de -1 à -1000 (une boucle for de -1 à -1000 avec un writeline)
    - Pour laisser le temps aux tâches concurrentes de finir avant la fin du thread principal, ajouter un await Task.Delay(1000); à la fin de la tâche principale
    - Exécuter le programme plusieurs fois, que constatez vous ?
    - Afficher `finished 1` juste à la fin de la première tâche (sans utiliser `await` et `ContinueWith`)
    - -> solution: utiliser une callback sous forme d’une fonction passée en paramètre
    - En utilisant `ContinueWith` afficher `finished 1` juste après la fin de la première tâche
    - Remplacer chaque `Task.Run` par `await Task.Run`. Que constatez-vous ?
    - En utilisant `await`, comment afficher “finished 2” dès la fin de la deuxième tâche ?
1. Dans la première tâche, ajouter une instruction ‘return “tartatin”;’ après la boucle for. Ensuite remplacer le premier `await Task.Run` par un var `result = await Task.Run`.
    - Quel est le type et la valeur de result ?
    - Enlever await, c’est à dire remplacer `var result = await Task.Run` par `var result = Task.Run`
    - Quel est le type et la valeur de result ?
    - A quoi sert `await` ? Quel est sa relation avec le type `Task` ?
