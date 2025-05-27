namespace asp_obfuscate;

public class ObfuscatorSettings
{
    public string InputPath { get; set; }
    public string OutputPath { get; set; }
    public bool ObfuscateIdentifiers { get; set; }
    public bool EncodeStrings { get; set; }
    public bool StripComments { get; set; }
}