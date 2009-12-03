namespace PhotoManager.ProcessImages.Test

open NUnit.Framework
open PhotoManager.ProcessImages.BowlingGame

[<TestFixture>]
type BowlingTestCases =  class
    new() = {}
 
    [<Test>]
    member x.SimpleScoring() = Assert.AreEqual(6, score_bowls [1;2;3] )
    [<Test>]
    member x.ScoreSpare() = Assert.AreEqual(12, score_bowls [2;8;1] )
    [<Test>]
    member x.ScoreStrike() = Assert.AreEqual(16, score_bowls [10;1;2] )
    [<Test>]
    member x.ScorePerfectGame() = Assert.AreEqual( 300, score_bowls [for i in 1..12 -> 10] )
    [<Test>]
    member x.SpareLastFrame() = Assert.AreEqual( 11, score_bowls ([for i in 1..18 -> 0] @ [2;8;1]) )
    [<Test>]
    member x.StrikeLastFrame() = Assert.AreEqual( 21, score_bowls ([for i in 1..18 -> 0] @ [10;10;1]) )

    [<Test>]
    member x.foo() = Assert.AreEqual( 1, 1 )
    end
