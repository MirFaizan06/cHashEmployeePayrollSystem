using System;
using System.Collections.Generic;
using System.IO;

public static class EnvLoader
{
    private static Dictionary<string, string> envVars = new Dictionary<string, string>();

    public static void Load()
    {
        if (!File.Exists(".env"))
            return;

        var lines = File.ReadAllLines(".env");

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                continue;

            var parts = line.Split('=', 2);
            if (parts.Length == 2)
            {
                envVars[parts[0]] = parts[1];
            }
        }
    }

    public static string Get(string key)
    {
        if (envVars.ContainsKey(key))
            return envVars[key];

        return "";
    }
}