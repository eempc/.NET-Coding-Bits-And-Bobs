//Three methods for doing so

public string ExtractDigitsRecursive(string str) {
    if (str.Length < 1)
        return "";
    else if (int.TryParse(str.Substring(0, 1), out int x))
        return str.Substring(0, 1) + ExtractDigitsRecursive(str.Substring(1));
    else
        return ExtractDigitsRecursive(str.Substring(1));
}

public string ExtractDigitsLoop1(string str) {
    string result = String.Empty;
    foreach (char c in str) {
        if (c >= '0' && c <= '9') result += c;
    }
    return result;
}

public string ExtractDigitsLoop2(string str) {
    string result = String.Empty;
    foreach (char c in str) {
        if (Char.IsDigit(c)) result += c;
    }
    return result;
}
