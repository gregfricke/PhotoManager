// Learn more about F# at http://fsharp.net
open System

let values = Seq.unfold (fun (index, last) -> Some (index, (index, index + last))) (1,1)
let output = 
    values 
    |> Seq.takeWhile(fun i -> i <= 10) 
    |> Seq.map (fun i -> i.ToString()) 
    |> Seq.reduce (fun state item -> state + ", " + item)
let foo = values
          |> Seq.takeWhile(fun x -> x<100)
          |> Seq.map(fun x -> x.ToString())
          |> Seq.reduce (fun state item -> state + ", " + item)
printf "%A" foo
let input = Console.ReadLine()