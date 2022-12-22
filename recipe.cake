#load nuget:?package=Chocolatey.Docs.Cake.Recipe&version=0.1.0

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            projectFilePath: "./docs-recipe-test.csproj",
			    virtualDirectory: "docs-recipe-test");

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolPreprocessorDirectives();

Build.Run();