# Day 2 Review

## Assemblies and Visual Studio
What is your understanding of what is meant by the term "Assembly" in .NET?

- The result of the compiled project in .NET. It can be referenced by another project, or run directly (exe for example)

What is the relationship between an assembly and visual studio Project?

- Visual Studio Project defines codes, dependencies, for example, of that project. An assembly is then the output of that compiled project.

What is a solution in Visual Studio?

- A container that organizes and manages one or more related projects. It's represented as an .sln file.

What are the two types of Assemblies discussed in class?

- private and public, can be either a .ddl and .exe

What is the thing that makes an assembly "Runnable" - what is the *entry* point of an Assembly?

- A startup class is the entry point that makes an assembly runnable when it is compiled. 

## What is the "Common Language Runtime (CLR)" 

- It's a VM enviroment that helps compile .NET code

## What is "Dotnet Core"? What's that all about?

- It's an open-source framework that allows devs to create applications on multiple different OS.

## What is the Common Type System (CTS)?

- A standard that speccifies how type definitions and specific values of types are represented in memory.

## What are the "First Class Citizens" of .NET?

- An entity that is supported by the platform. It can be pased as an arg, returned from functions, stored in variables, and manipulated dynamically.
