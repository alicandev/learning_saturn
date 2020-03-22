namespace SaturnFundamentals

open Saturn
open Giraffe

module Router =
    let myRouter = router {
        get "/foo" (text "Hello")
        get "/bar" (json {| Name = "Frodo"; Age = 60 |})
        // get the helloView function to determine what page to load when navigated to `http://localhost:8085/hello
        forward "/hello" Hello.Controller.helloView
    }