Imports Newtonsoft.Json
Imports System.IO
Module Module1

    Sub Main()

        ' Displays the welcome screen.
        DisplayWelcome()

        ' Ask the user for the café name.
        Console.Write("Enter café name: ")
        Dim cafeName As String = Console.ReadLine()

        ' Check for blank input.
        If String.IsNullOrWhiteSpace(cafeName) Then
            Console.WriteLine()
            Console.WriteLine("Error: Café name cannot be blank.")
            Console.WriteLine("Press any key to exit...")
            Console.ReadKey()
            Return
        End If

        ' Create the project folders.
        CreateFolders(cafeName)

        ' Create the README file.
        CreateReadMe(cafeName)

        'Saves the cafe name, creation date, and folder count to a JSON file.
        SaveCafeData(cafeName)

        ' Display success message.
        DisplaySuccess(cafeName)

        Console.ReadKey()

    End Sub

    ' Displays the welcome screen.
    Sub DisplayWelcome()

        Console.Title = "Ever After Café Folder Maker"

        Console.WriteLine("=========================================")
        Console.WriteLine("      Ever After Café Folder Maker")
        Console.WriteLine("=========================================")
        Console.WriteLine()

    End Sub

    ' Creates the folder structure for the café.
    Sub CreateFolders(cafeName As String)

        Directory.CreateDirectory(cafeName)
        Directory.CreateDirectory(Path.Combine(cafeName, "Menu"))
        Directory.CreateDirectory(Path.Combine(cafeName, "Hours"))
        Directory.CreateDirectory(Path.Combine(cafeName, "Images"))
        Directory.CreateDirectory(Path.Combine(cafeName, "Docs"))

    End Sub

    ' Creates the README.txt file.
    Sub CreateReadMe(cafeName As String)

        ' Creates the path to the README.txt file.
        Dim readmePath As String = Path.Combine(cafeName, "README.txt")

        ' Contents of the README file.
        Dim readmeText As String =
        "# Week 6 Folder Maker App" & Environment.NewLine & Environment.NewLine &
        "## Purpose" & Environment.NewLine &
        "Creates the folder structure for the ever after Café project." & Environment.NewLine & Environment.NewLine &
        "## How To Run" & Environment.NewLine &
        "1. Open the project in Visual Studio." & Environment.NewLine &
        "2. Press F5 to run the program." & Environment.NewLine &
        "3. Enter the café name." & Environment.NewLine &
        "4. Press Enter." & Environment.NewLine &
        "5. The folders and README.txt file will be created." & Environment.NewLine & Environment.NewLine &
        "## Folder Structure Created" & Environment.NewLine &
        "- Menu" & Environment.NewLine &
        "- Hours" & Environment.NewLine &
        "- Images" & Environment.NewLine &
        "- Docs" & Environment.NewLine &
        "- README.txt" & Environment.NewLine & Environment.NewLine &
        "## Story to Project Connection" & Environment.NewLine &
        "This utility creates the project folders for Ever After Café, a Disney-inspired coffee shop project." & Environment.NewLine & Environment.NewLine &
        "## Team Members" & Environment.NewLine &
        "Individual Project" & Environment.NewLine &
        "Student: Desiree Kamerer Fuentes" & Environment.NewLine & Environment.NewLine &
        "## Screenshots" & Environment.NewLine &
        "- Console application" & Environment.NewLine &
        "- Generated folders" & Environment.NewLine &
        "- Generated README.txt" & Environment.NewLine &
        "- GitHub repository" & Environment.NewLine &
        "- Discord post"

        ' Writes the README.txt file.
        File.WriteAllText(readmePath, readmeText)

    End Sub

    ' Displays a success message after the folders are created.
    Sub DisplaySuccess(cafeName As String)

        Console.WriteLine()
        Console.WriteLine("Folders created successfully!")
        Console.WriteLine()
        Console.WriteLine("Location:")
        Console.WriteLine(Path.GetFullPath(cafeName))
        Console.WriteLine()
        Console.WriteLine("README.txt created successfully!")
        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")


    End Sub
    ' Saves the café information to a JSON file.
    Sub SaveCafeData(cafeName As String)

        Dim cafe As New CafeProject()

        cafe.CafeName = cafeName
        cafe.CreatedDate = Date.Now.ToString("MM/dd/yyyy")
        cafe.FolderCount = 4

        Dim json As String = JsonConvert.SerializeObject(cafe, Formatting.Indented)

        File.WriteAllText(Path.Combine(cafeName, "CafeData.json"), json)

    End Sub

End Module
