﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_000_01_Program_Structure
{   /*
    C# is a simple, modern, general-purpose, object-oriented programming language developed by Microsoft within its .NET initiative led by Anders Hejlsberg. This tutorial will teach you basic C# programming and will also take you through various advanced concepts related to C# programming language.

Audience
This tutorial has been prepared for the beginners to help them understand basic C# programming.

Prerequisites
C# programming is very much based on C and C++ programming languages, so if you have a basic understanding of C or C++ programming, then it will be fun to learn C#.
C# is a modern, general-purpose, object-oriented programming language developed by Microsoft and approved by European Computer Manufacturers Association (ECMA) and International Standards Organization (ISO).

C# was developed by Anders Hejlsberg and his team during the development of .Net Framework.

C# is designed for Common Language Infrastructure (CLI), which consists of the executable code and runtime environment that allows use of various high-level languages on different computer platforms and architectures.

The following reasons make C# a widely used professional language −

It is a modern, general-purpose programming language
It is object oriented.
It is component oriented.
It is easy to learn.
It is a structured language.
It produces efficient programs.
It can be compiled on a variety of computer platforms.
It is a part of .Net Framework.
Strong Programming Features of C#
Although C# constructs closely follow traditional high-level languages, C and C++ and being an object-oriented programming language. It has strong resemblance with Java, it has numerous strong programming features that make it endearing to a number of programmers worldwide.

Following is the list of few important features of C# −

Boolean Conditions
Automatic Garbage Collection
Standard Library
Assembly Versioning
Properties and Events
Delegates and Events Management
Easy-to-use Generics
Indexers
Conditional Compilation
Simple Multithreading
LINQ and Lambda Expressions
Integration with Windows
In this chapter, we will discuss the tools required for creating C# programming. We have already mentioned that C# is part of .Net framework and is used for writing .Net applications. Therefore, before discussing the available tools for running a C# program, let us understand how C# relates to the .Net framework.

The .Net Framework
The .Net framework is a revolutionary platform that helps you to write the following types of applications −

Windows applications
Web applications
Web services
The .Net framework applications are multi-platform applications. The framework has been designed in such a way that it can be used from any of the following languages: C#, C++, Visual Basic, Jscript, COBOL, etc. All these languages can access the framework as well as communicate with each other.

The .Net framework consists of an enormous library of codes used by the client languages such as C#. Following are some of the components of the .Net framework −

Common Language Runtime (CLR)
The .Net Framework Class Library
Common Language Specification
Common Type System
Metadata and Assemblies
Windows Forms
ASP.Net and ASP.Net AJAX
ADO.Net
Windows Workflow Foundation (WF)
Windows Presentation Foundation
Windows Communication Foundation (WCF)
LINQ
For the jobs each of these components perform, please see ASP.Net - Introduction, and for details of each component, please consult Microsoft's documentation.
Before we study basic building blocks of the C# programming language, let us look at a bare minimum C# program structure so that we can take it as a reference in upcoming chapters.

Creating Hello World Program
A C# program consists of the following parts −

Namespace declaration
A class
Class methods
Class attributes
A Main method
Statements and Expressions
Comments

    using System;

namespace HelloWorldApplication {
   class HelloWorld {
      static void Main(string[] args) {
          my first program in C# 
         Console.WriteLine("Hello World");
         Console.ReadKey();
      }
   }
}
When this code is compiled and executed, it produces the following result −

Hello World
Let us look at the various parts of the given program −

The first line of the program using System; - the using keyword is used to include the System namespace in the program.A program generally has multiple using statements.

The next line has the namespace declaration.A namespace is a collection of classes.The HelloWorldApplication namespace contains the class HelloWorld.

The next line has a class declaration, the class HelloWorld contains the data and method definitions that your program uses.Classes generally contain multiple methods. Methods define the behavior of the class. However, the HelloWorld class has only one method Main.

The next line defines the Main method, which is the entry point for all C# programs. The Main method states what the class does when executed.

The next line  is ignored by the compiler and it is put to add comments in the program.


The Main method specifies its behavior with the statement Console.WriteLine("Hello World");

WriteLine is a method of the Console class defined in the System namespace.This statement causes the message "Hello, World!" to be displayed on the screen.

The last line Console.ReadKey(); is for the VS.NET Users.This makes the program wait for a key press and it prevents the screen from running and closing quickly when the program is launched from Visual Studio .NET.

It is worth to note the following points −


C# is case sensitive.

All statements and expression must end with a semicolon (;).

The program execution starts at the Main method.

Unlike Java, program file name could be different from the class name.

Compiling and Executing the Program
If you are using Visual Studio.Net for compiling and executing C# programs, take the following steps −

Start Visual Studio.

On the menu bar, choose File -> New -> Project.

Choose Visual C# from templates, and then choose Windows.

Choose Console Application.

Specify a name for your project and click OK button.

This creates a new project in Solution Explorer.

Write code in the Code Editor.

Click the Run button or press F5 key to execute the project. A Command Prompt window appears that contains the line Hello World.

You can compile a C# program by using the command-line instead of the Visual Studio IDE −

Open a text editor and add the above-mentioned code.

Save the file as helloworld.cs

Open the command prompt tool and go to the directory where you saved the file.

Type csc helloworld.cs and press enter to compile your code.

If there are no errors in your code, the command prompt takes you to the next line and generates helloworld.exe executable file.

Type helloworld to execute your program.

You can see the output Hello World printed on the screen.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
