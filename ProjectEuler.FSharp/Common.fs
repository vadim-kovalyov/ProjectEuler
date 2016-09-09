namespace ProjectEuler

module Seq =
    let merge operator seqA seqB = 
        seqA
        |> Seq.collect (fun x -> Seq.map (fun y -> operator y x) seqB)

    do ()