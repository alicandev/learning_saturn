namespace Hello

open Giraffe.GiraffeViewEngine
open Saturn

module Views =
    let index = "Hello from Saturn!"

    // the index function will result in the following HTML code:
    // <div>                                                      
    //     <h2>Hello from Saturn!</h2>                            
    // </div>                                                     
    