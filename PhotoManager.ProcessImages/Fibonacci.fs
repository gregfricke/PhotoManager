namespace PhotoManager.ProcessImages

open System
module Fibonacci =
    let rec GetFibonacciNumber = function
        | 0 -> 1
        | 1 -> 1
        | n -> GetFibonacciNumber (n - 1) + GetFibonacciNumber (n - 2)
     
    let rec GetFibonacciNumber2 x = 
        match x with
        | 0|1 -> x
        | _ -> GetFibonacciNumber2(x-1) + GetFibonacciNumber2(x-2)

    let accumulate acc x = acc + x

    let sumList = List.fold accumulate 0 [1 .. 10] 

    let fib = Seq.unfold(fun (last, current) -> Some (last, (current, current + last))) (1, 1)

    let fibit max =
        fib |> Seq.takeWhile (fun i -> i <= max) 