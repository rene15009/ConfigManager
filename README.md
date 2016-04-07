ConfigManager
===
### T4 Template for wrap and strongly-typed config file settings. For Vb and C# ###
___

### Purpose ###
The projects are an example of how to use this T4 template for wrap config properties in .NET Projects. 
This works fine in several project types like Windows Aplications (Console, Services,WinForms,WCF,etc.), WebSites, WebProjects. You only need Visual Studio IDE or Express Edition (In Express Edition you'll could add a .tt file but you have to run custom tool manually to 'TextTemplatingFileProcessor' run) 
___

### How Use ###

You don't need download all repository, you only need AppSettingsCS.tt file (for C# Projects) or AppSettingsVB.tt (for VB.NET Projets).

1. Add AppSettings*.tt to your project
2. In Visual Studio-> Solution Explorer select .tt file and click "Run Custom Tool" on context menu
3. Visual Studio generate a static class / Module for read your appsettings

___

### Aditional Configs

You can change some settings in config variables at the top of .tt file.

-  `_ClassName: (string)` Set class name for output file

-  `_Namespace: (string)` If you englobe current class in a namespace, you can indicate a fullpath for namespace. If you don't, you have to set to empty string.

-  `_Hereditable:(boolean)` By default is false. This indicates if you want a static class or module(in case the template is for VB.NET) to access settings properties. If you set _Heriditable=true means T4 template will generate a common instanceable class.  

-  `_UseExpressionBody:(boolean)` T4 template will generate properties using body expressions. You can use this feature in all versións of .NET 2.0+ only if you are using Roslyn Compiler.


By default this template builds static class and you can't inherit from this. 
Maybe you need to extend or change some behavior from some properties, for this case, you have to set _Hereditable=true to build a class that will be a instance class with virtual properties. For this implementation I suggest to implement a singleton pattern in child class. In ExampleVB project there is a implementation with _Hereditable=true and singleton pattern.
___
