module Tests

open System
open Xunit

[<Fact>]
let ``Can square`` () =
    Assert.Equal(4., Home.square 2.)
