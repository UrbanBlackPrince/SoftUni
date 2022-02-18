const {assert, expect} = require('chai');
const sum = require('../04. Sum of Numbers');

describe('tests', () =>{
    it('should correct sum', ()=>{
        assert.equal(sum([1, 2]), 3);
    })
    
})