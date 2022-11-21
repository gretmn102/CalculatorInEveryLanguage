module Calc
open System

type Op =
    | Add
    | Sub
    | Mul
    | Div
    | Rem
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
[<RequireQualifiedAccess>]
module Op =
    let tryParse (str: string) =
        match Seq.tryHead str with
        | Some c ->
            match c with
            | '+' -> Some Add
            | '-' -> Some Sub
            | '*' -> Some Mul
            | '/' -> Some Div
            | '%' -> Some Rem
            | _ -> None
        | None -> None

    let getOperation (op: Op) =
        match op with
        | Add -> (+)
        | Sub -> (-)
        | Mul -> ( * )
        | Div -> (/)
        | Rem -> (%)

let rec read (mainMessage: string) failMessage tryParse =
    let rec loop () =
        Console.Write mainMessage

        let res = Console.ReadLine ()

        match tryParse res with
        | Some res -> res
        | None ->
            printfn failMessage
            loop ()
    loop ()

module Double =
    let tryParse (str: string) =
        match System.Double.TryParse str with
        | true, res -> Some res
        | false, _ -> None

let start () =
    let lhs =
        read
            "Input the first operand: "
            "Expected float number! Please try again."
            Double.tryParse

    let op =
        read
            "Input operator (+, -, *, /, %): "
            "Expected one of +, -, *, /, %%! Please try again."
            Op.tryParse

    let rhs =
        read
            "Input the second operand: "
            "Expected float number! Please try again."
            Double.tryParse

    Op.getOperation op lhs rhs
    |> printfn "%A"
