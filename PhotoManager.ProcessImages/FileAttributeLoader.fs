namespace PhotoManager.ProcessImages

open System
open System.Net
open System.IO
open System.Windows.Media
open System.Windows.Media.Imaging

module FileManager = 
    let GetFilesFromDirectory directory = 
        Directory.GetFiles(directory) 
        |> Array.map(fun file->file)
        //|> Array.map (fun file->File.GetAttributes(file)) |>
                            
    let image = new FileStream(@"C:\Users\gregory_fricke\Desktop\pics\CSC_0086.JPG",FileMode.Open,FileAccess.Read,FileShare.Read)

    let decoder = new JpegBitmapDecoder(image,BitmapCreateOptions.PreservePixelFormat,BitmapCacheOption.Default)
          
    let meta =  decoder.Frames.Item(0).Metadata :?> BitmapMetadata

    //printfn "%A %A" meta.DateTaken meta.CameraModel

    //let readSomething = Console.ReadLine()