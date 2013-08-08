ConfigManager
===
### T4 Template for wrap andstrongly-typed config file settings. For Vb and C# ###
The projects are an exameple how use this T4 template for wrap config properties in .NET Projects. 
___

### How Use ###

You don't need download all repository, you only need AppSettingsCS.tt (for C# Projects) and AppSettingsVB.tt (for VB.NET Projets).

1. Add AppSettings*.tt to your project
2. In Visual Studio-> Solution Explorer select .tt file and click "Run Custom Tool" on context menu
3. Visual Studio generate a static class / Module for read your appsettings

___

### Aditional Configs

You can change some settings in config vars at the top of .tt file.

-  `_ClassName: (string)` Set class name for output file

-  `_Namespace: (string)` If you englobe current class in a namespace, you can indicate a fullpath for namespace. Leave blank if you don't need any namespace.

-  `_Hereditable:(boolean)` By default is false. This indicate if you want a static class, or module if template is for VB.NET, to access settings properties or a common instance class  
By default this template build static class and you can't inherit from this. 
But is common that you need extend or change some behabior of some properties, for this case, you cant set _Hereditable=true and the built class will be a instance class with virtual properties. For this implementation I suggest implement a singleton pattern in child class, at ExampleVB there is a implementation of this way.
___
