Ever After Café Folder Maker
Week 8

Student:
Desiree Kamerer Fuentes

Project Purpose
The Ever After Café Folder Maker is a Visual Basic .NET console application that creates the folder structure for the Ever After Café project. It helps organize project files automatically and now saves important project information using JSON.

Project Contents
- Module1.vb
- CafeProject.vb
- App.config
- EverAfterCafeFolderMaker.vbproj
- EverAfterCafeFolderMaker.slnx
- packages.config
- My Project folder
- README.txt

Week 8 Improvements
This version of the project adds JSON serialization using the Newtonsoft.Json NuGet package. The application now creates a CafeData.json file that stores:
- Café name
- Date the project was created
- Number of folders created

How to Run
1. Open the project in Visual Studio.
2. Run the application.
3. Enter a café name.
4. The application creates the project folders.
5. A README.txt file is created.
6. A CafeData.json file is created to save the project information.

Files Created by the Application
- README.txt
- CafeData.json
- Project folders for the café

Concepts Demonstrated
- Variables
- Functions and Procedures
- File Input/Output
- JSON Serialization
- NuGet Package Management
- Folder and File Creation

Summary
Week 8 extends the original Folder Maker App by allowing project information to be saved in JSON format. This demonstrates how application data can be preserved after the program closes instead of being lost when the application ends.