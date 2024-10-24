# selenium-csharp-grid-devcontainer

Demo project that shows how to launch a VS Code dev container based on `dotnet/sdk` with a Selenium Grid sidecar container.

This setup is useful for developing/debugging C# Selenium tests that are written to execute on a Grid server environment.

The project files were created with the dotnet CLI:

```zsh
dotnet new nunit -n SeleniumCsharp
```

After opening this project in VS Code, and launching the dev container when prompted:

* If this is your first build, run `dotnet build` in the VS Code terminal to build the project within the dev container.
* Test methods in `UnitTest1.cs` should then be runnable/debuggable with the inline run/debug control next to the line number in the editor in the gutter, or in the `Testing` (Test Explorer) view.
* The grid server's VNC port should be mapped to your host at `localhost:5900`, so you can point a VNC client and watch tests execute in the browser.
