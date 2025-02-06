﻿using System.IO;
using System.Xml.Serialization;

// Save user information in a file next to the main executable
public class Config
{
    // Configuration instance
    public static Config Current { get; private set; } = new Config();

    // Serializer for configuration 
    private static readonly XmlSerializer _serializer = new XmlSerializer(typeof(Config));

    // Configuration file
    private static string Path => $"{typeof(Config).Assembly.Location}.xml";

    // Serialize configuration file
    public static void Save()
    {
        try
        {
            using (var writer = new StreamWriter(Path))
            {
                _serializer.Serialize(writer, Current);
            }
        }
        catch { }
    }

    // Deserialize configuration file
    public static void Load()
    {
        try
        {
            if (!File.Exists(Path)) return;

            using (var writer = new StreamReader(Path))
            {
                Current = (Config)_serializer.Deserialize(writer);
            }
        }
        catch { }
    }

    #region Properties
    public string IP { get; set; }
    public string Licensee { get; set; }
    public string Key { get; set; }

    #endregion
}

