public string WebClientDownload(string url) {
    WebClient w = new WebClient();
    return w.DownloadString(url);
}

// Has this been superceded by httpclient?
