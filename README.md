# c_sharp

### Install Runtime

To run C# code in **Ubuntu 24.04**, you typically use the **.NET SDK (dotnet CLI)**, which supports compiling and running C# code. Here's a step-by-step guide:

---

### ✅ Step 1: Install .NET SDK

1. **Install required packages and keys:**

   ```bash
   sudo apt update
   sudo apt install -y wget apt-transport-https software-properties-common
   ```

2. **Add Microsoft’s package signing key and repository:**

   ```bash
   wget https://packages.microsoft.com/config/ubuntu/24.04/packages-microsoft-prod.deb
   sudo dpkg -i packages-microsoft-prod.deb
   sudo apt update
   ```

3. **Install the .NET SDK:**

   ```bash
   sudo apt install -y dotnet-sdk-8.0
   ```

---

### ✅ Step 2: Create and Run a C# Project

1. **Create a new console project:**

   ```bash
   dotnet new console -o HelloWorld
   cd HelloWorld
   ```

2. **Run the project:**

   ```bash
   dotnet run
   ```

---

### ✅ Step 3 (Optional): Run a Single C# File Without Creating a Project

1. **Create a file named `hello.cs`:**

   ```csharp
   // hello.cs
   using System;

   class Program {
       static void Main() {
           Console.WriteLine("Hello, Ubuntu!");
       }
   }
   ```

2. **Compile and run it manually:**

   ```bash
   dotnet new console -o tempApp
   cp hello.cs tempApp/Program.cs
   cd tempApp
   dotnet run
   ```

> There's no native `dotnet-script` or REPL in .NET 8+, but you can install the [dotnet-script](https://github.com/dotnet-script/dotnet-script) tool globally if you prefer scripting without full project setup.

---

dotnet-script: https://github.com/dotnet-script/dotnet-script

To run a **single C# file** on Ubuntu 24.04 without creating a full .NET project, you have two main options:

---

### ✅ Option 1: Use the `.NET SDK` with a Minimal Wrapper

Although `dotnet` doesn't support directly running individual `.cs` files like Python or Node.js, you can create a temporary project or script the process:

1. **Create your C# file (e.g., `hello.cs`):**

   ```csharp
   // hello.cs
   using System;

   class Program {
       static void Main() {
           Console.WriteLine("Hello from a single file!");
       }
   }
   ```

2. **Compile and run using `dotnet` (project-less way):**  
   Unfortunately, there's no `dotnet run hello.cs` support. But you can do:

   ```bash
   mcs hello.cs -out:hello.exe   # Using Mono C# compiler
   mono hello.exe                # Run the output with Mono
   ```

   > ⚠️ You must install Mono for this.

   Install Mono if needed:

   ```bash
   sudo apt update
   sudo apt install -y mono-complete
   ```

---

### ✅ Option 2: Use `dotnet-script` (for script-style C#)

This lets you run `.csx` (C# script) files **without needing a full project**:

1. **Install dotnet-script:**

   ```bash
   dotnet tool install -g dotnet-script
   ```

   Make sure `~/.dotnet/tools` is in your PATH:

   ```bash
   export PATH="$PATH:~/.dotnet/tools"
   ```

2. **Write a script file (`hello.csx`):**

   ```csharp
   Console.WriteLine("Hello from C# script!");
   ```

3. **Run it:**

   ```bash
   dotnet script hello.csx
   ```

---

### Summary

| Method            | Command                          | Notes                           |
| ----------------- | -------------------------------- | ------------------------------- |
| **Mono (mcs)**    | `mcs hello.cs && mono hello.exe` | Good for classic C#             |
| **dotnet-script** | `dotnet script hello.csx`        | Great for quick scripts         |
| **dotnet SDK**    | Create project (`dotnet new`)    | Required for full app structure |

Let me know if you'd like to [write a script to automate these runs](https://chatgpt.com/c/f) or [compare Mono vs .NET SDK performance](https://chatgpt.com/c/f).

```

```
