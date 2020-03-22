namespace Hello

open Saturn
open Giraffe.ResponseWriters

module Controller =
    // tell Saturn to create an HTML page using the index function inside "HelloViews.fs"
    let indexAction =
        htmlView (Views.index)

    // let Saturn know that the page is located at the root
    let helloView = router {
        get "/" indexAction
    }
