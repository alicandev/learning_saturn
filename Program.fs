namespace SaturnFundamentals

open Saturn
open Giraffe
open SaturnFundamentals.Router

module App =
    let app = application {
        use_router myRouter
    }
    
    [<EntryPoint>]  
    let main args = 
        run app
        0