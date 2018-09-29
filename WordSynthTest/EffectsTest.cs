using System;
using WordSynth;
using Xunit;

namespace WordSynthTest {
  public class EffectsTest {
    [Fact]
    public void TestReverse() {
      Func<string, string> effect = Effects.Reverce();
      Assert.Equal("#C si lufrednow", effect.Invoke("C# is wonderful"));
    }

    [Fact]
    public void TestEcho() {
      Func<string, string> effect = Effects.Echo(2);
      Assert.Equal("CC## iiss wwoonnddeerrffuull!!", effect.Invoke("C# is wonderful!"));
    }

    [Fact]
    public void TestLoud() {
      Func<string, string> effect = Effects.Loud(2);
      Assert.Equal("C#!! IS!! WONDERFUL!!!", effect.Invoke("C# is wonderful!"));
    }
  }
}
