const { chromium } = require('playwright-chromium');
const { expect } = require('chai');

describe('E2E tests', function () {
    this.timeout(6000);

    let browser, page;

    before(async () => {
        browser = await chromium.launch({ handless: false, slowMo: 500 });
    });
    after(async () => {
        await browser.close();
    });
    beforeEach(async () => {
        page = await browser.newPage();
    });
    afterEach(async () => {
        await page.close();
    });

    it('work', async() => {
        await new Promise(r => setTimeout(r, 2000));
        expect(1).to.equal(1);
    })

})