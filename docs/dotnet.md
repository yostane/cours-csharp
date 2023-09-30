# Le framework .Net

## Qu'est-ce qu'un framework ?

On peut voir un framework comme une librairie dont l'usage est structurant dans un projet. Ils proposent généralement:

-   Des outils (par exemple un CLI)
-   Des librairies et API
-   Un documentation

-
-   Des langages de programmation qu’il supporte
-
-   Il faut aussi s’intéresser à son:
    Prix
    Communauté et le support en cas de problème
    Documentation

## Historique

-   Avant les années 2000, les seuls gros frameworks de MicroSoft sont les API Win32 et COM (qu'on peut coder en C++ et VB).
    -   La sortie du JDK de Sun Microsystems a grandement amélioré l'expérience développeur. Microsoft a d'ailleurs développé une déclinaison personnalisée (MSVM) qui a été abandonnée suite au procès contre SUN.
-   2000: MicroSoft lance .Net et “.Net Framework“ 1.0 (C#, VB) mais qui ne sont compatibles qu'avec Windows.
    -   Le code source du framework est en C++.
-   2004: Sortie de Mono qui est un portage .Net pour Linux OSS (Open Source) indépendant de MicroSoft.
-   2013: Microsoft déclare durant la conférence Build (Apple: WWDC, Google: Google IO) son souhait de faire de l'Open Source avec la fameuse citation: Microsoft♥️Linux.
-   Depuis 2014: Création de Fondation .Net et sortie de projets .Net en OSS
-   .Net Core (octobre 2014), EFCore, MSBuild, VSCode, .NetStandard, etc.
-   Fin 2020, sortie de .Net 5 et abandon du terme **.Net Core** en faveur de **.Net** tout court

!!! warning ".Net et .Net Framework sont deux frameworks différents"

    Bien qu'ayant des classes et fonctions communtes, **.Net Framework** et **.Net** sont deux frameworks différents. Le premier est déprécié et n'est compatible qu'avec Windows. Le deuximèe est d'actualité et est multiplatforme.

## Quelques APIs

-   Types primitifs: System.Boolean and System.Int32, etc.
-   Collections: System.Collections.Generic.List<T>, System.Collections.Generic.Dictionary<TKey,TValue>, etc.
    -   Les collection désignent les structures de données ou les types qui stockent un ensemble de données. Exemples: tableau, listes, dictionnaire (Map), ensembles (Set), chaîne de caractères
-   Types utilitaires: System.Net.Http.HttpClient, System.IO.FileStream, etc.
-   Data types, such as System.Data.DataSet, and System.Data.Entity.DbSet.
-   High-performance types, such as System.Span<T>, System.Numerics.Vector, and Pipelines
