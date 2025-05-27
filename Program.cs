

using asp_obfuscate;

static void Main(string[] args)
{
    Console.WriteLine("entry");
    ObfuscatorSettings settings = new ObfuscatorSettings();
        Console.Clear();
        Console.WriteLine("=== Lua Obfuscator ===");
        Console.WriteLine("1. Set Input File");
        Console.WriteLine("2. Set Output File");
        Console.WriteLine($"3. Toggle Identifier Obfuscation: {settings.ObfuscateIdentifiers}");
        Console.WriteLine($"4. Toggle String Encoding: {settings.EncodeStrings}");
        Console.WriteLine($"5. Toggle Comment Stripping: {settings.StripComments}");
        Console.WriteLine("6. Run Obfuscator");
        Console.WriteLine("0. Exit");

        Console.Write("\nChoose an option: ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.Write("Enter path to Lua file: ");
                settings.InputPath = Console.ReadLine();
                break;
            case "2":
                Console.Write("Enter output path: ");
                settings.OutputPath = Console.ReadLine();
                break;
            case "3":
                settings.ObfuscateIdentifiers = !settings.ObfuscateIdentifiers;
                break;
            case "4":
                settings.EncodeStrings = !settings.EncodeStrings;
                break;
            case "5":
                settings.StripComments = !settings.StripComments;
                break;
            case "6":
                RunObfuscator(settings);
                Console.WriteLine("Press any key to return to menu...");
                Console.ReadKey();
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Invalid option. Press any key to continue...");
                Console.ReadKey();
                break;
        }
}


static void RunObfuscator(ObfuscatorSettings settings)
{
    if (!File.Exists(settings.InputPath))
    {
        Console.WriteLine("Input file does not exist.");
        return;
    }

    string input = File.ReadAllText(settings.InputPath);
    Console.WriteLine("Loaded input file.");

    // Just for test: Write original content to the output file
    File.WriteAllText(settings.OutputPath, input);
    Console.WriteLine("Wrote output file.");
    
    
}