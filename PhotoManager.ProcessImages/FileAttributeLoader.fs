namespace PhotoManager.ProcessImages

open System
open System.IO
open System.Windows.Media
open System.Windows.Media.Imaging

module FileAttributeLoader=
    let AsyncGetFiles(directory) = System.IO.Directory.GetFiles(directory) |> Array.toList
    let x d = System.IO.File.GetAttributes(d.Head)
    let firstFileAttributes = System.IO.File.GetAttributes(AsyncGetFiles("C:\Users\gregory_fricke\Desktop\pics").Head)
    let firstFileProps = System.IO.File.GetAttributes(AsyncGetFiles("C:\Users\gregory_fricke\Desktop\pics").Head)
      
    let image = new FileStream(@"C:\Users\gregory_fricke\Desktop\pics\CSC_0086.JPG",FileMode.Open,FileAccess.Read,FileShare.Read)

    let decoder = new JpegBitmapDecoder(image,BitmapCreateOptions.PreservePixelFormat,BitmapCacheOption.Default)
          
    let meta =  decoder.Frames.Item(0).Metadata :?> BitmapMetadata

    //printfn "%A %A" meta.DateTaken meta.CameraModel

    //let readSomething = Console.ReadLine()