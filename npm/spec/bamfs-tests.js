var { expect } = require("chai"),
    bamfs = require('../bamfs'),
    fs = require('fs'),
    path = require('path'),
    shell = require('shelljs');

function createTestFiles(){
    if(fs.existsSync('./test_data')){
        shell.rm('-fr', './test_data');
    }
    
}

describe("bam fs", function () {
    it("should pass", function(){});

    it("should list files in directory", function () {
        var value = bamfs.getAllFiles("/tmp");
        console.log(value);
    })
});
