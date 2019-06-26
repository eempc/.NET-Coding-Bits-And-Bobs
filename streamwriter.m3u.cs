public static string musicFolder = @"D:\Music";
public static string m3uFileName = @"OllieKins.m3u";
public static string pathM3Ufile = Path.Combine(musicFolder, m3uFileName);

static void Main(string[] args) {
    if (!File.Exists(pathM3Ufile)) {
        using (StreamWriter sw = File.CreateText(pathM3Ufile)) {
            sw.WriteLine("#EXTM3U");
        }
    }

    if (args != null && args.Length > 0) {
            AddToM3U(args);
    }
}

public static void AddToM3U(string[] args) {
    using (StreamWriter sw = File.AppendText(pathM3Ufile)) {
        foreach (string path in args) {
            string fileName = Path.GetFileNameWithoutExtension(path);
            string relativePath = path.Substring(musicFolder.Length + 1);
            sw.WriteLine("#EXTINF:-1," + fileName + "\r\n" + relativePath);

        }
    }
}
