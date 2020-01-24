# NUnit-C#

https://nunit.org/

NUnit is a unit-testing framework for all .Net languages. Initially ported from JUnit, the current production release, version 3, has been completely rewritten with many new features and support for a wide range of .NET platforms.

Main thing of Nunit test is test a method of class without accessing database. Using Moq for create fake/dummy data for that method.

Befor write the Nunit test, We must install some packages using pageckage manager console in Visual Studio.

Required packages:

1) Nunit                    - (PM - Install-Package NUnit -Version 3.12.0)
2) NUnit3TestAdapter        - (PM - Install-Package NUnit3TestAdapter -Version 3.16.1)
3) Microsoft.NET.Test.Sdk   - (PM - Install-Package Microsoft.NET.Test.Sdk -Version 16.4.0)

Only these packages is required for write Nunit test in .net core c#

4) Moq -(PM - Install-Package Moq -Version 4.13.1) 

This package is used for creating fake data only.
