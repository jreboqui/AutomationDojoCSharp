using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaiPractice;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class AssertOnThings : PageTest {
    [Test]
    public async Task ThisTestGoesToAPageAndAsserts() {
        await Page.GotoAsync("https://commitquality.com");
    }
}

