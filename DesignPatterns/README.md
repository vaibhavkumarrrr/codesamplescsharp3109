# Design Patterns in C#

This repository contains C# examples for all classic GoF design patterns. Each pattern includes two examples:
- [x] **Conceptual** examples show the internal structure of patterns with detailed comments.

## Requirements

Most examples are console apps built using C# .NET 8.0.

For the best experience, we recommend working with examples with these IDEs:

- [Visual Studio 2017 and newer](https://www.visualstudio.com/downloads/) on Windows/Mac.
- [Visual Studio Code](https://code.visualstudio.com/) on any OS.
- [Rider](https://www.jetbrains.com/rider/) on any OS.

## Contributor's Guide

Here's a style guide which might help you to keep your changes consistent with our code:

1. All code should follow the [Microsoft C# code style guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions).

2. Try to hard wrap the code at 80th's character. It helps to list the code on the website without scrollbars.

3. The actual examples should be represented by projects with the following naming convention: {PatternName}.{ExampleName}.

4. The code should have the following namespace: csharp.training.congruent.apps.patterns.{PatternName}.{ExampleName}.

5. Aim to put all code within one file. We realize that it's not how it supposed to be done in production. But it helps people to better understand examples, since all code fits into one screen.

6. Comments may or may not have language tags in them, such as this:

    ```csharp
     // EN: All products families have the same varieties (MacOS/Windows).
     //
     // This is a MacOS variant of a button.
     //
     // RU: Все семейства продуктов имеют одни и те же вариации (MacOS/Windows).
     //
     // Это вариант кнопки под MacOS.
    ```

    This notation helps to keep the code in one place while allowing the website to generates separate versions of examples for all listed languages. Don't be scared and ignore the non-English part of such comments. If you want to change something in a comment like this, just do it. Even if you do it wrong, we'll tell you how to fix it during the Pull Request.


## License

This work is licensed under a Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.

<a rel="license" href="http://creativecommons.org/licenses/by-nc-nd/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-nd/4.0/80x15.png" /></a>

## Credits

Authors:  Alexander Shvets ([@neochief](https://github.com/neochief)) and Alexey Pyltsyn ([@lex111](https://github.com/lex111))
