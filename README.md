# NUnit 3 Examples

## Examples of problems faced trying to get NUnit3TestAdapter working with .Net framework in SDK format projects

## Ignored LoggerRunSettings

`.runsettings` has a logger configured, but there is a difference between:
    
    PS C:\Source\NUnit3Examples\parentFolder\source> dotnet test -v:q .\source.sln
    Test run for C:\Source\NUnit3Examples\parentFolder\source\baselibrary.tests\bin\Debug\net48\baselibrary.tests.dll (.NETFramework,Version=v4.8)
    VSTest version 17.11.0 (x64)
    
    Starting test execution, please wait...
    A total of 1 test files matched the specified pattern.
    
    Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration:  - baselibrary.tests.dll (net48)

And 
    
    PS C:\Source\NUnit3Examples\parentFolder\source> dotnet test -v:q --logger "console;verbosity=normal" .\source.sln
    Test run for C:\Source\NUnit3Examples\parentFolder\source\baselibrary.tests\bin\Debug\net48\baselibrary.tests.dll (.NETFramework,Version=v4.8)
    VSTest version 17.11.0 (x64)
    
    Starting test execution, please wait...
    A total of 1 test files matched the specified pattern.
    NUnit Adapter 3.16.1.0: Test execution started
    Running all tests in C:\Source\NUnit3Examples\parentFolder\source\baselibrary.tests\bin\Debug\net48\baselibrary.tests.dll
       NUnit3TestExecutor converted 2 of 2 NUnit test cases
    NUnit Adapter 3.16.1.0: Test execution complete
      Passed Test1 [10 ms]
    
    Test Run Successful.
    Total tests: 1
         Passed: 1
     Total time: 1.0415 Seconds

So it's clear the logger configuration is not being properly applied

