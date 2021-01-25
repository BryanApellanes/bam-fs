var { expect } = require("chai"),
    bamfs = require('../bamfs');

describe("bam fs", function () {
    it("should pass", function(){});

    it("should list files in directory", function () {
        var value = bamfs.getAllFiles("/tmp");
        console.log(value);
    })
});
