## BugdgetApp C#  console project write Tdd

Using XUnit of create this TDD project
Installed xUnit in vsCode with Nuget
This is three package:
1. Microsoft.NET.Test.Sdk
2. xunit
3. xunit.runner.visualstudio

Created the Create_category_test first test and it passed red

```cmd
PS C:\Users\Francesco\Desktop\BudgetApp> dotnet test
  Individuazione dei progetti da ripristinare...
  Tutti i progetti sono aggiornati per il ripristino.
  BudgetApp -> C:\Users\Francesco\Desktop\BudgetApp\bin\Debug\net6.0\BudgetApp.dll
Esecuzione dei test per C:\Users\Francesco\Desktop\BudgetApp\bin\Debug\net6.0\BudgetApp.dll (.NETCoreApp,Version=v6.0)
Strumento da riga di comando per l'esecuzione di test Microsoft (R) Versione 17.2.0 (x64)
Copyright (c) Microsoft Corporation. Tutti i diritti sono riservati.

Avvio dell'esecuzione dei test in corso. Attendere...
Un totale di 1 file di test corrisponde al criterio specificato.
[xUnit.net 00:00:00.56]     ClassTest.Create_category_test [FAIL]
  Non superato ClassTest.Create_category_test [7 ms]
  Messaggio di errore:
   Assert.Equal() Failure
Expected: Category { categorName = clothing }
Actual:   Category { categorName = food }
  Analisi dello stack:
     at ClassTest.Create_category_test() in C:\Users\Francesco\Desktop\BudgetApp\ClassTest.cs:line 10

Non superato! - Non superati:     1. Superati:     0. Ignorati:     0. Totale:     1. Durata: < 1 ms - BudgetApp.dll (net6.0)
PS C:\Users\Francesco\Desktop\BudgetApp>

```



Create_category_test first test and it passed green

```cmd
PS C:\Users\Francesco\Desktop\BudgetApp> dotnet test
  Individuazione dei progetti da ripristinare...
  Tutti i progetti sono aggiornati per il ripristino.
  BudgetApp -> C:\Users\Francesco\Desktop\BudgetApp\bin\Debug\net6.0\BudgetApp.dll
Esecuzione dei test per C:\Users\Francesco\Desktop\BudgetApp\bin\Debug\net6.0\BudgetApp.dll (.NETCoreApp,Version=v6.0)
Strumento da riga di comando per l'esecuzione di test Microsoft (R) Versione 17.2.0 (x64)
Copyright (c) Microsoft Corporation. Tutti i diritti sono riservati.

Avvio dell'esecuzione dei test in corso. Attendere...
Un totale di 1 file di test corrisponde al criterio specificato.

Superato!     - Non superati:     0. Superati:     1. Ignorati:     0. Totale:     1. Durata: < 1 ms - BudgetApp.dll (net6.0)
PS C:\Users\Francesco\Desktop\BudgetApp> 

```


write Compare_legdger_test test and it passed red 
```
PS C:\Users\Francesco\Desktop\BudgetApp> dotnet test --filter Compare_legdger_test
  Individuazione dei progetti da ripristinare...
  Tutti i progetti sono aggiornati per il ripristino.
  BudgetApp -> C:\Users\Francesco\Desktop\BudgetApp\bin\Debug\net6.0\BudgetApp.dll
Esecuzione dei test per C:\Users\Francesco\Desktop\BudgetApp\bin\Debug\net6.0\BudgetApp.dll (.NETCoreApp,Version=v6.0)
Strumento da riga di comando per l'esecuzione di test Microsoft (R) Versione 17.2.0 (x64)
Copyright (c) Microsoft Corporation. Tutti i diritti sono riservati.

Avvio dell'esecuzione dei test in corso. Attendere...
Un totale di 1 file di test corrisponde al criterio specificato.
[xUnit.net 00:00:00.51]     BudgetAppTest.Compare_legdger_test [FAIL]
  Non superato BudgetAppTest.Compare_legdger_test [10 ms]
  Messaggio di errore:
   Assert.Equal() Failure
Expected: List<LedgerItem> [LedgerItem { Description = breadS, price = 10 }, LedgerItem { Description = water, price = 10 }]
Actual:   List<LedgerItem> [LedgerItem { Description = bread, price = 20 }, LedgerItem { Description = water, price = 20 }]
  Analisi dello stack:
     at BudgetAppTest.Compare_legdger_test() in C:\Users\Francesco\Desktop\BudgetApp\BudgetAppTest.cs:line 20

Non superato! - Non superati:     1. Superati:     0. Ignorati:     0. Totale:     1. Durata: < 1 ms - BudgetApp.dll (net6.0)
PS C:\Users\Francesco\Desktop\BudgetApp> 

```











