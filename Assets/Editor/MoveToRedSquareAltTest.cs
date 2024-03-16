using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;

public class MoveToRedSquareAltTest
{
    public AltDriver altDriver;

    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver = new AltDriver();
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void Test()
    {
        var Button = altDriver.WaitForObject(By.PATH, "/Canvas/InitScreen/Button");
        Button.Click();
        var RightButton = altDriver.WaitForObject(By.PATH, "/UI/GameMenu/Container/RightButton");
        altDriver.HoldButton(RightButton.GetScreenPosition(), 0.7f);
        var UpButton = altDriver.WaitForObject(By.PATH, "/UI/GameMenu/Container/VericalContainer/UpButton");
        altDriver.HoldButton(UpButton.GetScreenPosition(), 2.4f);
        var LeftButton = altDriver.WaitForObject(By.PATH, "/UI/GameMenu/Container/LeftButton");
        altDriver.HoldButton(LeftButton.GetScreenPosition(), 2f);
        var RestartButton = altDriver.WaitForObject(By.PATH, "/UI/WinDialog/RestartButton");
        RestartButton.Click();
    }
}