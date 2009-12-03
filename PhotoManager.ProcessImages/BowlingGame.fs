namespace PhotoManager.ProcessImages

open System
open Microsoft.FSharp.Collections
open System.Collections

module BowlingGame =

    let rec score_bowls bowls =
        let rec score_bowls' frame l =
            match l with
                | _ when frame = 10 -> (List.foldBack(fun x y -> x + y) l 0)
                | [] -> 0
                | [f] -> f
                | [f;s] -> f + s
                | f :: s :: n :: tail when f = 10 -> 10 + s + n + score_bowls' (frame+1) ( s :: n :: tail )
                | f :: s :: n :: tail when (f + s) = 10 -> 10 + n + score_bowls' (frame+1) (n :: tail)
                | f :: s :: n :: tail -> f + s + score_bowls' (frame+1) (n :: tail)
        score_bowls' 1 bowls
    