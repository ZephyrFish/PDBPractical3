using System.Diagnostics;
using NUnit.Framework;
using PDBPractical1.ObserverViaEvents;

namespace PDBPractical1.UnitTests;

[TestFixture]
public class CountdownTests
{
    [Test]
    public void ItHappens_TwoSubs_AllSubsRecieve()
    {
        string expected = "nothing really happens...";
        string? actual = null;
        Stopwatch time = new Stopwatch();
        
        Countdown timer = new();
        timer.handler += (sender, s) => actual = s;
        
        time.Start();
        timer.ItHappens(1000);
        time.Stop();
        
        Assert.AreEqual(expected, actual, "Событие срабатывает неверно.");
        Assert.Greater(time.ElapsedMilliseconds, 999, "Таймер события работает неверно.");
    }
}