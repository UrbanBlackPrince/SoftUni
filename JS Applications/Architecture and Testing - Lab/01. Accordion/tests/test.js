const { chromium } = require('playwright-chromium');
const { expect } = require('chai');

let browser, page;

describe('E2E tests', function () {
    this.timeout(6000);
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

    
    it('goto', async() => {
        await page.goto('http://127.0.0.1:5500/index.html');
        const content = await page.textContent('#main');

        expect(content).to.contains('Unix');
    })
})