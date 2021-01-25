var bamFs = (function () {
    var cliArgs = require('@bamapps/bam-cli-args'),
        _ = require('underscore'),
        actionsCore = require('@actions/core'),
        fs = require('fs'),
        path = require('path');

    var dependencies = {
        cliArgs: cliArgs,
        actionsCore: actionsCore
    }

    const getAllFiles = function (dirPath, arrayOfFiles) {
        files = fs.readdirSync(dirPath)

        arrayOfFiles = arrayOfFiles || []

        files.forEach(function (file) {
            if (fs.statSync(dirPath + "/" + file).isDirectory()) {
                arrayOfFiles = getAllFiles(dirPath + "/" + file, arrayOfFiles)
            } else {
                arrayOfFiles.push(path.join(dirPath, "/", file))
            }
        })

        return arrayOfFiles
    }

    return {
        bamArgs: cliArgs.args,
        scriptInfo: cliArgs.scriptInfo,
        /**
         * Traverse the specified directory returning all file paths
         * @param {*} dir 
         */
        getAllFiles: async function(dir){
            return getAllFiles(dir);
        },
        run: function (scriptArgs) {
            var _this = this;
            console.log(cliArgs.scriptInfo());
        },
        inject: function (obj) {
            dependencies = _.extend({}, dependencies, obj);
        },
        startProcess: function (options) {
            var opts = _.extend({}, { command: '', args: [], onStdOut: function () { }, onStdErr: function () { }, onExit: function () { } }, options);
            const { spawn } = require('child_process');
            const childProcess = spawn(opts.command, opts.args);
            childProcess.stdout.on('data', (data) => {
                opts.onStdOut(data);
            })
            childProcess.stderr.on('data', (data) => {
                opts.onStdErr(data);
            })
            childProcess.on('exit', (code) => {
                opts.onExit(code);
            })
        },
        exec: function (command, argsArray) {
            var _this = this;
            return new Promise((resolve, reject) => {
                _this.startProcess({
                    command: command,
                    args: argsArray,
                    onStdOut: function (data) {
                        resolve(data);
                    },
                    onStdErr: function (data) {
                        reject(data);
                    }
                });
            });
        },
    }
})()

if (typeof require !== 'undefined' && require.main === module) {
    bamFs.run(process.argv.slice(2));
}

module.exports = bamFs;