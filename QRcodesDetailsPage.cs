using ZXing.QrCode; // Standrad ZXing NUget
using ZXing.CoreCompat.System.Drawing; // Manual Nuget package install: Install-Package ZXing.Net.Bindings.CoreCompat.System.Drawing -Version 0.16.5-beta

public byte[] imageBytes { get; set; }
public UserAddress UserAddress { get; set; }

public async Task<IActionResult> OnGetAsync(int? id) {
  if (id == null) {
    return NotFound();
  }

  UserAddress = await _context.UserAddress.FirstOrDefaultAsync(m => m.Id == id);
  imageBytes = TextToBytes();

  if (UserAddress == null) {
    return NotFound();
  }
  return Page();
}

public static byte[] TextToBytes() {
    BarcodeWriter writer = new BarcodeWriter {
        Format = ZXing.BarcodeFormat.QR_CODE,
        Options = new QrCodeEncodingOptions {
            Width = 300,
            Height = 300
        }
    };

    // Encode string to bitmap
    Bitmap qrCodeImage = writer.Write("test");

    // Then convert to byte array using MemoryStream
    using (MemoryStream stream = new MemoryStream()) {
        qrCodeImage.Save(stream, ImageFormat.Png);
        return stream.ToArray();
    }
}


<img src="data:image;base64, @System.Convert.ToBase64String(Model.imageBytes)" />

