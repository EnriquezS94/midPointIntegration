
let f x : float =
     sin x

let integration (a:float) (b:float) (N:int) : float =

    let h = (b - a) / (float N)
    let mutable midpoint =  0.0
    
    for i = 0 to N-1 do
        let x = (a+h/2.0)
        let funcEval = f(x + float i * h)
        midpoint <- midpoint + funcEval  * h
    midpoint 


[<EntryPoint>]
let main argv = 
    let a = 0.0
    let b = 3.14159
    let N = 100
    let x = integration a b N
    printf "%f" x
    printf "\n"
    

    System.Console.ReadKey() |> ignore
    0 // return an integer exit code


    