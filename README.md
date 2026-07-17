# ☕ Ever After Café Folder Maker
## Week 8 – JSON Implementation

**Student:** Desiree Kamerer Fuentes

---

# Project Overview

The Ever After Café Folder Maker is a Visual Basic .NET console application developed for my Application Development course.

The purpose of this project is to automatically create a folder structure for the Ever After Café project, organize project files, and demonstrate the programming concepts learned throughout the course.

Week 8 builds on the Week 6–7 Folder Maker App by adding **JSON serialization**, allowing project information to be saved in a `CafeData.json` file instead of being lost when the application closes.

---

# Repository Guide

This repository contains all files required for the Week 8 assignment.

## Source Code

The main Visual Studio project files are located in the root of this repository.

Project files include:

- Module1.vb
- CafeProject.vb
- App.config
- EverAfterCafeFolderMaker.vbproj
- EverAfterCafeFolderMaker.slnx
- packages.config
- My Project folder

---

## Documentation

The following documentation is included for grading:

- App Development Document.docx
- Week 8 Application Change Log.txt
- Week 8 JSON Notes.txt
- Code_Examples.txt
- README.txt

If a document does not preview directly on GitHub (such as `.docx` or `.txt` files), it can still be opened by selecting the file.

---

## Screenshots

The **Screenshots** folder contains proof of completion, including:

- Console application running
- Generated project folders
- README.txt
- CafeData.json
- GitHub repository
- Discord post

---

# Week 8 Improvements

This version of the project adds JSON serialization using the **Newtonsoft.Json** NuGet package.

The application now creates a **CafeData.json** file that stores:

- Café Name
- Date the project was created
- Number of folders created

This allows project information to be saved for future use rather than disappearing when the application closes.

---

# Files Created by the Application

When the application runs, it automatically creates:

- Project folders
- README.txt
- CafeData.json

---

# How to Run

1. Open the solution in Visual Studio 2022.
2. Build and run the application.
3. Enter a café name.
4. The application creates the project folders.
5. A README.txt file is generated.
6. A CafeData.json file is created to save the project information.

---

# Programming Concepts Demonstrated

This project demonstrates:

- Variables
- Functions and Procedures
- Classes and Objects
- File Input/Output
- JSON Serialization
- NuGet Package Management
- Folder and File Creation

---

# Version History

## Week 6–7

The original Folder Maker App included:

- Folder creation
- README generation
- Project organization
- Application documentation

## Week 8

The project was enhanced by adding:

- JSON serialization
- CafeProject class
- SaveCafeData() procedure
- Newtonsoft.Json package
- CafeData.json generation
- Updated documentation
- Code examples
- Function and procedure comments

---

# Summary

Week 8 extends the original Folder Maker App by allowing project information to be saved in JSON format. This demonstrates how application data can be preserved after the program closes instead of being lost when the application ends.

Thank you for reviewing my Week 8 submission.
