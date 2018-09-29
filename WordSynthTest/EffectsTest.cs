using System;
using WordSynth;
using Xunit;

namespace WordSynthTest {
  public class EffectsTest {
    [Fact]
    public void TestReverse() {
      Func<string, string> effect = Effects.Reverce;
      Assert.Equal("#C si lufrednow", effect.Invoke("C# is wonderful"));
    }
  }
}
