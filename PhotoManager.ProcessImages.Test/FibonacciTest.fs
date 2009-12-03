namespace PhotoManager.ProcessImages.Test

open NUnit.Framework
open PhotoManager.ProcessImages.Fibonacci

[<TestFixture>]
type FibonacciTestCases =  class
    
    new() = {}

    [<Test>]
    member x.TestFibonacciFifthIsThree() = Assert.AreEqual(8, GetFibonacciNumber(5));

    [<Test>]
    member x.FoldTest() = Assert.AreEqual(8, sumList);

    [<Test>]
    member x.RunFib() = Assert.AreEqual(8, fibit(5).ToString
)


    end